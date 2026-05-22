using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq.Expressions;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000061 RID: 97
	public static class RuntimeUtilities : Object
	{
		// Token: 0x06000522 RID: 1314 RVA: 0x000168B4 File Offset: 0x00014AB4
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeUtilities()
		{
			Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "RuntimeUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr);
			RuntimeUtilities.NativeFieldInfoPtr_m_WhiteTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "m_WhiteTexture");
			RuntimeUtilities.NativeFieldInfoPtr_m_WhiteTexture3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "m_WhiteTexture3D");
			RuntimeUtilities.NativeFieldInfoPtr_m_BlackTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "m_BlackTexture");
			RuntimeUtilities.NativeFieldInfoPtr_m_BlackTexture3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "m_BlackTexture3D");
			RuntimeUtilities.NativeFieldInfoPtr_m_TransparentTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "m_TransparentTexture");
			RuntimeUtilities.NativeFieldInfoPtr_m_TransparentTexture3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "m_TransparentTexture3D");
			RuntimeUtilities.NativeFieldInfoPtr_m_LutStrips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "m_LutStrips");
			RuntimeUtilities.NativeFieldInfoPtr_s_Resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "s_Resources");
			RuntimeUtilities.NativeFieldInfoPtr_s_FullscreenTriangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "s_FullscreenTriangle");
			RuntimeUtilities.NativeFieldInfoPtr_s_CopyStdMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "s_CopyStdMaterial");
			RuntimeUtilities.NativeFieldInfoPtr_s_CopyStdFromDoubleWideMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "s_CopyStdFromDoubleWideMaterial");
			RuntimeUtilities.NativeFieldInfoPtr_s_CopyMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "s_CopyMaterial");
			RuntimeUtilities.NativeFieldInfoPtr_s_CopyFromTexArrayMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "s_CopyFromTexArrayMaterial");
			RuntimeUtilities.NativeFieldInfoPtr_s_CopySheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "s_CopySheet");
			RuntimeUtilities.NativeFieldInfoPtr_s_CopyFromTexArraySheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "s_CopyFromTexArraySheet");
			RuntimeUtilities.NativeFieldInfoPtr_m_AssemblyTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "m_AssemblyTypes");
			RuntimeUtilities.NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663802);
			RuntimeUtilities.NativeMethodInfoPtr_get_whiteTexture3D_Public_Static_get_Texture3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663803);
			RuntimeUtilities.NativeMethodInfoPtr_get_blackTexture_Public_Static_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663804);
			RuntimeUtilities.NativeMethodInfoPtr_get_blackTexture3D_Public_Static_get_Texture3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663805);
			RuntimeUtilities.NativeMethodInfoPtr_get_transparentTexture_Public_Static_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663806);
			RuntimeUtilities.NativeMethodInfoPtr_get_transparentTexture3D_Public_Static_get_Texture3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663807);
			RuntimeUtilities.NativeMethodInfoPtr_GetLutStrip_Public_Static_Texture2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663808);
			RuntimeUtilities.NativeMethodInfoPtr_get_fullscreenTriangle_Public_Static_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663809);
			RuntimeUtilities.NativeMethodInfoPtr_get_copyStdMaterial_Public_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663810);
			RuntimeUtilities.NativeMethodInfoPtr_get_copyStdFromDoubleWideMaterial_Public_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663811);
			RuntimeUtilities.NativeMethodInfoPtr_get_copyMaterial_Public_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663812);
			RuntimeUtilities.NativeMethodInfoPtr_get_copyFromTexArrayMaterial_Public_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663813);
			RuntimeUtilities.NativeMethodInfoPtr_get_copySheet_Public_Static_get_PropertySheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663814);
			RuntimeUtilities.NativeMethodInfoPtr_get_copyFromTexArraySheet_Public_Static_get_PropertySheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663815);
			RuntimeUtilities.NativeMethodInfoPtr_UpdateResources_Internal_Static_Void_PostProcessResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663816);
			RuntimeUtilities.NativeMethodInfoPtr_SetRenderTargetWithLoadStoreAction_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663817);
			RuntimeUtilities.NativeMethodInfoPtr_SetRenderTargetWithLoadStoreAction_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663818);
			RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangle_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Boolean_Nullable_1_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663819);
			RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangle_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_RenderBufferLoadAction_Nullable_1_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663820);
			RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangle_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Boolean_Nullable_1_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663821);
			RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangleFromDoubleWide_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663822);
			RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangleToDoubleWide_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663823);
			RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangleFromTexArray_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663824);
			RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangleToTexArray_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663825);
			RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangle_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Boolean_Nullable_1_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663826);
			RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangle_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Boolean_Nullable_1_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663827);
			RuntimeUtilities.NativeMethodInfoPtr_BuiltinBlit_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663828);
			RuntimeUtilities.NativeMethodInfoPtr_BuiltinBlit_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663829);
			RuntimeUtilities.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663830);
			RuntimeUtilities.NativeMethodInfoPtr_get_scriptableRenderPipelineActive_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663831);
			RuntimeUtilities.NativeMethodInfoPtr_get_supportsDeferredShading_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663832);
			RuntimeUtilities.NativeMethodInfoPtr_get_supportsDepthNormals_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663833);
			RuntimeUtilities.NativeMethodInfoPtr_get_isSinglePassStereoEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663834);
			RuntimeUtilities.NativeMethodInfoPtr_get_isVREnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663835);
			RuntimeUtilities.NativeMethodInfoPtr_get_isAndroidOpenGL_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663836);
			RuntimeUtilities.NativeMethodInfoPtr_get_defaultHDRRenderTextureFormat_Public_Static_get_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663837);
			RuntimeUtilities.NativeMethodInfoPtr_isFloatingPointFormat_Public_Static_Boolean_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663838);
			RuntimeUtilities.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663839);
			RuntimeUtilities.NativeMethodInfoPtr_get_isLinearColorSpace_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663840);
			RuntimeUtilities.NativeMethodInfoPtr_IsResolvedDepthAvailable_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663841);
			RuntimeUtilities.NativeMethodInfoPtr_DestroyProfile_Public_Static_Void_PostProcessProfile_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663842);
			RuntimeUtilities.NativeMethodInfoPtr_DestroyVolume_Public_Static_Void_PostProcessVolume_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663843);
			RuntimeUtilities.NativeMethodInfoPtr_IsPostProcessingActive_Public_Static_Boolean_PostProcessLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663844);
			RuntimeUtilities.NativeMethodInfoPtr_IsTemporalAntialiasingActive_Public_Static_Boolean_PostProcessLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663845);
			RuntimeUtilities.NativeMethodInfoPtr_GetAllSceneObjects_Public_Static_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663846);
			RuntimeUtilities.NativeMethodInfoPtr_CreateIfNull_Public_Static_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663847);
			RuntimeUtilities.NativeMethodInfoPtr_Exp2_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663848);
			RuntimeUtilities.NativeMethodInfoPtr_GetJitteredPerspectiveProjectionMatrix_Public_Static_Matrix4x4_Camera_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663849);
			RuntimeUtilities.NativeMethodInfoPtr_GetJitteredOrthographicProjectionMatrix_Public_Static_Matrix4x4_Camera_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663850);
			RuntimeUtilities.NativeMethodInfoPtr_GenerateJitteredProjectionMatrixFromOriginal_Public_Static_Matrix4x4_PostProcessRenderContext_Matrix4x4_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663851);
			RuntimeUtilities.NativeMethodInfoPtr_GetAllAssemblyTypes_Public_Static_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663852);
			RuntimeUtilities.NativeMethodInfoPtr_GetAllTypesDerivedFrom_Public_Static_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663853);
			RuntimeUtilities.NativeMethodInfoPtr_GetAttribute_Public_Static_T_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663854);
			RuntimeUtilities.NativeMethodInfoPtr_GetMemberAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Expression_1_Func_2_TType_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663855);
			RuntimeUtilities.NativeMethodInfoPtr_GetFieldPath_Public_Static_String_Expression_1_Func_2_TType_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, 100663856);
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00016E70 File Offset: 0x00015070
		public unsafe static Texture2D whiteTexture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 448824, RefRangeEnd = 448825, XrefRangeStart = 448790, XrefRangeEnd = 448824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00016EA4 File Offset: 0x000150A4
		public unsafe static Texture3D whiteTexture3D
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448825, XrefRangeEnd = 448861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_whiteTexture3D_Public_Static_get_Texture3D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00016ED8 File Offset: 0x000150D8
		public unsafe static Texture2D blackTexture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 448895, RefRangeEnd = 448896, XrefRangeStart = 448861, XrefRangeEnd = 448895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_blackTexture_Public_Static_get_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00016F0C File Offset: 0x0001510C
		public unsafe static Texture3D blackTexture3D
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448896, XrefRangeEnd = 448932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_blackTexture3D_Public_Static_get_Texture3D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00016F40 File Offset: 0x00015140
		public unsafe static Texture2D transparentTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448932, XrefRangeEnd = 448966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_transparentTexture_Public_Static_get_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00016F74 File Offset: 0x00015174
		public unsafe static Texture3D transparentTexture3D
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448966, XrefRangeEnd = 449002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_transparentTexture3D_Public_Static_get_Texture3D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr3) : null;
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00016FA8 File Offset: 0x000151A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 449045, RefRangeEnd = 449047, XrefRangeStart = 449002, XrefRangeEnd = 449045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D GetLutStrip(int size)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_GetLutStrip_Public_Static_Texture2D_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00016FE8 File Offset: 0x000151E8
		public unsafe static Mesh fullscreenTriangle
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 449072, RefRangeEnd = 449078, XrefRangeStart = 449047, XrefRangeEnd = 449072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_fullscreenTriangle_Public_Static_get_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0001701C File Offset: 0x0001521C
		public unsafe static Material copyStdMaterial
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 449104, RefRangeEnd = 449106, XrefRangeStart = 449078, XrefRangeEnd = 449104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_copyStdMaterial_Public_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00017050 File Offset: 0x00015250
		public unsafe static Material copyStdFromDoubleWideMaterial
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 449132, RefRangeEnd = 449134, XrefRangeStart = 449106, XrefRangeEnd = 449132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_copyStdFromDoubleWideMaterial_Public_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00017084 File Offset: 0x00015284
		public unsafe static Material copyMaterial
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 449160, RefRangeEnd = 449162, XrefRangeStart = 449134, XrefRangeEnd = 449160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_copyMaterial_Public_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x000170B8 File Offset: 0x000152B8
		public unsafe static Material copyFromTexArrayMaterial
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 449188, RefRangeEnd = 449189, XrefRangeStart = 449162, XrefRangeEnd = 449188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_copyFromTexArrayMaterial_Public_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x000170EC File Offset: 0x000152EC
		public unsafe static PropertySheet copySheet
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 449203, RefRangeEnd = 449204, XrefRangeStart = 449189, XrefRangeEnd = 449203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_copySheet_Public_Static_get_PropertySheet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertySheet>(intPtr3) : null;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00017120 File Offset: 0x00015320
		public unsafe static PropertySheet copyFromTexArraySheet
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 449218, RefRangeEnd = 449220, XrefRangeStart = 449204, XrefRangeEnd = 449218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_copyFromTexArraySheet_Public_Static_get_PropertySheet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertySheet>(intPtr3) : null;
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00017154 File Offset: 0x00015354
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 449238, RefRangeEnd = 449239, XrefRangeStart = 449220, XrefRangeEnd = 449238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateResources(PostProcessResources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resources);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_UpdateResources_Internal_Static_Void_PostProcessResources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0001718C File Offset: 0x0001538C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449239, XrefRangeEnd = 449240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_SetRenderTargetWithLoadStoreAction_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000171EC File Offset: 0x000153EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 449244, RefRangeEnd = 449246, XrefRangeStart = 449240, XrefRangeEnd = 449244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLoadAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStoreAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_SetRenderTargetWithLoadStoreAction_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00017278 File Offset: 0x00015478
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 449268, RefRangeEnd = 449274, XrefRangeStart = 449246, XrefRangeEnd = 449268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = false, Nullable<Rect> viewport = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clear;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(viewport));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangle_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Boolean_Nullable_1_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000172F0 File Offset: 0x000154F0
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 449296, RefRangeEnd = 449334, XrefRangeStart = 449274, XrefRangeEnd = 449296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Nullable<Rect> viewport = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertySheet);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(viewport));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangle_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_RenderBufferLoadAction_Nullable_1_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00017388 File Offset: 0x00015588
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 449338, RefRangeEnd = 449345, XrefRangeStart = 449334, XrefRangeEnd = 449338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, Nullable<Rect> viewport = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertySheet);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clear;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(viewport));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangle_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Boolean_Nullable_1_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00017420 File Offset: 0x00015620
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 449355, RefRangeEnd = 449357, XrefRangeStart = 449345, XrefRangeEnd = 449355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitFullscreenTriangleFromDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangleFromDoubleWide_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000174A0 File Offset: 0x000156A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 449374, RefRangeEnd = 449377, XrefRangeStart = 449357, XrefRangeEnd = 449374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitFullscreenTriangleToDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertySheet);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangleToDoubleWide_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00017520 File Offset: 0x00015720
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 449400, RefRangeEnd = 449402, XrefRangeStart = 449377, XrefRangeEnd = 449400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitFullscreenTriangleFromTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertySheet);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clear;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangleFromTexArray_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000175B0 File Offset: 0x000157B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 449420, RefRangeEnd = 449423, XrefRangeStart = 449402, XrefRangeEnd = 449420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitFullscreenTriangleToTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertySheet);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clear;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangleToTexArray_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00017640 File Offset: 0x00015840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449423, XrefRangeEnd = 449447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Nullable<Rect> viewport = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertySheet);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clear;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(viewport));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangle_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Boolean_Nullable_1_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000176E8 File Offset: 0x000158E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 449466, RefRangeEnd = 449469, XrefRangeStart = 449447, XrefRangeEnd = 449466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, Il2CppStructArray<RenderTargetIdentifier> destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Nullable<Rect> viewport = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinations);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertySheet);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clear;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(viewport));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_BlitFullscreenTriangle_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Boolean_Nullable_1_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00017794 File Offset: 0x00015994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449469, XrefRangeEnd = 449475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_BuiltinBlit_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000177E8 File Offset: 0x000159E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 449486, RefRangeEnd = 449489, XrefRangeStart = 449475, XrefRangeEnd = 449486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_BuiltinBlit_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0001785C File Offset: 0x00015A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449489, XrefRangeEnd = 449495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_CopyTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x000178B0 File Offset: 0x00015AB0
		public unsafe static bool scriptableRenderPipelineActive
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 449513, RefRangeEnd = 449527, XrefRangeStart = 449495, XrefRangeEnd = 449513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_scriptableRenderPipelineActive_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x000178E0 File Offset: 0x00015AE0
		public unsafe static bool supportsDeferredShading
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449527, XrefRangeEnd = 449531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_supportsDeferredShading_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00017910 File Offset: 0x00015B10
		public unsafe static bool supportsDepthNormals
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449531, XrefRangeEnd = 449535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_supportsDepthNormals_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00017940 File Offset: 0x00015B40
		public unsafe static bool isSinglePassStereoEnabled
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 449537, RefRangeEnd = 449541, XrefRangeStart = 449535, XrefRangeEnd = 449537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_isSinglePassStereoEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00017970 File Offset: 0x00015B70
		public unsafe static bool isVREnabled
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 449545, RefRangeEnd = 449547, XrefRangeStart = 449541, XrefRangeEnd = 449545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_isVREnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x000179A0 File Offset: 0x00015BA0
		public unsafe static bool isAndroidOpenGL
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 449549, RefRangeEnd = 449552, XrefRangeStart = 449547, XrefRangeEnd = 449549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_isAndroidOpenGL_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x000179D0 File Offset: 0x00015BD0
		public unsafe static RenderTextureFormat defaultHDRRenderTextureFormat
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_defaultHDRRenderTextureFormat_Public_Static_get_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00017A00 File Offset: 0x00015C00
		[CallerCount(0)]
		public unsafe static bool isFloatingPointFormat(RenderTextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_isFloatingPointFormat_Public_Static_Boolean_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00017A40 File Offset: 0x00015C40
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 449568, RefRangeEnd = 449608, XrefRangeStart = 449552, XrefRangeEnd = 449568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00017A78 File Offset: 0x00015C78
		public unsafe static bool isLinearColorSpace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449608, XrefRangeEnd = 449610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_get_isLinearColorSpace_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00017AA8 File Offset: 0x00015CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449610, XrefRangeEnd = 449614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsResolvedDepthAvailable(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_IsResolvedDepthAvailable_Public_Static_Boolean_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00017AEC File Offset: 0x00015CEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 449629, RefRangeEnd = 449630, XrefRangeStart = 449614, XrefRangeEnd = 449629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyProfile(PostProcessProfile profile, bool destroyEffects)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destroyEffects;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_DestroyProfile_Public_Static_Void_PostProcessProfile_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00017B30 File Offset: 0x00015D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449630, XrefRangeEnd = 449643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destroyProfile;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destroyGameObject;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_DestroyVolume_Public_Static_Void_PostProcessVolume_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00017B84 File Offset: 0x00015D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449643, XrefRangeEnd = 449657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPostProcessingActive(PostProcessLayer layer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_IsPostProcessingActive_Public_Static_Boolean_PostProcessLayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00017BC8 File Offset: 0x00015DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449657, XrefRangeEnd = 449675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTemporalAntialiasingActive(PostProcessLayer layer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_IsTemporalAntialiasingActive_Public_Static_Boolean_PostProcessLayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00017C0C File Offset: 0x00015E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449675, XrefRangeEnd = 449677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> GetAllSceneObjects<T>() where T : Component
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.MethodInfoStoreGeneric_GetAllSceneObjects_Public_Static_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00017C40 File Offset: 0x00015E40
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 449677, RefRangeEnd = 449691, XrefRangeStart = 449677, XrefRangeEnd = 449677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateIfNull<T>(ref T obj) where T : class, new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.MethodInfoStoreGeneric_CreateIfNull_Public_Static_Void_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				obj = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00017C90 File Offset: 0x00015E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449691, XrefRangeEnd = 449692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Exp2(float x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_Exp2_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00017CD0 File Offset: 0x00015ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 449707, RefRangeEnd = 449708, XrefRangeStart = 449692, XrefRangeEnd = 449707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_GetJitteredPerspectiveProjectionMatrix_Public_Static_Matrix4x4_Camera_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00017D20 File Offset: 0x00015F20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 449722, RefRangeEnd = 449723, XrefRangeStart = 449708, XrefRangeEnd = 449722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_GetJitteredOrthographicProjectionMatrix_Public_Static_Matrix4x4_Camera_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00017D70 File Offset: 0x00015F70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 449730, RefRangeEnd = 449731, XrefRangeStart = 449723, XrefRangeEnd = 449730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origProj;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jitter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_GenerateJitteredProjectionMatrixFromOriginal_Public_Static_Matrix4x4_PostProcessRenderContext_Matrix4x4_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00017DD0 File Offset: 0x00015FD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 449761, RefRangeEnd = 449762, XrefRangeStart = 449731, XrefRangeEnd = 449761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Type> GetAllAssemblyTypes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.NativeMethodInfoPtr_GetAllAssemblyTypes_Public_Static_IEnumerable_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00017E04 File Offset: 0x00016004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 449786, RefRangeEnd = 449787, XrefRangeStart = 449762, XrefRangeEnd = 449786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Type> GetAllTypesDerivedFrom<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.MethodInfoStoreGeneric_GetAllTypesDerivedFrom_Public_Static_IEnumerable_1_Type_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00017E38 File Offset: 0x00016038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449787, XrefRangeEnd = 449792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetAttribute<T>(this Type type) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.MethodInfoStoreGeneric_GetAttribute_Public_Static_T_Type_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00017E78 File Offset: 0x00016078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449792, XrefRangeEnd = 449819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.MethodInfoStoreGeneric_GetMemberAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Expression_1_Func_2_TType_TValue_0<TType, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00017EBC File Offset: 0x000160BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449819, XrefRangeEnd = 449852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.MethodInfoStoreGeneric_GetFieldPath_Public_Static_String_Expression_1_Func_2_TType_TValue_0<TType, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00004B72 File Offset: 0x00002D72
		public RuntimeUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00017EF8 File Offset: 0x000160F8
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00004B7B File Offset: 0x00002D7B
		public unsafe static Texture2D m_WhiteTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_m_WhiteTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_m_WhiteTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00017F20 File Offset: 0x00016120
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00004B8D File Offset: 0x00002D8D
		public unsafe static Texture3D m_WhiteTexture3D
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_m_WhiteTexture3D, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_m_WhiteTexture3D, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00017F48 File Offset: 0x00016148
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00004B9F File Offset: 0x00002D9F
		public unsafe static Texture2D m_BlackTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_m_BlackTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_m_BlackTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00017F70 File Offset: 0x00016170
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00004BB1 File Offset: 0x00002DB1
		public unsafe static Texture3D m_BlackTexture3D
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_m_BlackTexture3D, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_m_BlackTexture3D, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00017F98 File Offset: 0x00016198
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00004BC3 File Offset: 0x00002DC3
		public unsafe static Texture2D m_TransparentTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_m_TransparentTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_m_TransparentTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00017FC0 File Offset: 0x000161C0
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x00004BD5 File Offset: 0x00002DD5
		public unsafe static Texture3D m_TransparentTexture3D
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_m_TransparentTexture3D, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_m_TransparentTexture3D, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00017FE8 File Offset: 0x000161E8
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x00004BE7 File Offset: 0x00002DE7
		public unsafe static Dictionary<int, Texture2D> m_LutStrips
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_m_LutStrips, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Texture2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_m_LutStrips, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00018010 File Offset: 0x00016210
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public unsafe static PostProcessResources s_Resources
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_s_Resources, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessResources>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_s_Resources, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00018038 File Offset: 0x00016238
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x00004C0B File Offset: 0x00002E0B
		public unsafe static Mesh s_FullscreenTriangle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_s_FullscreenTriangle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_s_FullscreenTriangle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00018060 File Offset: 0x00016260
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00004C1D File Offset: 0x00002E1D
		public unsafe static Material s_CopyStdMaterial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_s_CopyStdMaterial, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_s_CopyStdMaterial, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00018088 File Offset: 0x00016288
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00004C2F File Offset: 0x00002E2F
		public unsafe static Material s_CopyStdFromDoubleWideMaterial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_s_CopyStdFromDoubleWideMaterial, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_s_CopyStdFromDoubleWideMaterial, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x000180B0 File Offset: 0x000162B0
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00004C41 File Offset: 0x00002E41
		public unsafe static Material s_CopyMaterial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_s_CopyMaterial, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_s_CopyMaterial, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x000180D8 File Offset: 0x000162D8
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00004C53 File Offset: 0x00002E53
		public unsafe static Material s_CopyFromTexArrayMaterial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_s_CopyFromTexArrayMaterial, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_s_CopyFromTexArrayMaterial, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00018100 File Offset: 0x00016300
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x00004C65 File Offset: 0x00002E65
		public unsafe static PropertySheet s_CopySheet
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_s_CopySheet, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertySheet>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_s_CopySheet, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00018128 File Offset: 0x00016328
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00004C77 File Offset: 0x00002E77
		public unsafe static PropertySheet s_CopyFromTexArraySheet
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_s_CopyFromTexArraySheet, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertySheet>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_s_CopyFromTexArraySheet, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00018150 File Offset: 0x00016350
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x00004C89 File Offset: 0x00002E89
		public unsafe static IEnumerable<Type> m_AssemblyTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.NativeFieldInfoPtr_m_AssemblyTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.NativeFieldInfoPtr_m_AssemblyTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeFieldInfoPtr_m_WhiteTexture;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeFieldInfoPtr_m_WhiteTexture3D;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeFieldInfoPtr_m_BlackTexture;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeFieldInfoPtr_m_BlackTexture3D;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeFieldInfoPtr_m_TransparentTexture;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeFieldInfoPtr_m_TransparentTexture3D;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeFieldInfoPtr_m_LutStrips;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeFieldInfoPtr_s_Resources;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeFieldInfoPtr_s_FullscreenTriangle;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeFieldInfoPtr_s_CopyStdMaterial;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr_s_CopyStdFromDoubleWideMaterial;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeFieldInfoPtr_s_CopyMaterial;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeFieldInfoPtr_s_CopyFromTexArrayMaterial;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeFieldInfoPtr_s_CopySheet;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeFieldInfoPtr_s_CopyFromTexArraySheet;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeFieldInfoPtr_m_AssemblyTypes;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_get_whiteTexture3D_Public_Static_get_Texture3D_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_get_blackTexture_Public_Static_get_Texture2D_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_get_blackTexture3D_Public_Static_get_Texture3D_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_get_transparentTexture_Public_Static_get_Texture2D_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_get_transparentTexture3D_Public_Static_get_Texture3D_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_GetLutStrip_Public_Static_Texture2D_Int32_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_get_fullscreenTriangle_Public_Static_get_Mesh_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_get_copyStdMaterial_Public_Static_get_Material_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_get_copyStdFromDoubleWideMaterial_Public_Static_get_Material_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_get_copyMaterial_Public_Static_get_Material_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_get_copyFromTexArrayMaterial_Public_Static_get_Material_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_get_copySheet_Public_Static_get_PropertySheet_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_get_copyFromTexArraySheet_Public_Static_get_PropertySheet_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_UpdateResources_Internal_Static_Void_PostProcessResources_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTargetWithLoadStoreAction_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTargetWithLoadStoreAction_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_BlitFullscreenTriangle_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Boolean_Nullable_1_Rect_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_BlitFullscreenTriangle_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_RenderBufferLoadAction_Nullable_1_Rect_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_BlitFullscreenTriangle_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Boolean_Nullable_1_Rect_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_BlitFullscreenTriangleFromDoubleWide_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_Int32_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_BlitFullscreenTriangleToDoubleWide_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Int32_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_BlitFullscreenTriangleFromTexArray_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Boolean_Int32_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_BlitFullscreenTriangleToTexArray_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Boolean_Int32_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_BlitFullscreenTriangle_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Boolean_Nullable_1_Rect_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_BlitFullscreenTriangle_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_PropertySheet_Int32_Boolean_Nullable_1_Rect_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_BuiltinBlit_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_BuiltinBlit_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_Material_Int32_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_CopyTexture_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_get_scriptableRenderPipelineActive_Public_Static_get_Boolean_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsDeferredShading_Public_Static_get_Boolean_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsDepthNormals_Public_Static_get_Boolean_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_get_isSinglePassStereoEnabled_Public_Static_get_Boolean_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_get_isVREnabled_Public_Static_get_Boolean_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_get_isAndroidOpenGL_Public_Static_get_Boolean_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultHDRRenderTextureFormat_Public_Static_get_RenderTextureFormat_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_isFloatingPointFormat_Public_Static_Boolean_RenderTextureFormat_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_get_isLinearColorSpace_Public_Static_get_Boolean_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr_IsResolvedDepthAvailable_Public_Static_Boolean_Camera_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_DestroyProfile_Public_Static_Void_PostProcessProfile_Boolean_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_DestroyVolume_Public_Static_Void_PostProcessVolume_Boolean_Boolean_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_IsPostProcessingActive_Public_Static_Boolean_PostProcessLayer_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_IsTemporalAntialiasingActive_Public_Static_Boolean_PostProcessLayer_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_GetAllSceneObjects_Public_Static_IEnumerable_1_T_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_CreateIfNull_Public_Static_Void_byref_T_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_Exp2_Public_Static_Single_Single_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_GetJitteredPerspectiveProjectionMatrix_Public_Static_Matrix4x4_Camera_Vector2_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_GetJitteredOrthographicProjectionMatrix_Public_Static_Matrix4x4_Camera_Vector2_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_GenerateJitteredProjectionMatrixFromOriginal_Public_Static_Matrix4x4_PostProcessRenderContext_Matrix4x4_Vector2_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_GetAllAssemblyTypes_Public_Static_IEnumerable_1_Type_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_GetAllTypesDerivedFrom_Public_Static_IEnumerable_1_Type_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Static_T_Type_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Expression_1_Func_2_TType_TValue_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldPath_Public_Static_String_Expression_1_Func_2_TType_TValue_0;

		// Token: 0x02000094 RID: 148
		[ObfuscatedName("UnityEngine.Rendering.PostProcessing.RuntimeUtilities+<GetAllSceneObjects>d__80`1")]
		public sealed class _GetAllSceneObjects_d__80<T> : Object where T : Component
		{
			// Token: 0x060007A7 RID: 1959 RVA: 0x0001CCB0 File Offset: 0x0001AEB0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAllSceneObjects_d__80()
			{
				Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "<GetAllSceneObjects>d__80`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr);
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, "<>1__state");
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, "<>2__current");
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, "<>l__initialThreadId");
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr__queue_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, "<queue>5__2");
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, "<>7__wrap2");
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, "<>7__wrap3");
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, "<>7__wrap4");
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, 100663858);
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, 100663859);
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, 100663860);
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, 100663861);
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, 100663862);
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, 100663863);
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, 100663864);
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, 100663865);
				RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr, 100663866);
			}

			// Token: 0x060007A8 RID: 1960 RVA: 0x0001CE58 File Offset: 0x0001B058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetAllSceneObjects_d__80(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeUtilities._GetAllSceneObjects_d__80<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060007A9 RID: 1961 RVA: 0x0001CEA0 File Offset: 0x0001B0A0
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007AA RID: 1962 RVA: 0x0001CED4 File Offset: 0x0001B0D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448703, XrefRangeEnd = 448768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060007AB RID: 1963 RVA: 0x0001CF10 File Offset: 0x0001B110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448768, XrefRangeEnd = 448773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000294 RID: 660
			// (get) Token: 0x060007AC RID: 1964 RVA: 0x0001CF44 File Offset: 0x0001B144
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060007AD RID: 1965 RVA: 0x0001CF80 File Offset: 0x0001B180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448773, XrefRangeEnd = 448778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000295 RID: 661
			// (get) Token: 0x060007AE RID: 1966 RVA: 0x0001CFB4 File Offset: 0x0001B1B4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060007AF RID: 1967 RVA: 0x0001CFF4 File Offset: 0x0001B1F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448778, XrefRangeEnd = 448780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x060007B0 RID: 1968 RVA: 0x0001D034 File Offset: 0x0001B234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448780, XrefRangeEnd = 448781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060007B1 RID: 1969 RVA: 0x00005E8A File Offset: 0x0000408A
			public _GetAllSceneObjects_d__80(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700028D RID: 653
			// (get) Token: 0x060007B2 RID: 1970 RVA: 0x0001D074 File Offset: 0x0001B274
			// (set) Token: 0x060007B3 RID: 1971 RVA: 0x00005E93 File Offset: 0x00004093
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0001D09C File Offset: 0x0001B29C
			// (set) Token: 0x060007B5 RID: 1973 RVA: 0x0001D0C4 File Offset: 0x0001B2C4
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x1700028F RID: 655
			// (get) Token: 0x060007B6 RID: 1974 RVA: 0x0001D16C File Offset: 0x0001B36C
			// (set) Token: 0x060007B7 RID: 1975 RVA: 0x00005EAE File Offset: 0x000040AE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000290 RID: 656
			// (get) Token: 0x060007B8 RID: 1976 RVA: 0x0001D194 File Offset: 0x0001B394
			// (set) Token: 0x060007B9 RID: 1977 RVA: 0x00005EC9 File Offset: 0x000040C9
			public unsafe Queue<Transform> _queue_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr__queue_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<Transform>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr__queue_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x060007BA RID: 1978 RVA: 0x0001D1C4 File Offset: 0x0001B3C4
			// (set) Token: 0x060007BB RID: 1979 RVA: 0x00005EE8 File Offset: 0x000040E8
			public unsafe Il2CppReferenceArray<GameObject> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000292 RID: 658
			// (get) Token: 0x060007BC RID: 1980 RVA: 0x0001D1F4 File Offset: 0x0001B3F4
			// (set) Token: 0x060007BD RID: 1981 RVA: 0x00005F07 File Offset: 0x00004107
			public unsafe int __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___7__wrap3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___7__wrap3)) = value;
				}
			}

			// Token: 0x17000293 RID: 659
			// (get) Token: 0x060007BE RID: 1982 RVA: 0x0001D21C File Offset: 0x0001B41C
			// (set) Token: 0x060007BF RID: 1983 RVA: 0x00005F22 File Offset: 0x00004122
			public unsafe IEnumerator __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeUtilities._GetAllSceneObjects_d__80<T>.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000546 RID: 1350
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000547 RID: 1351
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000548 RID: 1352
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000549 RID: 1353
			private static readonly IntPtr NativeFieldInfoPtr__queue_5__2;

			// Token: 0x0400054A RID: 1354
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400054B RID: 1355
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400054C RID: 1356
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x0400054D RID: 1357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400054E RID: 1358
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400054F RID: 1359
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000550 RID: 1360
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000551 RID: 1361
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x04000552 RID: 1362
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000553 RID: 1363
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000554 RID: 1364
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x04000555 RID: 1365
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000095 RID: 149
		[ObfuscatedName("UnityEngine.Rendering.PostProcessing.RuntimeUtilities+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060007C0 RID: 1984 RVA: 0x0001D24C File Offset: 0x0001B44C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RuntimeUtilities.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeUtilities.__c>.NativeClassPtr);
				RuntimeUtilities.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities.__c>.NativeClassPtr, "<>9");
				RuntimeUtilities.__c.NativeFieldInfoPtr___9__87_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities.__c>.NativeClassPtr, "<>9__87_0");
				RuntimeUtilities.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities.__c>.NativeClassPtr, 100663868);
				RuntimeUtilities.__c.NativeMethodInfoPtr__GetAllAssemblyTypes_b__87_0_Internal_IEnumerable_1_Type_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities.__c>.NativeClassPtr, 100663869);
			}

			// Token: 0x060007C1 RID: 1985 RVA: 0x0001D2C8 File Offset: 0x0001B4C8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeUtilities.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007C2 RID: 1986 RVA: 0x0001D304 File Offset: 0x0001B504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448781, XrefRangeEnd = 448785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Type> _GetAllAssemblyTypes_b__87_0(Assembly t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.__c.NativeMethodInfoPtr__GetAllAssemblyTypes_b__87_0_Internal_IEnumerable_1_Type_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
				}
			}

			// Token: 0x060007C3 RID: 1987 RVA: 0x00005F41 File Offset: 0x00004141
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000296 RID: 662
			// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0001D354 File Offset: 0x0001B554
			// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00005F4A File Offset: 0x0000414A
			public unsafe static RuntimeUtilities.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeUtilities.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000297 RID: 663
			// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0001D37C File Offset: 0x0001B57C
			// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00005F5C File Offset: 0x0000415C
			public unsafe static Func<Assembly, IEnumerable<Type>> __9__87_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.__c.NativeFieldInfoPtr___9__87_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Assembly, IEnumerable<Type>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.__c.NativeFieldInfoPtr___9__87_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000556 RID: 1366
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000557 RID: 1367
			private static readonly IntPtr NativeFieldInfoPtr___9__87_0;

			// Token: 0x04000558 RID: 1368
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000559 RID: 1369
			private static readonly IntPtr NativeMethodInfoPtr__GetAllAssemblyTypes_b__87_0_Internal_IEnumerable_1_Type_Assembly_0;
		}

		// Token: 0x02000096 RID: 150
		[ObfuscatedName("UnityEngine.Rendering.PostProcessing.RuntimeUtilities+<>c__88`1")]
		[Serializable]
		public sealed class __c__88<T> : Object
		{
			// Token: 0x060007C8 RID: 1992 RVA: 0x0001D3A4 File Offset: 0x0001B5A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__88()
			{
				Il2CppClassPointerStore<RuntimeUtilities.__c__88<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr, "<>c__88`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeUtilities.__c__88<T>>.NativeClassPtr);
				RuntimeUtilities.__c__88<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities.__c__88<T>>.NativeClassPtr, "<>9");
				RuntimeUtilities.__c__88<T>.NativeFieldInfoPtr___9__88_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeUtilities.__c__88<T>>.NativeClassPtr, "<>9__88_0");
				RuntimeUtilities.__c__88<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities.__c__88<T>>.NativeClassPtr, 100663871);
				RuntimeUtilities.__c__88<T>.NativeMethodInfoPtr__GetAllTypesDerivedFrom_b__88_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeUtilities.__c__88<T>>.NativeClassPtr, 100663872);
			}

			// Token: 0x060007C9 RID: 1993 RVA: 0x0001D45C File Offset: 0x0001B65C
			[CallerCount(0)]
			public unsafe __c__88()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeUtilities.__c__88<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.__c__88<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060007CA RID: 1994 RVA: 0x0001D498 File Offset: 0x0001B698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 448785, XrefRangeEnd = 448790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllTypesDerivedFrom_b__88_0(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeUtilities.__c__88<T>.NativeMethodInfoPtr__GetAllTypesDerivedFrom_b__88_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060007CB RID: 1995 RVA: 0x00005F6E File Offset: 0x0000416E
			public __c__88(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000298 RID: 664
			// (get) Token: 0x060007CC RID: 1996 RVA: 0x0001D4E8 File Offset: 0x0001B6E8
			// (set) Token: 0x060007CD RID: 1997 RVA: 0x00005F77 File Offset: 0x00004177
			public unsafe static RuntimeUtilities.__c__88<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.__c__88<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeUtilities.__c__88<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.__c__88<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000299 RID: 665
			// (get) Token: 0x060007CE RID: 1998 RVA: 0x0001D510 File Offset: 0x0001B710
			// (set) Token: 0x060007CF RID: 1999 RVA: 0x00005F89 File Offset: 0x00004189
			public unsafe static Func<Type, bool> __9__88_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RuntimeUtilities.__c__88<T>.NativeFieldInfoPtr___9__88_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RuntimeUtilities.__c__88<T>.NativeFieldInfoPtr___9__88_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400055A RID: 1370
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400055B RID: 1371
			private static readonly IntPtr NativeFieldInfoPtr___9__88_0;

			// Token: 0x0400055C RID: 1372
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400055D RID: 1373
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTypesDerivedFrom_b__88_0_Internal_Boolean_Type_0;
		}

		// Token: 0x02000097 RID: 151
		private sealed class MethodInfoStoreGeneric_GetAllSceneObjects_Public_Static_IEnumerable_1_T_0<T>
		{
			// Token: 0x0400055E RID: 1374
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RuntimeUtilities.NativeMethodInfoPtr_GetAllSceneObjects_Public_Static_IEnumerable_1_T_0, Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000098 RID: 152
		private sealed class MethodInfoStoreGeneric_CreateIfNull_Public_Static_Void_byref_T_0<T>
		{
			// Token: 0x0400055F RID: 1375
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RuntimeUtilities.NativeMethodInfoPtr_CreateIfNull_Public_Static_Void_byref_T_0, Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000099 RID: 153
		private sealed class MethodInfoStoreGeneric_GetAllTypesDerivedFrom_Public_Static_IEnumerable_1_Type_0<T>
		{
			// Token: 0x04000560 RID: 1376
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RuntimeUtilities.NativeMethodInfoPtr_GetAllTypesDerivedFrom_Public_Static_IEnumerable_1_Type_0, Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200009A RID: 154
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_Static_T_Type_0<T>
		{
			// Token: 0x04000561 RID: 1377
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RuntimeUtilities.NativeMethodInfoPtr_GetAttribute_Public_Static_T_Type_0, Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200009B RID: 155
		private sealed class MethodInfoStoreGeneric_GetMemberAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Expression_1_Func_2_TType_TValue_0<TType, TValue>
		{
			// Token: 0x04000562 RID: 1378
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RuntimeUtilities.NativeMethodInfoPtr_GetMemberAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Expression_1_Func_2_TType_TValue_0, Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200009C RID: 156
		private sealed class MethodInfoStoreGeneric_GetFieldPath_Public_Static_String_Expression_1_Func_2_TType_TValue_0<TType, TValue>
		{
			// Token: 0x04000563 RID: 1379
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RuntimeUtilities.NativeMethodInfoPtr_GetFieldPath_Public_Static_String_Expression_1_Func_2_TType_TValue_0, Il2CppClassPointerStore<RuntimeUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}
	}
}
