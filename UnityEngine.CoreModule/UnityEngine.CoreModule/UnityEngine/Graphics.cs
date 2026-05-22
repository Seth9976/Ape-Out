using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000061 RID: 97
	public class Graphics : Object
	{
		// Token: 0x060005D9 RID: 1497 RVA: 0x000245D8 File Offset: 0x000227D8
		// Note: this type is marked as 'beforefieldinit'.
		static Graphics()
		{
			Il2CppClassPointerStore<Graphics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Graphics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Graphics>.NativeClassPtr);
			Graphics.NativeFieldInfoPtr_kMaxDrawMeshInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphics>.NativeClassPtr, "kMaxDrawMeshInstanceCount");
			Graphics.NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663794);
			Graphics.NativeMethodInfoPtr_Internal_SetNullRT_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663795);
			Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Private_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663796);
			Graphics.NativeMethodInfoPtr_CopyTexture_Slice_AllMips_Private_Static_Void_Texture_Int32_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663797);
			Graphics.NativeMethodInfoPtr_Internal_DrawTexture_Internal_Static_Void_byref_Internal_DrawTextureArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663798);
			Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Private_Static_Void_Mesh_Int32_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663799);
			Graphics.NativeMethodInfoPtr_Internal_BlitMaterial5_Private_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663800);
			Graphics.NativeMethodInfoPtr_Blit2_Private_Static_Void_Texture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663801);
			Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663802);
			Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663803);
			Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663804);
			Graphics.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663805);
			Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663806);
			Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663807);
			Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663808);
			Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663809);
			Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663810);
			Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Injected_Private_Static_Void_byref_RenderBuffer_byref_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663812);
			Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Static_Void_Mesh_Int32_byref_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphics>.NativeClassPtr, 100663813);
			Graphics.GetActiveColorGamutDelegateField = IL2CPP.ResolveICall<Graphics.GetActiveColorGamutDelegate>("UnityEngine.Graphics::GetActiveColorGamut");
			Graphics.get_activeTierDelegateField = IL2CPP.ResolveICall<Graphics.get_activeTierDelegate>("UnityEngine.Graphics::get_activeTier");
			Graphics.set_activeTierDelegateField = IL2CPP.ResolveICall<Graphics.set_activeTierDelegate>("UnityEngine.Graphics::set_activeTier");
			Graphics.GetPreserveFramebufferAlphaDelegateField = IL2CPP.ResolveICall<Graphics.GetPreserveFramebufferAlphaDelegate>("UnityEngine.Graphics::GetPreserveFramebufferAlpha");
			Graphics.GetMinOpenGLESVersionDelegateField = IL2CPP.ResolveICall<Graphics.GetMinOpenGLESVersionDelegate>("UnityEngine.Graphics::GetMinOpenGLESVersion");
			Graphics.Internal_SetRandomWriteTargetRTDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetRandomWriteTargetRTDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetRT");
			Graphics.Internal_SetRandomWriteTargetBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetRandomWriteTargetBufferDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetBuffer");
			Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegate>("UnityEngine.Graphics::Internal_SetRandomWriteTargetGraphicsBuffer");
			Graphics.ClearRandomWriteTargetsDelegateField = IL2CPP.ResolveICall<Graphics.ClearRandomWriteTargetsDelegate>("UnityEngine.Graphics::ClearRandomWriteTargets");
			Graphics.CopyTexture_FullDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_FullDelegate>("UnityEngine.Graphics::CopyTexture_Full");
			Graphics.CopyTexture_SliceDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_SliceDelegate>("UnityEngine.Graphics::CopyTexture_Slice");
			Graphics.CopyTexture_RegionDelegateField = IL2CPP.ResolveICall<Graphics.CopyTexture_RegionDelegate>("UnityEngine.Graphics::CopyTexture_Region");
			Graphics.ConvertTexture_FullDelegateField = IL2CPP.ResolveICall<Graphics.ConvertTexture_FullDelegate>("UnityEngine.Graphics::ConvertTexture_Full");
			Graphics.ConvertTexture_SliceDelegateField = IL2CPP.ResolveICall<Graphics.ConvertTexture_SliceDelegate>("UnityEngine.Graphics::ConvertTexture_Slice");
			Graphics.Internal_DrawMeshInstancedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstanced");
			Graphics.Internal_DrawProceduralNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralNow");
			Graphics.Internal_DrawProceduralIndexedNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedNow");
			Graphics.Internal_DrawProceduralIndirectNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirectNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectNow");
			Graphics.Internal_DrawProceduralIndexedIndirectNowDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirectNowDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectNow");
			Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirectNowGraphicsBuffer");
			Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer");
			Graphics.Internal_BlitMaterial6DelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMaterial6Delegate>("UnityEngine.Graphics::Internal_BlitMaterial6");
			Graphics.Internal_BlitMultiTap4DelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMultiTap4Delegate>("UnityEngine.Graphics::Internal_BlitMultiTap4");
			Graphics.Internal_BlitMultiTap5DelegateField = IL2CPP.ResolveICall<Graphics.Internal_BlitMultiTap5Delegate>("UnityEngine.Graphics::Internal_BlitMultiTap5");
			Graphics.Blit3DelegateField = IL2CPP.ResolveICall<Graphics.Blit3Delegate>("UnityEngine.Graphics::Blit3");
			Graphics.CreateGPUFenceImplDelegateField = IL2CPP.ResolveICall<Graphics.CreateGPUFenceImplDelegate>("UnityEngine.Graphics::CreateGPUFenceImpl");
			Graphics.WaitOnGPUFenceImplDelegateField = IL2CPP.ResolveICall<Graphics.WaitOnGPUFenceImplDelegate>("UnityEngine.Graphics::WaitOnGPUFenceImpl");
			Graphics.ExecuteCommandBufferDelegateField = IL2CPP.ResolveICall<Graphics.ExecuteCommandBufferDelegate>("UnityEngine.Graphics::ExecuteCommandBuffer");
			Graphics.ExecuteCommandBufferAsyncDelegateField = IL2CPP.ResolveICall<Graphics.ExecuteCommandBufferAsyncDelegate>("UnityEngine.Graphics::ExecuteCommandBufferAsync");
			Graphics.GetActiveColorBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.GetActiveColorBuffer_InjectedDelegate>("UnityEngine.Graphics::GetActiveColorBuffer_Injected");
			Graphics.GetActiveDepthBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.GetActiveDepthBuffer_InjectedDelegate>("UnityEngine.Graphics::GetActiveDepthBuffer_Injected");
			Graphics.Internal_SetMRTSimple_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetMRTSimple_InjectedDelegate>("UnityEngine.Graphics::Internal_SetMRTSimple_Injected");
			Graphics.Internal_SetMRTFullSetup_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_SetMRTFullSetup_InjectedDelegate>("UnityEngine.Graphics::Internal_SetMRTFullSetup_Injected");
			Graphics.Internal_DrawMeshNow1_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshNow1_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshNow1_Injected");
			Graphics.Internal_DrawMeshNow2_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshNow2_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshNow2_Injected");
			Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedProcedural_Injected");
			Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedIndirect_Injected");
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected");
			Graphics.Internal_DrawProcedural_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProcedural_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProcedural_Injected");
			Graphics.Internal_DrawProceduralIndexed_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexed_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexed_Injected");
			Graphics.Internal_DrawProceduralIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndirect_Injected");
			Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegate>("UnityEngine.Graphics::Internal_DrawProceduralIndexedIndirect_Injected");
			Graphics.Blit4_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Blit4_InjectedDelegate>("UnityEngine.Graphics::Blit4_Injected");
			Graphics.Blit5_InjectedDelegateField = IL2CPP.ResolveICall<Graphics.Blit5_InjectedDelegate>("UnityEngine.Graphics::Blit5_Injected");
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00024A2C File Offset: 0x00022C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487957, XrefRangeEnd = 487961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Internal_GetMaxDrawMeshInstanceCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00024A5C File Offset: 0x00022C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487961, XrefRangeEnd = 487965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetNullRT()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_SetNullRT_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00024A84 File Offset: 0x00022C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487965, XrefRangeEnd = 487970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Private_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00024AF0 File Offset: 0x00022CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487970, XrefRangeEnd = 487974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyTexture_Slice_AllMips(Texture src, int srcElement, Texture dst, int dstElement)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcElement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstElement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Slice_AllMips_Private_Static_Void_Texture_Int32_Texture_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00024B54 File Offset: 0x00022D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487974, XrefRangeEnd = 487978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_DrawTexture(ref Internal_DrawTextureArguments args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawTexture_Internal_Static_Void_byref_Internal_DrawTextureArguments_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00024B90 File Offset: 0x00022D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487978, XrefRangeEnd = 487983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(probeAnchor);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Private_Static_Void_Mesh_Int32_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00024C7C File Offset: 0x00022E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487983, XrefRangeEnd = 487987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setRT;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_BlitMaterial5_Private_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00024CF4 File Offset: 0x00022EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487987, XrefRangeEnd = 487991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit2(Texture source, RenderTexture dest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit2_Private_Static_Void_Texture_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00024D3C File Offset: 0x00022F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487991, XrefRangeEnd = 488000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref colorBuffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00024DA8 File Offset: 0x00022FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488009, RefRangeEnd = 488010, XrefRangeStart = 488000, XrefRangeEnd = 488009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00024E08 File Offset: 0x00023008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488014, RefRangeEnd = 488015, XrefRangeStart = 488010, XrefRangeEnd = 488014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00024E68 File Offset: 0x00023068
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 488022, RefRangeEnd = 488024, XrefRangeStart = 488015, XrefRangeEnd = 488022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyTexture(Texture src, int srcElement, Texture dst, int dstElement)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcElement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstElement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Texture_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00024ECC File Offset: 0x000230CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 488045, RefRangeEnd = 488046, XrefRangeStart = 488024, XrefRangeEnd = 488045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(probeAnchor);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00024FB8 File Offset: 0x000231B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 488053, RefRangeEnd = 488057, XrefRangeStart = 488046, XrefRangeEnd = 488053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit(Texture source, RenderTexture dest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00025000 File Offset: 0x00023200
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 488064, RefRangeEnd = 488069, XrefRangeStart = 488057, XrefRangeEnd = 488064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit(Texture source, RenderTexture dest, Material mat, int pass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00025068 File Offset: 0x00023268
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 488073, RefRangeEnd = 488077, XrefRangeStart = 488069, XrefRangeEnd = 488073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit(Texture source, RenderTexture dest, Material mat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000250C4 File Offset: 0x000232C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488077, XrefRangeEnd = 488081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00025128 File Offset: 0x00023328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488081, XrefRangeEnd = 488085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &depth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_SetRTSimple_Injected_Private_Static_Void_byref_RenderBuffer_byref_RenderBuffer_Int32_CubemapFace_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00025194 File Offset: 0x00023394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488085, XrefRangeEnd = 488089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submeshIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matrix;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref castShadows;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref receiveShadows;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(probeAnchor);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProbeUsage;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphics.NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Static_Void_Mesh_Int32_byref_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00004F1D File Offset: 0x0000311D
		public Graphics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00025280 File Offset: 0x00023480
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x00004F26 File Offset: 0x00003126
		public unsafe static int kMaxDrawMeshInstanceCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Graphics.NativeFieldInfoPtr_kMaxDrawMeshInstanceCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphics.NativeFieldInfoPtr_kMaxDrawMeshInstanceCount, (void*)(&value));
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00004F34 File Offset: 0x00003134
		public static ColorGamut GetActiveColorGamut()
		{
			return Graphics.GetActiveColorGamutDelegateField();
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0002529C File Offset: 0x0002349C
		public static ColorGamut activeColorGamut
		{
			get
			{
				return Graphics.GetActiveColorGamut();
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00004F40 File Offset: 0x00003140
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00004F4C File Offset: 0x0000314C
		public static UnityEngine.Rendering.GraphicsTier activeTier
		{
			get
			{
				return Graphics.get_activeTierDelegateField();
			}
			set
			{
				Graphics.set_activeTierDelegateField(value);
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00004F59 File Offset: 0x00003159
		public static bool GetPreserveFramebufferAlpha()
		{
			return Graphics.GetPreserveFramebufferAlphaDelegateField();
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x000252B4 File Offset: 0x000234B4
		public static bool preserveFramebufferAlpha
		{
			get
			{
				return Graphics.GetPreserveFramebufferAlpha();
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00004F65 File Offset: 0x00003165
		public static UnityEngine.Rendering.OpenGLESVersion GetMinOpenGLESVersion()
		{
			return Graphics.GetMinOpenGLESVersionDelegateField();
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x000252CC File Offset: 0x000234CC
		public static UnityEngine.Rendering.OpenGLESVersion minOpenGLESVersion
		{
			get
			{
				return Graphics.GetMinOpenGLESVersion();
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000252E4 File Offset: 0x000234E4
		public static RenderBuffer GetActiveColorBuffer()
		{
			RenderBuffer renderBuffer;
			Graphics.GetActiveColorBuffer_Injected(out renderBuffer);
			return renderBuffer;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000252FC File Offset: 0x000234FC
		public static RenderBuffer GetActiveDepthBuffer()
		{
			RenderBuffer renderBuffer;
			Graphics.GetActiveDepthBuffer_Injected(out renderBuffer);
			return renderBuffer;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00004F71 File Offset: 0x00003171
		public static void Internal_SetMRTSimple(Il2CppStructArray<RenderBuffer> color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
			Graphics.Internal_SetMRTSimple_Injected(color, ref depth, mip, face, depthSlice);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00025314 File Offset: 0x00023514
		public static void Internal_SetMRTFullSetup(Il2CppStructArray<RenderBuffer> color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice, Il2CppStructArray<UnityEngine.Rendering.RenderBufferLoadAction> colorLA, Il2CppStructArray<UnityEngine.Rendering.RenderBufferStoreAction> colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA)
		{
			Graphics.Internal_SetMRTFullSetup_Injected(color, ref depth, mip, face, depthSlice, colorLA, colorSA, depthLA, depthSA);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00004F7F File Offset: 0x0000317F
		public static void Internal_SetRandomWriteTargetRT(int index, RenderTexture uav)
		{
			Graphics.Internal_SetRandomWriteTargetRTDelegateField(index, IL2CPP.Il2CppObjectBaseToPtr(uav));
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00004F92 File Offset: 0x00003192
		public static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue)
		{
			Graphics.Internal_SetRandomWriteTargetBufferDelegateField(index, IL2CPP.Il2CppObjectBaseToPtr(uav), preserveCounterValue);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00004FA6 File Offset: 0x000031A6
		public static void Internal_SetRandomWriteTargetGraphicsBuffer(int index, GraphicsBuffer uav, bool preserveCounterValue)
		{
			Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegateField(index, IL2CPP.Il2CppObjectBaseToPtr(uav), preserveCounterValue);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00004FBA File Offset: 0x000031BA
		public static void ClearRandomWriteTargets()
		{
			Graphics.ClearRandomWriteTargetsDelegateField();
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00004FC6 File Offset: 0x000031C6
		public static void CopyTexture_Full(Texture src, Texture dst)
		{
			Graphics.CopyTexture_FullDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst));
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00004FDE File Offset: 0x000031DE
		public static void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip)
		{
			Graphics.CopyTexture_SliceDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), srcElement, srcMip, IL2CPP.Il2CppObjectBaseToPtr(dst), dstElement, dstMip);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00025338 File Offset: 0x00023538
		public static void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
		{
			Graphics.CopyTexture_RegionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, IL2CPP.Il2CppObjectBaseToPtr(dst), dstElement, dstMip, dstX, dstY);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00004FFC File Offset: 0x000031FC
		public static bool ConvertTexture_Full(Texture src, Texture dst)
		{
			return Graphics.ConvertTexture_FullDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst));
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00005014 File Offset: 0x00003214
		public static bool ConvertTexture_Slice(Texture src, int srcElement, Texture dst, int dstElement)
		{
			return Graphics.ConvertTexture_SliceDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), srcElement, IL2CPP.Il2CppObjectBaseToPtr(dst), dstElement);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0000502E File Offset: 0x0000322E
		public static void Internal_DrawMeshNow1(Mesh mesh, int subsetIndex, Vector3 position, Quaternion rotation)
		{
			Graphics.Internal_DrawMeshNow1_Injected(mesh, subsetIndex, ref position, ref rotation);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0000503B File Offset: 0x0000323B
		public static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix)
		{
			Graphics.Internal_DrawMeshNow2_Injected(mesh, subsetIndex, ref matrix);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00025370 File Offset: 0x00023570
		public static void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), IL2CPP.Il2CppObjectBaseToPtr(matrices), count, IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer, IL2CPP.Il2CppObjectBaseToPtr(camera), lightProbeUsage, IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume));
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000253BC File Offset: 0x000235BC
		public static void Internal_DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, Bounds bounds, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedProcedural_Injected(mesh, submeshIndex, material, ref bounds, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000253E4 File Offset: 0x000235E4
		public static void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedIndirect_Injected(mesh, submeshIndex, material, ref bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00025410 File Offset: 0x00023610
		public static void Internal_DrawMeshInstancedIndirectGraphicsBuffer(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(mesh, submeshIndex, material, ref bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00005046 File Offset: 0x00003246
		public static void Internal_DrawProceduralNow(MeshTopology topology, int vertexCount, int instanceCount)
		{
			Graphics.Internal_DrawProceduralNowDelegateField(topology, vertexCount, instanceCount);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00005055 File Offset: 0x00003255
		public static void Internal_DrawProceduralIndexedNow(MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount)
		{
			Graphics.Internal_DrawProceduralIndexedNowDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), indexCount, instanceCount);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0000506A File Offset: 0x0000326A
		public static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndirectNowDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0000507E File Offset: 0x0000327E
		public static void Internal_DrawProceduralIndexedIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndexedIndirectNowDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00005098 File Offset: 0x00003298
		public static void Internal_DrawProceduralIndirectNowGraphicsBuffer(MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000050AC File Offset: 0x000032AC
		public static void Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, int argsOffset)
		{
			Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegateField(topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0002543C File Offset: 0x0002363C
		public static void Internal_DrawProcedural(Material material, Bounds bounds, MeshTopology topology, int vertexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProcedural_Injected(material, ref bounds, topology, vertexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00025460 File Offset: 0x00023660
		public static void Internal_DrawProceduralIndexed(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexed_Injected(material, ref bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00025488 File Offset: 0x00023688
		public static void Internal_DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndirect_Injected(material, ref bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000254AC File Offset: 0x000236AC
		public static void Internal_DrawProceduralIndexedIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexedIndirect_Injected(material, ref bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000050C6 File Offset: 0x000032C6
		public static void Internal_BlitMaterial6(Texture source, RenderTexture dest, Material mat, int pass, bool setRT, int destDepthSlice)
		{
			Graphics.Internal_BlitMaterial6DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), IL2CPP.Il2CppObjectBaseToPtr(mat), pass, setRT, destDepthSlice);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000050E9 File Offset: 0x000032E9
		public static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Il2CppStructArray<Vector2> offsets)
		{
			Graphics.Internal_BlitMultiTap4DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), IL2CPP.Il2CppObjectBaseToPtr(mat), IL2CPP.Il2CppObjectBaseToPtr(offsets));
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0000510D File Offset: 0x0000330D
		public static void Internal_BlitMultiTap5(Texture source, RenderTexture dest, Material mat, Il2CppStructArray<Vector2> offsets, int destDepthSlice)
		{
			Graphics.Internal_BlitMultiTap5DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), IL2CPP.Il2CppObjectBaseToPtr(mat), IL2CPP.Il2CppObjectBaseToPtr(offsets), destDepthSlice);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00005133 File Offset: 0x00003333
		public static void Blit3(Texture source, RenderTexture dest, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit3DelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0000514D File Offset: 0x0000334D
		public static void Blit4(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
		{
			Graphics.Blit4_Injected(source, dest, ref scale, ref offset);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0000515A File Offset: 0x0000335A
		public static void Blit5(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit5_Injected(source, dest, ref scale, ref offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0000516B File Offset: 0x0000336B
		public static IntPtr CreateGPUFenceImpl(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage)
		{
			return Graphics.CreateGPUFenceImplDelegateField(fenceType, stage);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00005179 File Offset: 0x00003379
		public static void WaitOnGPUFenceImpl(IntPtr fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage)
		{
			Graphics.WaitOnGPUFenceImplDelegateField(fencePtr, stage);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00005187 File Offset: 0x00003387
		public static void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer buffer)
		{
			Graphics.ExecuteCommandBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00005199 File Offset: 0x00003399
		public static void ExecuteCommandBufferAsync(UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			Graphics.ExecuteCommandBufferAsyncDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buffer), queueType);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000051AC File Offset: 0x000033AC
		public static void CheckLoadActionValid(UnityEngine.Rendering.RenderBufferLoadAction load, string bufferType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x000051B9 File Offset: 0x000033B9
		public static void CheckStoreActionValid(UnityEngine.Rendering.RenderBufferStoreAction store, string bufferType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x000254D4 File Offset: 0x000236D4
		public static void SetRenderTargetImpl(Il2CppStructArray<RenderBuffer> colorBuffers, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
			Graphics.Internal_SetMRTSimple(colorBuffers, depthBuffer, mipLevel, face, depthSlice);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x000051C6 File Offset: 0x000033C6
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
			Graphics.SetRenderTargetImpl(colorBuffer, depthBuffer, mipLevel, face, depthSlice);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000051D5 File Offset: 0x000033D5
		public static void SetRenderTarget(Il2CppStructArray<RenderBuffer> colorBuffers, RenderBuffer depthBuffer)
		{
			Graphics.SetRenderTargetImpl(colorBuffers, depthBuffer, 0, CubemapFace.Unknown, 0);
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x000254F0 File Offset: 0x000236F0
		public static RenderBuffer activeColorBuffer
		{
			get
			{
				return Graphics.GetActiveColorBuffer();
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00025508 File Offset: 0x00023708
		public static RenderBuffer activeDepthBuffer
		{
			get
			{
				return Graphics.GetActiveDepthBuffer();
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00025520 File Offset: 0x00023720
		public static void SetRandomWriteTarget(int index, RenderTexture uav)
		{
			bool flag = index < 0 || index >= SystemInfo.supportedRandomWriteTargetCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("must be non-negative less than {0}.", SystemInfo.supportedRandomWriteTargetCount));
			}
			Graphics.Internal_SetRandomWriteTargetRT(index, uav);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0002556C File Offset: 0x0002376C
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue)
		{
			bool flag = uav == null;
			if (flag)
			{
				throw new ArgumentNullException("uav");
			}
			bool flag2 = uav.m_Ptr == IntPtr.Zero;
			if (flag2)
			{
				throw new ObjectDisposedException("uav");
			}
			bool flag3 = index < 0 || index >= SystemInfo.supportedRandomWriteTargetCount;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("must be non-negative less than {0}.", SystemInfo.supportedRandomWriteTargetCount));
			}
			Graphics.Internal_SetRandomWriteTargetBuffer(index, uav, preserveCounterValue);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000051E3 File Offset: 0x000033E3
		public static void SetRandomWriteTarget(int index, GraphicsBuffer uav, bool preserveCounterValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000051F0 File Offset: 0x000033F0
		public static void CopyTexture(Texture src, Texture dst)
		{
			Graphics.CopyTexture_Full(src, dst);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x000051FB File Offset: 0x000033FB
		public static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip)
		{
			Graphics.CopyTexture_Slice(src, srcElement, srcMip, dst, dstElement, dstMip);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x000255EC File Offset: 0x000237EC
		public static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
		{
			Graphics.CopyTexture_Region(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00025614 File Offset: 0x00023814
		public static bool ConvertTexture(Texture src, Texture dst)
		{
			return Graphics.ConvertTexture_Full(src, dst);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00025630 File Offset: 0x00023830
		public static bool ConvertTexture(Texture src, int srcElement, Texture dst, int dstElement)
		{
			return Graphics.ConvertTexture_Slice(src, srcElement, dst, dstElement);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0002564C File Offset: 0x0002384C
		public static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass)
		{
			Internal_DrawTextureArguments internal_DrawTextureArguments = null;
			internal_DrawTextureArguments.screenRect = screenRect;
			internal_DrawTextureArguments.sourceRect = sourceRect;
			internal_DrawTextureArguments.leftBorder = leftBorder;
			internal_DrawTextureArguments.rightBorder = rightBorder;
			internal_DrawTextureArguments.topBorder = topBorder;
			internal_DrawTextureArguments.bottomBorder = bottomBorder;
			internal_DrawTextureArguments.color = color;
			internal_DrawTextureArguments.leftBorderColor = Color.black;
			internal_DrawTextureArguments.topBorderColor = Color.black;
			internal_DrawTextureArguments.rightBorderColor = Color.black;
			internal_DrawTextureArguments.bottomBorderColor = Color.black;
			internal_DrawTextureArguments.pass = pass;
			internal_DrawTextureArguments.texture = texture;
			internal_DrawTextureArguments.smoothCorners = true;
			internal_DrawTextureArguments.mat = mat;
			Graphics.Internal_DrawTexture(ref internal_DrawTextureArguments);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x000256F8 File Offset: 0x000238F8
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass)
		{
			Graphics.DrawTextureImpl(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0002571C File Offset: 0x0002391C
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass)
		{
			Color32 color = new Color32(128, 128, 128, 128);
			Graphics.DrawTextureImpl(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00025760 File Offset: 0x00023960
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass)
		{
			Graphics.DrawTexture(screenRect, texture, new Rect(0f, 0f, 1f, 1f), leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0000520C File Offset: 0x0000340C
		public static void DrawTexture(Rect screenRect, Texture texture, Material mat, int pass)
		{
			Graphics.DrawTexture(screenRect, texture, 0, 0, 0, 0, mat, pass);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0002579C File Offset: 0x0002399C
		public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation, int materialIndex)
		{
			bool flag = mesh == null;
			if (flag)
			{
				throw new ArgumentNullException("mesh");
			}
			Graphics.Internal_DrawMeshNow1(mesh, materialIndex, position, rotation);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000257CC File Offset: 0x000239CC
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex)
		{
			bool flag = mesh == null;
			if (flag)
			{
				throw new ArgumentNullException("mesh");
			}
			Graphics.Internal_DrawMeshNow2(mesh, materialIndex, matrix);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0000521D File Offset: 0x0000341D
		public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Graphics.DrawMeshNow(mesh, position, rotation, -1);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0000522A File Offset: 0x0000342A
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix)
		{
			Graphics.DrawMeshNow(mesh, matrix, -1);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x000257FC File Offset: 0x000239FC
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, receiveShadows, null, useLightProbes ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off, null);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0002583C File Offset: 0x00023A3C
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off, null);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00025878 File Offset: 0x00023A78
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows, bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, receiveShadows, null, useLightProbes ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off, null);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000258AC File Offset: 0x00023AAC
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
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
			bool flag5 = !material.enableInstancing;
			if (flag5)
			{
				throw new InvalidOperationException("Material needs to enable instancing for use with DrawMeshInstanced.");
			}
			bool flag6 = matrices == null;
			if (flag6)
			{
				throw new ArgumentNullException("matrices");
			}
			bool flag7 = count < 0 || count > Mathf.Min(Graphics.kMaxDrawMeshInstanceCount, matrices.Length);
			if (flag7)
			{
				throw new ArgumentOutOfRangeException("count", String.Format("Count must be in the range of 0 to {0}.", Mathf.Min(Graphics.kMaxDrawMeshInstanceCount, matrices.Length)));
			}
			bool flag8 = lightProbeUsage == UnityEngine.Rendering.LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null;
			if (flag8)
			{
				throw new ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
			}
			bool flag9 = count > 0;
			if (flag9)
			{
				Graphics.Internal_DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000259EC File Offset: 0x00023BEC
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			bool flag = matrices == null;
			if (flag)
			{
				throw new ArgumentNullException("matrices");
			}
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(matrices), matrices.Count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00025A30 File Offset: 0x00023C30
		public static void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, Bounds bounds, int count, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer, [Optional] Camera camera, [Optional] UnityEngine.Rendering.LightProbeUsage lightProbeUsage, [Optional] LightProbeProxyVolume lightProbeProxyVolume)
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
			bool flag5 = count <= 0;
			if (flag5)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			bool flag6 = lightProbeUsage == UnityEngine.Rendering.LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null;
			if (flag6)
			{
				throw new ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
			}
			bool flag7 = count > 0;
			if (flag7)
			{
				Graphics.Internal_DrawMeshInstancedProcedural(mesh, submeshIndex, material, bounds, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00025B0C File Offset: 0x00023D0C
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
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
			bool flag6 = lightProbeUsage == UnityEngine.Rendering.LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null;
			if (flag6)
			{
				throw new ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
			}
			Graphics.Internal_DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00025BDC File Offset: 0x00023DDC
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
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
			bool flag6 = lightProbeUsage == UnityEngine.Rendering.LightProbeUsage.UseProxyVolume && lightProbeProxyVolume == null;
			if (flag6)
			{
				throw new ArgumentException("Argument lightProbeProxyVolume must not be null if lightProbeUsage is set to UseProxyVolume.", "lightProbeProxyVolume");
			}
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, lightProbeProxyVolume);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00005236 File Offset: 0x00003436
		public static void DrawProceduralNow(MeshTopology topology, int vertexCount, [Optional] int instanceCount)
		{
			Graphics.Internal_DrawProceduralNow(topology, vertexCount, instanceCount);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00025CAC File Offset: 0x00023EAC
		public static void DrawProceduralNow(MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, [Optional] int instanceCount)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			Graphics.Internal_DrawProceduralIndexedNow(topology, indexBuffer, indexCount, instanceCount);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00025CD8 File Offset: 0x00023ED8
		public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = bufferWithArgs == null;
			if (flag)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndirectNow(topology, bufferWithArgs, argsOffset);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00025D04 File Offset: 0x00023F04
		public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndexedIndirectNow(topology, indexBuffer, bufferWithArgs, argsOffset);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00025D44 File Offset: 0x00023F44
		public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = bufferWithArgs == null;
			if (flag)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndirectNowGraphicsBuffer(topology, bufferWithArgs, argsOffset);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00025D70 File Offset: 0x00023F70
		public static void DrawProceduralIndirectNow(MeshTopology topology, GraphicsBuffer indexBuffer, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBuffer(topology, indexBuffer, bufferWithArgs, argsOffset);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00025DB0 File Offset: 0x00023FB0
		public static void DrawProcedural(Material material, Bounds bounds, MeshTopology topology, int vertexCount, [Optional] int instanceCount, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			Graphics.Internal_DrawProcedural(material, bounds, topology, vertexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00025DD4 File Offset: 0x00023FD4
		public static void DrawProcedural(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, [Optional] int instanceCount, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			Graphics.Internal_DrawProceduralIndexed(material, bounds, topology, indexBuffer, indexCount, instanceCount, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00025E10 File Offset: 0x00024010
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = bufferWithArgs == null;
			if (flag)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndirect(material, bounds, topology, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00025E48 File Offset: 0x00024048
		public static void DrawProceduralIndirect(Material material, Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] Camera camera, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer)
		{
			bool flag = indexBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("indexBuffer");
			}
			bool flag2 = bufferWithArgs == null;
			if (flag2)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawProceduralIndexedIndirect(material, bounds, topology, indexBuffer, bufferWithArgs, argsOffset, camera, properties, castShadows, receiveShadows, layer);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00005242 File Offset: 0x00003442
		public static void Blit(Texture source, RenderTexture dest, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit3(source, dest, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0000524F File Offset: 0x0000344F
		public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset)
		{
			Graphics.Blit4(source, dest, scale, offset);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0000525C File Offset: 0x0000345C
		public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit5(source, dest, scale, offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0000526D File Offset: 0x0000346D
		public static void Blit(Texture source, RenderTexture dest, Material mat, int pass, int destDepthSlice)
		{
			Graphics.Internal_BlitMaterial6(source, dest, mat, pass, true, destDepthSlice);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000527D File Offset: 0x0000347D
		public static void Blit(Texture source, Material mat, int pass)
		{
			Graphics.Internal_BlitMaterial5(source, null, mat, pass, false);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0000528B File Offset: 0x0000348B
		public static void Blit(Texture source, Material mat, int pass, int destDepthSlice)
		{
			Graphics.Internal_BlitMaterial6(source, null, mat, pass, false, destDepthSlice);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0000529A File Offset: 0x0000349A
		public static void Blit(Texture source, Material mat)
		{
			Graphics.Blit(source, mat, -1);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00025E98 File Offset: 0x00024098
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Il2CppStructArray<Vector2> offsets)
		{
			bool flag = offsets.Length == 0;
			if (flag)
			{
				throw new ArgumentException("empty offsets list passed.", "offsets");
			}
			Graphics.Internal_BlitMultiTap4(source, dest, mat, offsets);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x000052A6 File Offset: 0x000034A6
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, params Vector2[] offsets)
		{
			Graphics.BlitMultiTap(source, dest, mat, new Il2CppStructArray<Vector2>(offsets));
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00025ED0 File Offset: 0x000240D0
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, int destDepthSlice, Il2CppStructArray<Vector2> offsets)
		{
			bool flag = offsets.Length == 0;
			if (flag)
			{
				throw new ArgumentException("empty offsets list passed.", "offsets");
			}
			Graphics.Internal_BlitMultiTap5(source, dest, mat, offsets, destDepthSlice);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000052B6 File Offset: 0x000034B6
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, int destDepthSlice, params Vector2[] offsets)
		{
			Graphics.BlitMultiTap(source, dest, mat, destDepthSlice, new Il2CppStructArray<Vector2>(offsets));
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00025F08 File Offset: 0x00024108
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, null, 0, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00025F34 File Offset: 0x00024134
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, 0, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00025F64 File Offset: 0x00024164
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00025F94 File Offset: 0x00024194
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00025FC4 File Offset: 0x000241C4
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00025FFC File Offset: 0x000241FC
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00026034 File Offset: 0x00024234
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00026064 File Offset: 0x00024264
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00026098 File Offset: 0x00024298
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor)
		{
			Graphics.DrawMesh(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x000260CC File Offset: 0x000242CC
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, 0, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000260F0 File Offset: 0x000242F0
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, null, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00026114 File Offset: 0x00024314
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, UnityEngine.Rendering.ShadowCastingMode.On, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00026138 File Offset: 0x00024338
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00026164 File Offset: 0x00024364
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00026190 File Offset: 0x00024390
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, true, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x000261B4 File Offset: 0x000243B4
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000261DC File Offset: 0x000243DC
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00026204 File Offset: 0x00024404
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off, null);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00026234 File Offset: 0x00024434
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.Internal_DrawMesh(mesh, submeshIndex, matrix, material, layer, camera, properties, castShadows, receiveShadows, probeAnchor, lightProbeUsage, null);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0002625C File Offset: 0x0002445C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, matrices.Length, null, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00026284 File Offset: 0x00024484
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, null, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x000262A8 File Offset: 0x000244A8
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x000262CC File Offset: 0x000244CC
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x000262F0 File Offset: 0x000244F0
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00026314 File Offset: 0x00024514
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0002633C File Offset: 0x0002453C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00026364 File Offset: 0x00024564
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Il2CppStructArray<Matrix4x4> matrices, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0002638C File Offset: 0x0002458C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, null, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x000263AC File Offset: 0x000245AC
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, UnityEngine.Rendering.ShadowCastingMode.On, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x000263CC File Offset: 0x000245CC
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, true, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x000263F0 File Offset: 0x000245F0
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, 0, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00026414 File Offset: 0x00024614
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, null, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00026438 File Offset: 0x00024638
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera, UnityEngine.Rendering.LightProbeUsage.BlendProbes, null);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0002645C File Offset: 0x0002465C
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00026484 File Offset: 0x00024684
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer, [Optional] Camera camera, [Optional] UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000264B0 File Offset: 0x000246B0
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, GraphicsBuffer bufferWithArgs, [Optional] int argsOffset, [Optional] MaterialPropertyBlock properties, [Optional] UnityEngine.Rendering.ShadowCastingMode castShadows, [Optional] bool receiveShadows, [Optional] int layer, [Optional] Camera camera, [Optional] UnityEngine.Rendering.LightProbeUsage lightProbeUsage)
		{
			Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera, lightProbeUsage, null);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000264DC File Offset: 0x000246DC
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, -1);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00026500 File Offset: 0x00024700
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, null, -1);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00026524 File Offset: 0x00024724
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat, -1);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00026548 File Offset: 0x00024748
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, null, -1);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x000052C8 File Offset: 0x000034C8
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat, -1);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x000052DC File Offset: 0x000034DC
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, null, -1);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x000052EF File Offset: 0x000034EF
		public static void DrawTexture(Rect screenRect, Texture texture, Material mat)
		{
			Graphics.DrawTexture(screenRect, texture, mat, -1);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x000052FC File Offset: 0x000034FC
		public static void DrawTexture(Rect screenRect, Texture texture)
		{
			Graphics.DrawTexture(screenRect, texture, null, -1);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00005309 File Offset: 0x00003509
		public static void SetRenderTarget(RenderTexture rt)
		{
			Graphics.SetRenderTarget(rt, 0, CubemapFace.Unknown, 0);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00005316 File Offset: 0x00003516
		public static void SetRenderTarget(RenderTexture rt, int mipLevel)
		{
			Graphics.SetRenderTarget(rt, mipLevel, CubemapFace.Unknown, 0);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00005323 File Offset: 0x00003523
		public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face)
		{
			Graphics.SetRenderTarget(rt, mipLevel, face, 0);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00005330 File Offset: 0x00003530
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
		{
			Graphics.SetRenderTarget(colorBuffer, depthBuffer, 0, CubemapFace.Unknown, 0);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0000533E File Offset: 0x0000353E
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel)
		{
			Graphics.SetRenderTarget(colorBuffer, depthBuffer, mipLevel, CubemapFace.Unknown, 0);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0000534C File Offset: 0x0000354C
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face)
		{
			Graphics.SetRenderTarget(colorBuffer, depthBuffer, mipLevel, face, 0);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0000535A File Offset: 0x0000355A
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav)
		{
			Graphics.SetRandomWriteTarget(index, uav, false);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00005366 File Offset: 0x00003566
		public static void SetRandomWriteTarget(int index, GraphicsBuffer uav)
		{
			Graphics.SetRandomWriteTarget(index, uav, false);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00005372 File Offset: 0x00003572
		public static void GetActiveColorBuffer_Injected(out RenderBuffer ret)
		{
			Graphics.GetActiveColorBuffer_InjectedDelegateField(out ret);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0000537F File Offset: 0x0000357F
		public static void GetActiveDepthBuffer_Injected(out RenderBuffer ret)
		{
			Graphics.GetActiveDepthBuffer_InjectedDelegateField(out ret);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0000538C File Offset: 0x0000358C
		public static void Internal_SetMRTSimple_Injected(Il2CppStructArray<RenderBuffer> color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
			Graphics.Internal_SetMRTSimple_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(color), ref depth, mip, face, depthSlice);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00026568 File Offset: 0x00024768
		public static void Internal_SetMRTFullSetup_Injected(Il2CppStructArray<RenderBuffer> color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice, Il2CppStructArray<UnityEngine.Rendering.RenderBufferLoadAction> colorLA, Il2CppStructArray<UnityEngine.Rendering.RenderBufferStoreAction> colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA)
		{
			Graphics.Internal_SetMRTFullSetup_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(color), ref depth, mip, face, depthSlice, IL2CPP.Il2CppObjectBaseToPtr(colorLA), IL2CPP.Il2CppObjectBaseToPtr(colorSA), depthLA, depthSA);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x000053A3 File Offset: 0x000035A3
		public static void Internal_DrawMeshNow1_Injected(Mesh mesh, int subsetIndex, ref Vector3 position, ref Quaternion rotation)
		{
			Graphics.Internal_DrawMeshNow1_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), subsetIndex, ref position, ref rotation);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x000053B8 File Offset: 0x000035B8
		public static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix)
		{
			Graphics.Internal_DrawMeshNow2_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), subsetIndex, ref matrix);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0002659C File Offset: 0x0002479C
		public static void Internal_DrawMeshInstancedProcedural_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, int count, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, count, IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer, IL2CPP.Il2CppObjectBaseToPtr(camera), lightProbeUsage, IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume));
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000265E0 File Offset: 0x000247E0
		public static void Internal_DrawMeshInstancedIndirect_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer, IL2CPP.Il2CppObjectBaseToPtr(camera), lightProbeUsage, IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume));
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0002662C File Offset: 0x0002482C
		public static void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
			Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), submeshIndex, IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer, IL2CPP.Il2CppObjectBaseToPtr(camera), lightProbeUsage, IL2CPP.Il2CppObjectBaseToPtr(lightProbeProxyVolume));
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00026678 File Offset: 0x00024878
		public static void Internal_DrawProcedural_Injected(Material material, ref Bounds bounds, MeshTopology topology, int vertexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProcedural_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, vertexCount, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x000266B0 File Offset: 0x000248B0
		public static void Internal_DrawProceduralIndexed_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, int indexCount, int instanceCount, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexed_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), indexCount, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000266F0 File Offset: 0x000248F0
		public static void Internal_DrawProceduralIndirect_Injected(Material material, ref Bounds bounds, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndirect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0002672C File Offset: 0x0002492C
		public static void Internal_DrawProceduralIndexedIndirect_Injected(Material material, ref Bounds bounds, MeshTopology topology, GraphicsBuffer indexBuffer, ComputeBuffer bufferWithArgs, int argsOffset, Camera camera, MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(material), ref bounds, topology, IL2CPP.Il2CppObjectBaseToPtr(indexBuffer), IL2CPP.Il2CppObjectBaseToPtr(bufferWithArgs), argsOffset, IL2CPP.Il2CppObjectBaseToPtr(camera), IL2CPP.Il2CppObjectBaseToPtr(properties), castShadows, receiveShadows, layer);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x000053CC File Offset: 0x000035CC
		public static void Blit4_Injected(Texture source, RenderTexture dest, ref Vector2 scale, ref Vector2 offset)
		{
			Graphics.Blit4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), ref scale, ref offset);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x000053E6 File Offset: 0x000035E6
		public static void Blit5_Injected(Texture source, RenderTexture dest, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
			Graphics.Blit5_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(dest), ref scale, ref offset, sourceDepthSlice, destDepthSlice);
		}

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeFieldInfoPtr_kMaxDrawMeshInstanceCount;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetMaxDrawMeshInstanceCount_Private_Static_Int32_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetNullRT_Private_Static_Void_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetRTSimple_Private_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_CopyTexture_Slice_AllMips_Private_Static_Void_Texture_Int32_Texture_Int32_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawTexture_Internal_Static_Void_byref_Internal_DrawTextureArguments_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawMesh_Private_Static_Void_Mesh_Int32_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_Internal_BlitMaterial5_Private_Static_Void_Texture_RenderTexture_Material_Int32_Boolean_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_Blit2_Private_Static_Void_Texture_RenderTexture_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderBuffer_RenderBuffer_Int32_CubemapFace_Int32_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTargetImpl_Internal_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTarget_Public_Static_Void_RenderTexture_Int32_CubemapFace_Int32_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_CopyTexture_Public_Static_Void_Texture_Int32_Texture_Int32_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_Camera_Int32_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_Int32_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Public_Static_Void_Texture_RenderTexture_Material_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_DrawMesh_Public_Static_Void_Mesh_Matrix4x4_Material_Int32_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetRTSimple_Injected_Private_Static_Void_byref_RenderBuffer_byref_RenderBuffer_Int32_CubemapFace_Int32_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_Internal_DrawMesh_Injected_Private_Static_Void_Mesh_Int32_byref_Matrix4x4_Material_Int32_Camera_MaterialPropertyBlock_ShadowCastingMode_Boolean_Transform_LightProbeUsage_LightProbeProxyVolume_0;

		// Token: 0x04000469 RID: 1129
		private static readonly Graphics.GetActiveColorGamutDelegate GetActiveColorGamutDelegateField;

		// Token: 0x0400046A RID: 1130
		private static readonly Graphics.get_activeTierDelegate get_activeTierDelegateField;

		// Token: 0x0400046B RID: 1131
		private static readonly Graphics.set_activeTierDelegate set_activeTierDelegateField;

		// Token: 0x0400046C RID: 1132
		private static readonly Graphics.GetPreserveFramebufferAlphaDelegate GetPreserveFramebufferAlphaDelegateField;

		// Token: 0x0400046D RID: 1133
		private static readonly Graphics.GetMinOpenGLESVersionDelegate GetMinOpenGLESVersionDelegateField;

		// Token: 0x0400046E RID: 1134
		private static readonly Graphics.Internal_SetRandomWriteTargetRTDelegate Internal_SetRandomWriteTargetRTDelegateField;

		// Token: 0x0400046F RID: 1135
		private static readonly Graphics.Internal_SetRandomWriteTargetBufferDelegate Internal_SetRandomWriteTargetBufferDelegateField;

		// Token: 0x04000470 RID: 1136
		private static readonly Graphics.Internal_SetRandomWriteTargetGraphicsBufferDelegate Internal_SetRandomWriteTargetGraphicsBufferDelegateField;

		// Token: 0x04000471 RID: 1137
		private static readonly Graphics.ClearRandomWriteTargetsDelegate ClearRandomWriteTargetsDelegateField;

		// Token: 0x04000472 RID: 1138
		private static readonly Graphics.CopyTexture_FullDelegate CopyTexture_FullDelegateField;

		// Token: 0x04000473 RID: 1139
		private static readonly Graphics.CopyTexture_SliceDelegate CopyTexture_SliceDelegateField;

		// Token: 0x04000474 RID: 1140
		private static readonly Graphics.CopyTexture_RegionDelegate CopyTexture_RegionDelegateField;

		// Token: 0x04000475 RID: 1141
		private static readonly Graphics.ConvertTexture_FullDelegate ConvertTexture_FullDelegateField;

		// Token: 0x04000476 RID: 1142
		private static readonly Graphics.ConvertTexture_SliceDelegate ConvertTexture_SliceDelegateField;

		// Token: 0x04000477 RID: 1143
		private static readonly Graphics.Internal_DrawMeshInstancedDelegate Internal_DrawMeshInstancedDelegateField;

		// Token: 0x04000478 RID: 1144
		private static readonly Graphics.Internal_DrawProceduralNowDelegate Internal_DrawProceduralNowDelegateField;

		// Token: 0x04000479 RID: 1145
		private static readonly Graphics.Internal_DrawProceduralIndexedNowDelegate Internal_DrawProceduralIndexedNowDelegateField;

		// Token: 0x0400047A RID: 1146
		private static readonly Graphics.Internal_DrawProceduralIndirectNowDelegate Internal_DrawProceduralIndirectNowDelegateField;

		// Token: 0x0400047B RID: 1147
		private static readonly Graphics.Internal_DrawProceduralIndexedIndirectNowDelegate Internal_DrawProceduralIndexedIndirectNowDelegateField;

		// Token: 0x0400047C RID: 1148
		private static readonly Graphics.Internal_DrawProceduralIndirectNowGraphicsBufferDelegate Internal_DrawProceduralIndirectNowGraphicsBufferDelegateField;

		// Token: 0x0400047D RID: 1149
		private static readonly Graphics.Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegate Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegateField;

		// Token: 0x0400047E RID: 1150
		private static readonly Graphics.Internal_BlitMaterial6Delegate Internal_BlitMaterial6DelegateField;

		// Token: 0x0400047F RID: 1151
		private static readonly Graphics.Internal_BlitMultiTap4Delegate Internal_BlitMultiTap4DelegateField;

		// Token: 0x04000480 RID: 1152
		private static readonly Graphics.Internal_BlitMultiTap5Delegate Internal_BlitMultiTap5DelegateField;

		// Token: 0x04000481 RID: 1153
		private static readonly Graphics.Blit3Delegate Blit3DelegateField;

		// Token: 0x04000482 RID: 1154
		private static readonly Graphics.CreateGPUFenceImplDelegate CreateGPUFenceImplDelegateField;

		// Token: 0x04000483 RID: 1155
		private static readonly Graphics.WaitOnGPUFenceImplDelegate WaitOnGPUFenceImplDelegateField;

		// Token: 0x04000484 RID: 1156
		private static readonly Graphics.ExecuteCommandBufferDelegate ExecuteCommandBufferDelegateField;

		// Token: 0x04000485 RID: 1157
		private static readonly Graphics.ExecuteCommandBufferAsyncDelegate ExecuteCommandBufferAsyncDelegateField;

		// Token: 0x04000486 RID: 1158
		private static readonly Graphics.GetActiveColorBuffer_InjectedDelegate GetActiveColorBuffer_InjectedDelegateField;

		// Token: 0x04000487 RID: 1159
		private static readonly Graphics.GetActiveDepthBuffer_InjectedDelegate GetActiveDepthBuffer_InjectedDelegateField;

		// Token: 0x04000488 RID: 1160
		private static readonly Graphics.Internal_SetMRTSimple_InjectedDelegate Internal_SetMRTSimple_InjectedDelegateField;

		// Token: 0x04000489 RID: 1161
		private static readonly Graphics.Internal_SetMRTFullSetup_InjectedDelegate Internal_SetMRTFullSetup_InjectedDelegateField;

		// Token: 0x0400048A RID: 1162
		private static readonly Graphics.Internal_DrawMeshNow1_InjectedDelegate Internal_DrawMeshNow1_InjectedDelegateField;

		// Token: 0x0400048B RID: 1163
		private static readonly Graphics.Internal_DrawMeshNow2_InjectedDelegate Internal_DrawMeshNow2_InjectedDelegateField;

		// Token: 0x0400048C RID: 1164
		private static readonly Graphics.Internal_DrawMeshInstancedProcedural_InjectedDelegate Internal_DrawMeshInstancedProcedural_InjectedDelegateField;

		// Token: 0x0400048D RID: 1165
		private static readonly Graphics.Internal_DrawMeshInstancedIndirect_InjectedDelegate Internal_DrawMeshInstancedIndirect_InjectedDelegateField;

		// Token: 0x0400048E RID: 1166
		private static readonly Graphics.Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegateField;

		// Token: 0x0400048F RID: 1167
		private static readonly Graphics.Internal_DrawProcedural_InjectedDelegate Internal_DrawProcedural_InjectedDelegateField;

		// Token: 0x04000490 RID: 1168
		private static readonly Graphics.Internal_DrawProceduralIndexed_InjectedDelegate Internal_DrawProceduralIndexed_InjectedDelegateField;

		// Token: 0x04000491 RID: 1169
		private static readonly Graphics.Internal_DrawProceduralIndirect_InjectedDelegate Internal_DrawProceduralIndirect_InjectedDelegateField;

		// Token: 0x04000492 RID: 1170
		private static readonly Graphics.Internal_DrawProceduralIndexedIndirect_InjectedDelegate Internal_DrawProceduralIndexedIndirect_InjectedDelegateField;

		// Token: 0x04000493 RID: 1171
		private static readonly Graphics.Blit4_InjectedDelegate Blit4_InjectedDelegateField;

		// Token: 0x04000494 RID: 1172
		private static readonly Graphics.Blit5_InjectedDelegate Blit5_InjectedDelegateField;

		// Token: 0x02000445 RID: 1093
		// (Invoke) Token: 0x060026C0 RID: 9920
		private delegate ColorGamut GetActiveColorGamutDelegate();

		// Token: 0x02000446 RID: 1094
		// (Invoke) Token: 0x060026C2 RID: 9922
		private delegate UnityEngine.Rendering.GraphicsTier get_activeTierDelegate();

		// Token: 0x02000447 RID: 1095
		// (Invoke) Token: 0x060026C4 RID: 9924
		private delegate void set_activeTierDelegate(UnityEngine.Rendering.GraphicsTier value);

		// Token: 0x02000448 RID: 1096
		// (Invoke) Token: 0x060026C6 RID: 9926
		private delegate bool GetPreserveFramebufferAlphaDelegate();

		// Token: 0x02000449 RID: 1097
		// (Invoke) Token: 0x060026C8 RID: 9928
		private delegate UnityEngine.Rendering.OpenGLESVersion GetMinOpenGLESVersionDelegate();

		// Token: 0x0200044A RID: 1098
		// (Invoke) Token: 0x060026CA RID: 9930
		private delegate void Internal_SetRandomWriteTargetRTDelegate(int index, IntPtr uav);

		// Token: 0x0200044B RID: 1099
		// (Invoke) Token: 0x060026CC RID: 9932
		private delegate void Internal_SetRandomWriteTargetBufferDelegate(int index, IntPtr uav, bool preserveCounterValue);

		// Token: 0x0200044C RID: 1100
		// (Invoke) Token: 0x060026CE RID: 9934
		private delegate void Internal_SetRandomWriteTargetGraphicsBufferDelegate(int index, IntPtr uav, bool preserveCounterValue);

		// Token: 0x0200044D RID: 1101
		// (Invoke) Token: 0x060026D0 RID: 9936
		private delegate void ClearRandomWriteTargetsDelegate();

		// Token: 0x0200044E RID: 1102
		// (Invoke) Token: 0x060026D2 RID: 9938
		private delegate void CopyTexture_FullDelegate(IntPtr src, IntPtr dst);

		// Token: 0x0200044F RID: 1103
		// (Invoke) Token: 0x060026D4 RID: 9940
		private delegate void CopyTexture_SliceDelegate(IntPtr src, int srcElement, int srcMip, IntPtr dst, int dstElement, int dstMip);

		// Token: 0x02000450 RID: 1104
		// (Invoke) Token: 0x060026D6 RID: 9942
		private delegate void CopyTexture_RegionDelegate(IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, IntPtr dst, int dstElement, int dstMip, int dstX, int dstY);

		// Token: 0x02000451 RID: 1105
		// (Invoke) Token: 0x060026D8 RID: 9944
		private delegate bool ConvertTexture_FullDelegate(IntPtr src, IntPtr dst);

		// Token: 0x02000452 RID: 1106
		// (Invoke) Token: 0x060026DA RID: 9946
		private delegate bool ConvertTexture_SliceDelegate(IntPtr src, int srcElement, IntPtr dst, int dstElement);

		// Token: 0x02000453 RID: 1107
		// (Invoke) Token: 0x060026DC RID: 9948
		private delegate void Internal_DrawMeshInstancedDelegate(IntPtr mesh, int submeshIndex, IntPtr material, IntPtr matrices, int count, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume);

		// Token: 0x02000454 RID: 1108
		// (Invoke) Token: 0x060026DE RID: 9950
		private delegate void Internal_DrawProceduralNowDelegate(MeshTopology topology, int vertexCount, int instanceCount);

		// Token: 0x02000455 RID: 1109
		// (Invoke) Token: 0x060026E0 RID: 9952
		private delegate void Internal_DrawProceduralIndexedNowDelegate(MeshTopology topology, IntPtr indexBuffer, int indexCount, int instanceCount);

		// Token: 0x02000456 RID: 1110
		// (Invoke) Token: 0x060026E2 RID: 9954
		private delegate void Internal_DrawProceduralIndirectNowDelegate(MeshTopology topology, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x02000457 RID: 1111
		// (Invoke) Token: 0x060026E4 RID: 9956
		private delegate void Internal_DrawProceduralIndexedIndirectNowDelegate(MeshTopology topology, IntPtr indexBuffer, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x02000458 RID: 1112
		// (Invoke) Token: 0x060026E6 RID: 9958
		private delegate void Internal_DrawProceduralIndirectNowGraphicsBufferDelegate(MeshTopology topology, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x02000459 RID: 1113
		// (Invoke) Token: 0x060026E8 RID: 9960
		private delegate void Internal_DrawProceduralIndexedIndirectNowGraphicsBufferDelegate(MeshTopology topology, IntPtr indexBuffer, IntPtr bufferWithArgs, int argsOffset);

		// Token: 0x0200045A RID: 1114
		// (Invoke) Token: 0x060026EA RID: 9962
		private delegate void Internal_BlitMaterial6Delegate(IntPtr source, IntPtr dest, IntPtr mat, int pass, bool setRT, int destDepthSlice);

		// Token: 0x0200045B RID: 1115
		// (Invoke) Token: 0x060026EC RID: 9964
		private delegate void Internal_BlitMultiTap4Delegate(IntPtr source, IntPtr dest, IntPtr mat, IntPtr offsets);

		// Token: 0x0200045C RID: 1116
		// (Invoke) Token: 0x060026EE RID: 9966
		private delegate void Internal_BlitMultiTap5Delegate(IntPtr source, IntPtr dest, IntPtr mat, IntPtr offsets, int destDepthSlice);

		// Token: 0x0200045D RID: 1117
		// (Invoke) Token: 0x060026F0 RID: 9968
		private delegate void Blit3Delegate(IntPtr source, IntPtr dest, int sourceDepthSlice, int destDepthSlice);

		// Token: 0x0200045E RID: 1118
		// (Invoke) Token: 0x060026F2 RID: 9970
		private delegate IntPtr CreateGPUFenceImplDelegate(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage);

		// Token: 0x0200045F RID: 1119
		// (Invoke) Token: 0x060026F4 RID: 9972
		private delegate void WaitOnGPUFenceImplDelegate(IntPtr fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage);

		// Token: 0x02000460 RID: 1120
		// (Invoke) Token: 0x060026F6 RID: 9974
		private delegate void ExecuteCommandBufferDelegate(IntPtr buffer);

		// Token: 0x02000461 RID: 1121
		// (Invoke) Token: 0x060026F8 RID: 9976
		private delegate void ExecuteCommandBufferAsyncDelegate(IntPtr buffer, UnityEngine.Rendering.ComputeQueueType queueType);

		// Token: 0x02000462 RID: 1122
		// (Invoke) Token: 0x060026FA RID: 9978
		private delegate void GetActiveColorBuffer_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000463 RID: 1123
		// (Invoke) Token: 0x060026FC RID: 9980
		private delegate void GetActiveDepthBuffer_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000464 RID: 1124
		// (Invoke) Token: 0x060026FE RID: 9982
		private delegate void Internal_SetMRTSimple_InjectedDelegate(IntPtr color, IntPtr depth, int mip, CubemapFace face, int depthSlice);

		// Token: 0x02000465 RID: 1125
		// (Invoke) Token: 0x06002700 RID: 9984
		private delegate void Internal_SetMRTFullSetup_InjectedDelegate(IntPtr color, IntPtr depth, int mip, CubemapFace face, int depthSlice, IntPtr colorLA, IntPtr colorSA, UnityEngine.Rendering.RenderBufferLoadAction depthLA, UnityEngine.Rendering.RenderBufferStoreAction depthSA);

		// Token: 0x02000466 RID: 1126
		// (Invoke) Token: 0x06002702 RID: 9986
		private delegate void Internal_DrawMeshNow1_InjectedDelegate(IntPtr mesh, int subsetIndex, IntPtr position, IntPtr rotation);

		// Token: 0x02000467 RID: 1127
		// (Invoke) Token: 0x06002704 RID: 9988
		private delegate void Internal_DrawMeshNow2_InjectedDelegate(IntPtr mesh, int subsetIndex, IntPtr matrix);

		// Token: 0x02000468 RID: 1128
		// (Invoke) Token: 0x06002706 RID: 9990
		private delegate void Internal_DrawMeshInstancedProcedural_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr material, IntPtr bounds, int count, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume);

		// Token: 0x02000469 RID: 1129
		// (Invoke) Token: 0x06002708 RID: 9992
		private delegate void Internal_DrawMeshInstancedIndirect_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr material, IntPtr bounds, IntPtr bufferWithArgs, int argsOffset, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume);

		// Token: 0x0200046A RID: 1130
		// (Invoke) Token: 0x0600270A RID: 9994
		private delegate void Internal_DrawMeshInstancedIndirectGraphicsBuffer_InjectedDelegate(IntPtr mesh, int submeshIndex, IntPtr material, IntPtr bounds, IntPtr bufferWithArgs, int argsOffset, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume);

		// Token: 0x0200046B RID: 1131
		// (Invoke) Token: 0x0600270C RID: 9996
		private delegate void Internal_DrawProcedural_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, int vertexCount, int instanceCount, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x0200046C RID: 1132
		// (Invoke) Token: 0x0600270E RID: 9998
		private delegate void Internal_DrawProceduralIndexed_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr indexBuffer, int indexCount, int instanceCount, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x0200046D RID: 1133
		// (Invoke) Token: 0x06002710 RID: 10000
		private delegate void Internal_DrawProceduralIndirect_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x0200046E RID: 1134
		// (Invoke) Token: 0x06002712 RID: 10002
		private delegate void Internal_DrawProceduralIndexedIndirect_InjectedDelegate(IntPtr material, IntPtr bounds, MeshTopology topology, IntPtr indexBuffer, IntPtr bufferWithArgs, int argsOffset, IntPtr camera, IntPtr properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer);

		// Token: 0x0200046F RID: 1135
		// (Invoke) Token: 0x06002714 RID: 10004
		private delegate void Blit4_InjectedDelegate(IntPtr source, IntPtr dest, IntPtr scale, IntPtr offset);

		// Token: 0x02000470 RID: 1136
		// (Invoke) Token: 0x06002716 RID: 10006
		private delegate void Blit5_InjectedDelegate(IntPtr source, IntPtr dest, IntPtr scale, IntPtr offset, int sourceDepthSlice, int destDepthSlice);
	}
}
