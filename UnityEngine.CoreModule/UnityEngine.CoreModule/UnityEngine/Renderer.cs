using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x0200006F RID: 111
	public class Renderer : Component
	{
		// Token: 0x0600088D RID: 2189 RVA: 0x00029AF8 File Offset: 0x00027CF8
		// Note: this type is marked as 'beforefieldinit'.
		static Renderer()
		{
			Il2CppClassPointerStore<Renderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Renderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Renderer>.NativeClassPtr);
			Renderer.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663874);
			Renderer.NativeMethodInfoPtr_GetMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663875);
			Renderer.NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663876);
			Renderer.NativeMethodInfoPtr_SetMaterial_Private_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663877);
			Renderer.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663878);
			Renderer.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663879);
			Renderer.NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663880);
			Renderer.NativeMethodInfoPtr_get_shadowCastingMode_Public_get_ShadowCastingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663881);
			Renderer.NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663882);
			Renderer.NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663883);
			Renderer.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663884);
			Renderer.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663885);
			Renderer.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663886);
			Renderer.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663887);
			Renderer.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663888);
			Renderer.NativeMethodInfoPtr_get_sortingGroupID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663889);
			Renderer.NativeMethodInfoPtr_get_sortingGroupOrder_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663890);
			Renderer.NativeMethodInfoPtr_GetLightmapIndex_Private_Int32_LightmapType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663891);
			Renderer.NativeMethodInfoPtr_get_lightmapIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663892);
			Renderer.NativeMethodInfoPtr_GetSharedMaterialArray_Private_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663893);
			Renderer.NativeMethodInfoPtr_get_material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663894);
			Renderer.NativeMethodInfoPtr_set_material_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663895);
			Renderer.NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663896);
			Renderer.NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663897);
			Renderer.NativeMethodInfoPtr_get_sharedMaterials_Public_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663898);
			Renderer.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer>.NativeClassPtr, 100663899);
			Renderer.GetMaterialArrayDelegateField = IL2CPP.ResolveICall<Renderer.GetMaterialArrayDelegate>("UnityEngine.Renderer::GetMaterialArray");
			Renderer.CopyMaterialArrayDelegateField = IL2CPP.ResolveICall<Renderer.CopyMaterialArrayDelegate>("UnityEngine.Renderer::CopyMaterialArray");
			Renderer.CopySharedMaterialArrayDelegateField = IL2CPP.ResolveICall<Renderer.CopySharedMaterialArrayDelegate>("UnityEngine.Renderer::CopySharedMaterialArray");
			Renderer.SetMaterialArrayDelegateField = IL2CPP.ResolveICall<Renderer.SetMaterialArrayDelegate>("UnityEngine.Renderer::SetMaterialArray");
			Renderer.Internal_SetPropertyBlockDelegateField = IL2CPP.ResolveICall<Renderer.Internal_SetPropertyBlockDelegate>("UnityEngine.Renderer::Internal_SetPropertyBlock");
			Renderer.Internal_GetPropertyBlockDelegateField = IL2CPP.ResolveICall<Renderer.Internal_GetPropertyBlockDelegate>("UnityEngine.Renderer::Internal_GetPropertyBlock");
			Renderer.Internal_SetPropertyBlockMaterialIndexDelegateField = IL2CPP.ResolveICall<Renderer.Internal_SetPropertyBlockMaterialIndexDelegate>("UnityEngine.Renderer::Internal_SetPropertyBlockMaterialIndex");
			Renderer.Internal_GetPropertyBlockMaterialIndexDelegateField = IL2CPP.ResolveICall<Renderer.Internal_GetPropertyBlockMaterialIndexDelegate>("UnityEngine.Renderer::Internal_GetPropertyBlockMaterialIndex");
			Renderer.HasPropertyBlockDelegateField = IL2CPP.ResolveICall<Renderer.HasPropertyBlockDelegate>("UnityEngine.Renderer::HasPropertyBlock");
			Renderer.GetClosestReflectionProbesInternalDelegateField = IL2CPP.ResolveICall<Renderer.GetClosestReflectionProbesInternalDelegate>("UnityEngine.Renderer::GetClosestReflectionProbesInternal");
			Renderer.get_receiveShadowsDelegateField = IL2CPP.ResolveICall<Renderer.get_receiveShadowsDelegate>("UnityEngine.Renderer::get_receiveShadows");
			Renderer.get_forceRenderingOffDelegateField = IL2CPP.ResolveICall<Renderer.get_forceRenderingOffDelegate>("UnityEngine.Renderer::get_forceRenderingOff");
			Renderer.set_forceRenderingOffDelegateField = IL2CPP.ResolveICall<Renderer.set_forceRenderingOffDelegate>("UnityEngine.Renderer::set_forceRenderingOff");
			Renderer.get_motionVectorGenerationModeDelegateField = IL2CPP.ResolveICall<Renderer.get_motionVectorGenerationModeDelegate>("UnityEngine.Renderer::get_motionVectorGenerationMode");
			Renderer.set_motionVectorGenerationModeDelegateField = IL2CPP.ResolveICall<Renderer.set_motionVectorGenerationModeDelegate>("UnityEngine.Renderer::set_motionVectorGenerationMode");
			Renderer.get_lightProbeUsageDelegateField = IL2CPP.ResolveICall<Renderer.get_lightProbeUsageDelegate>("UnityEngine.Renderer::get_lightProbeUsage");
			Renderer.set_lightProbeUsageDelegateField = IL2CPP.ResolveICall<Renderer.set_lightProbeUsageDelegate>("UnityEngine.Renderer::set_lightProbeUsage");
			Renderer.get_reflectionProbeUsageDelegateField = IL2CPP.ResolveICall<Renderer.get_reflectionProbeUsageDelegate>("UnityEngine.Renderer::get_reflectionProbeUsage");
			Renderer.set_reflectionProbeUsageDelegateField = IL2CPP.ResolveICall<Renderer.set_reflectionProbeUsageDelegate>("UnityEngine.Renderer::set_reflectionProbeUsage");
			Renderer.get_renderingLayerMaskDelegateField = IL2CPP.ResolveICall<Renderer.get_renderingLayerMaskDelegate>("UnityEngine.Renderer::get_renderingLayerMask");
			Renderer.set_renderingLayerMaskDelegateField = IL2CPP.ResolveICall<Renderer.set_renderingLayerMaskDelegate>("UnityEngine.Renderer::set_renderingLayerMask");
			Renderer.get_rendererPriorityDelegateField = IL2CPP.ResolveICall<Renderer.get_rendererPriorityDelegate>("UnityEngine.Renderer::get_rendererPriority");
			Renderer.set_rendererPriorityDelegateField = IL2CPP.ResolveICall<Renderer.set_rendererPriorityDelegate>("UnityEngine.Renderer::set_rendererPriority");
			Renderer.get_rayTracingModeDelegateField = IL2CPP.ResolveICall<Renderer.get_rayTracingModeDelegate>("UnityEngine.Renderer::get_rayTracingMode");
			Renderer.set_rayTracingModeDelegateField = IL2CPP.ResolveICall<Renderer.set_rayTracingModeDelegate>("UnityEngine.Renderer::set_rayTracingMode");
			Renderer.get_sortingLayerNameDelegateField = IL2CPP.ResolveICall<Renderer.get_sortingLayerNameDelegate>("UnityEngine.Renderer::get_sortingLayerName");
			Renderer.set_sortingGroupIDDelegateField = IL2CPP.ResolveICall<Renderer.set_sortingGroupIDDelegate>("UnityEngine.Renderer::set_sortingGroupID");
			Renderer.set_sortingGroupOrderDelegateField = IL2CPP.ResolveICall<Renderer.set_sortingGroupOrderDelegate>("UnityEngine.Renderer::set_sortingGroupOrder");
			Renderer.get_allowOcclusionWhenDynamicDelegateField = IL2CPP.ResolveICall<Renderer.get_allowOcclusionWhenDynamicDelegate>("UnityEngine.Renderer::get_allowOcclusionWhenDynamic");
			Renderer.set_allowOcclusionWhenDynamicDelegateField = IL2CPP.ResolveICall<Renderer.set_allowOcclusionWhenDynamicDelegate>("UnityEngine.Renderer::set_allowOcclusionWhenDynamic");
			Renderer.get_staticBatchRootTransformDelegateField = IL2CPP.ResolveICall<Renderer.get_staticBatchRootTransformDelegate>("UnityEngine.Renderer::get_staticBatchRootTransform");
			Renderer.set_staticBatchRootTransformDelegateField = IL2CPP.ResolveICall<Renderer.set_staticBatchRootTransformDelegate>("UnityEngine.Renderer::set_staticBatchRootTransform");
			Renderer.get_staticBatchIndexDelegateField = IL2CPP.ResolveICall<Renderer.get_staticBatchIndexDelegate>("UnityEngine.Renderer::get_staticBatchIndex");
			Renderer.SetStaticBatchInfoDelegateField = IL2CPP.ResolveICall<Renderer.SetStaticBatchInfoDelegate>("UnityEngine.Renderer::SetStaticBatchInfo");
			Renderer.get_isPartOfStaticBatchDelegateField = IL2CPP.ResolveICall<Renderer.get_isPartOfStaticBatchDelegate>("UnityEngine.Renderer::get_isPartOfStaticBatch");
			Renderer.get_lightProbeProxyVolumeOverrideDelegateField = IL2CPP.ResolveICall<Renderer.get_lightProbeProxyVolumeOverrideDelegate>("UnityEngine.Renderer::get_lightProbeProxyVolumeOverride");
			Renderer.set_lightProbeProxyVolumeOverrideDelegateField = IL2CPP.ResolveICall<Renderer.set_lightProbeProxyVolumeOverrideDelegate>("UnityEngine.Renderer::set_lightProbeProxyVolumeOverride");
			Renderer.get_probeAnchorDelegateField = IL2CPP.ResolveICall<Renderer.get_probeAnchorDelegate>("UnityEngine.Renderer::get_probeAnchor");
			Renderer.set_probeAnchorDelegateField = IL2CPP.ResolveICall<Renderer.set_probeAnchorDelegate>("UnityEngine.Renderer::set_probeAnchor");
			Renderer.SetLightmapIndexDelegateField = IL2CPP.ResolveICall<Renderer.SetLightmapIndexDelegate>("UnityEngine.Renderer::SetLightmapIndex");
			Renderer.GetMaterialCountDelegateField = IL2CPP.ResolveICall<Renderer.GetMaterialCountDelegate>("UnityEngine.Renderer::GetMaterialCount");
			Renderer.SetStaticLightmapST_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.SetStaticLightmapST_InjectedDelegate>("UnityEngine.Renderer::SetStaticLightmapST_Injected");
			Renderer.get_worldToLocalMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.get_worldToLocalMatrix_InjectedDelegate>("UnityEngine.Renderer::get_worldToLocalMatrix_Injected");
			Renderer.get_localToWorldMatrix_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.get_localToWorldMatrix_InjectedDelegate>("UnityEngine.Renderer::get_localToWorldMatrix_Injected");
			Renderer.GetLightmapST_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.GetLightmapST_InjectedDelegate>("UnityEngine.Renderer::GetLightmapST_Injected");
			Renderer.SetLightmapST_InjectedDelegateField = IL2CPP.ResolveICall<Renderer.SetLightmapST_InjectedDelegate>("UnityEngine.Renderer::SetLightmapST_Injected");
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x00029FE4 File Offset: 0x000281E4
		public unsafe Bounds bounds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488329, XrefRangeEnd = 488331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0002A020 File Offset: 0x00028220
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 488335, RefRangeEnd = 488340, XrefRangeStart = 488331, XrefRangeEnd = 488335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0002A060 File Offset: 0x00028260
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 488344, RefRangeEnd = 488390, XrefRangeStart = 488340, XrefRangeEnd = 488344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetSharedMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0002A0A0 File Offset: 0x000282A0
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 488394, RefRangeEnd = 488427, XrefRangeStart = 488390, XrefRangeEnd = 488394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial(Material m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_SetMaterial_Private_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x0002A0E4 File Offset: 0x000282E4
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x0002A120 File Offset: 0x00028320
		public unsafe bool enabled
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 488431, RefRangeEnd = 488433, XrefRangeStart = 488427, XrefRangeEnd = 488431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 488437, RefRangeEnd = 488451, XrefRangeStart = 488433, XrefRangeEnd = 488437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x0002A160 File Offset: 0x00028360
		public unsafe bool isVisible
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 488455, RefRangeEnd = 488457, XrefRangeStart = 488451, XrefRangeEnd = 488455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x0002A19C File Offset: 0x0002839C
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x0002A1D8 File Offset: 0x000283D8
		public unsafe UnityEngine.Rendering.ShadowCastingMode shadowCastingMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488457, XrefRangeEnd = 488461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_shadowCastingMode_Public_get_ShadowCastingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 488465, RefRangeEnd = 488468, XrefRangeStart = 488461, XrefRangeEnd = 488465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00006B98 File Offset: 0x00004D98
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x0002A218 File Offset: 0x00028418
		public unsafe bool receiveShadows
		{
			get
			{
				return Renderer.get_receiveShadowsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 488472, RefRangeEnd = 488475, XrefRangeStart = 488468, XrefRangeEnd = 488472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x0002A6DC File Offset: 0x000288DC
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x0002A258 File Offset: 0x00028458
		public unsafe string sortingLayerName
		{
			get
			{
				IntPtr intPtr = Renderer.get_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 488479, RefRangeEnd = 488482, XrefRangeStart = 488475, XrefRangeEnd = 488479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x0002A29C File Offset: 0x0002849C
		// (set) Token: 0x0600089A RID: 2202 RVA: 0x0002A2D8 File Offset: 0x000284D8
		public unsafe int sortingLayerID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 488486, RefRangeEnd = 488489, XrefRangeStart = 488482, XrefRangeEnd = 488486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 488493, RefRangeEnd = 488504, XrefRangeStart = 488489, XrefRangeEnd = 488493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x0002A318 File Offset: 0x00028518
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x0002A354 File Offset: 0x00028554
		public unsafe int sortingOrder
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 488508, RefRangeEnd = 488516, XrefRangeStart = 488504, XrefRangeEnd = 488508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 488520, RefRangeEnd = 488548, XrefRangeStart = 488516, XrefRangeEnd = 488520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x0002A394 File Offset: 0x00028594
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x00006CAD File Offset: 0x00004EAD
		public unsafe int sortingGroupID
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 488552, RefRangeEnd = 488554, XrefRangeStart = 488548, XrefRangeEnd = 488552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sortingGroupID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Renderer.set_sortingGroupIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0002A3D0 File Offset: 0x000285D0
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x00006CC0 File Offset: 0x00004EC0
		public unsafe int sortingGroupOrder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 488558, RefRangeEnd = 488559, XrefRangeStart = 488554, XrefRangeEnd = 488558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sortingGroupOrder_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Renderer.set_sortingGroupOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0002A40C File Offset: 0x0002860C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488559, XrefRangeEnd = 488563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLightmapIndex(global::UnityEngineInternal.LightmapType lt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetLightmapIndex_Private_Int32_LightmapType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0002A458 File Offset: 0x00028658
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x00006D97 File Offset: 0x00004F97
		public unsafe int lightmapIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488563, XrefRangeEnd = 488567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_lightmapIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.SetLightmapIndex(value, global::UnityEngineInternal.LightmapType.StaticLightmap);
			}
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0002A494 File Offset: 0x00028694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488567, XrefRangeEnd = 488571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Material> GetSharedMaterialArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_GetSharedMaterialArray_Private_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x0002A4D4 File Offset: 0x000286D4
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x0002A514 File Offset: 0x00028714
		public unsafe Material material
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 488335, RefRangeEnd = 488340, XrefRangeStart = 488335, XrefRangeEnd = 488340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 488394, RefRangeEnd = 488427, XrefRangeStart = 488394, XrefRangeEnd = 488427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_material_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0002A558 File Offset: 0x00028758
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x0002A598 File Offset: 0x00028798
		public unsafe Material sharedMaterial
		{
			[CallerCount(46)]
			[CachedScanResults(RefRangeStart = 488344, RefRangeEnd = 488390, XrefRangeStart = 488344, XrefRangeEnd = 488390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 488394, RefRangeEnd = 488427, XrefRangeStart = 488394, XrefRangeEnd = 488427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0002A5DC File Offset: 0x000287DC
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public unsafe Il2CppReferenceArray<Material> sharedMaterials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_sharedMaterials_Public_get_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
			}
			set
			{
				this.SetMaterialArray(value);
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0002A61C File Offset: 0x0002881C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488571, XrefRangeEnd = 488575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00006A50 File Offset: 0x00004C50
		public Renderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0002A65C File Offset: 0x0002885C
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x00006A59 File Offset: 0x00004C59
		public bool castShadows
		{
			get
			{
				return this.shadowCastingMode > UnityEngine.Rendering.ShadowCastingMode.Off;
			}
			set
			{
				this.shadowCastingMode = (value ? UnityEngine.Rendering.ShadowCastingMode.On : UnityEngine.Rendering.ShadowCastingMode.Off);
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x0002A678 File Offset: 0x00028878
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x00006A6A File Offset: 0x00004C6A
		public bool motionVectors
		{
			get
			{
				return this.motionVectorGenerationMode == MotionVectorGenerationMode.Object;
			}
			set
			{
				this.motionVectorGenerationMode = (value ? MotionVectorGenerationMode.Object : MotionVectorGenerationMode.Camera);
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x0002A694 File Offset: 0x00028894
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x00006A7B File Offset: 0x00004C7B
		public bool useLightProbes
		{
			get
			{
				return this.lightProbeUsage > UnityEngine.Rendering.LightProbeUsage.Off;
			}
			set
			{
				this.lightProbeUsage = (value ? UnityEngine.Rendering.LightProbeUsage.BlendProbes : UnityEngine.Rendering.LightProbeUsage.Off);
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00006A8C File Offset: 0x00004C8C
		public void SetStaticLightmapST(Vector4 st)
		{
			this.SetStaticLightmapST_Injected(ref st);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0002A6B0 File Offset: 0x000288B0
		public Il2CppReferenceArray<Material> GetMaterialArray()
		{
			IntPtr intPtr = Renderer.GetMaterialArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00006A96 File Offset: 0x00004C96
		public void CopyMaterialArray([Out] Il2CppReferenceArray<Material> m)
		{
			Renderer.CopyMaterialArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(m));
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00006AAE File Offset: 0x00004CAE
		public void CopySharedMaterialArray([Out] Il2CppReferenceArray<Material> m)
		{
			Renderer.CopySharedMaterialArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(m));
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00006AC6 File Offset: 0x00004CC6
		public void SetMaterialArray(Il2CppReferenceArray<Material> m)
		{
			Renderer.SetMaterialArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(m));
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00006ADE File Offset: 0x00004CDE
		public void Internal_SetPropertyBlock(MaterialPropertyBlock properties)
		{
			Renderer.Internal_SetPropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00006AF6 File Offset: 0x00004CF6
		public void Internal_GetPropertyBlock(MaterialPropertyBlock dest)
		{
			Renderer.Internal_GetPropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(dest));
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00006B0E File Offset: 0x00004D0E
		public void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex)
		{
			Renderer.Internal_SetPropertyBlockMaterialIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(properties), materialIndex);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00006B27 File Offset: 0x00004D27
		public void Internal_GetPropertyBlockMaterialIndex(MaterialPropertyBlock dest, int materialIndex)
		{
			Renderer.Internal_GetPropertyBlockMaterialIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(dest), materialIndex);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00006B40 File Offset: 0x00004D40
		public bool HasPropertyBlock()
		{
			return Renderer.HasPropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00006B52 File Offset: 0x00004D52
		public void SetPropertyBlock(MaterialPropertyBlock properties)
		{
			this.Internal_SetPropertyBlock(properties);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00006B5D File Offset: 0x00004D5D
		public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex)
		{
			this.Internal_SetPropertyBlockMaterialIndex(properties, materialIndex);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00006B69 File Offset: 0x00004D69
		public void GetPropertyBlock(MaterialPropertyBlock properties)
		{
			this.Internal_GetPropertyBlock(properties);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00006B74 File Offset: 0x00004D74
		public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex)
		{
			this.Internal_GetPropertyBlockMaterialIndex(properties, materialIndex);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00006B80 File Offset: 0x00004D80
		public void GetClosestReflectionProbesInternal(Object result)
		{
			Renderer.GetClosestReflectionProbesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(result));
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00006BAA File Offset: 0x00004DAA
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x00006BBC File Offset: 0x00004DBC
		public bool forceRenderingOff
		{
			get
			{
				return Renderer.get_forceRenderingOffDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_forceRenderingOffDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00006BCF File Offset: 0x00004DCF
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x00006BE1 File Offset: 0x00004DE1
		public MotionVectorGenerationMode motionVectorGenerationMode
		{
			get
			{
				return Renderer.get_motionVectorGenerationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_motionVectorGenerationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x00006BF4 File Offset: 0x00004DF4
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x00006C06 File Offset: 0x00004E06
		public UnityEngine.Rendering.LightProbeUsage lightProbeUsage
		{
			get
			{
				return Renderer.get_lightProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_lightProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00006C19 File Offset: 0x00004E19
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x00006C2B File Offset: 0x00004E2B
		public UnityEngine.Rendering.ReflectionProbeUsage reflectionProbeUsage
		{
			get
			{
				return Renderer.get_reflectionProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_reflectionProbeUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x00006C3E File Offset: 0x00004E3E
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x00006C50 File Offset: 0x00004E50
		public uint renderingLayerMask
		{
			get
			{
				return Renderer.get_renderingLayerMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_renderingLayerMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x00006C63 File Offset: 0x00004E63
		// (set) Token: 0x060008CA RID: 2250 RVA: 0x00006C75 File Offset: 0x00004E75
		public int rendererPriority
		{
			get
			{
				return Renderer.get_rendererPriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_rendererPriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x00006C88 File Offset: 0x00004E88
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x00006C9A File Offset: 0x00004E9A
		public UnityEngine.Experimental.Rendering.RayTracingMode rayTracingMode
		{
			get
			{
				return Renderer.get_rayTracingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_rayTracingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00006CD3 File Offset: 0x00004ED3
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00006CE5 File Offset: 0x00004EE5
		public bool allowOcclusionWhenDynamic
		{
			get
			{
				return Renderer.get_allowOcclusionWhenDynamicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Renderer.set_allowOcclusionWhenDynamicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0002A700 File Offset: 0x00028900
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x00006CF8 File Offset: 0x00004EF8
		public Transform staticBatchRootTransform
		{
			get
			{
				IntPtr intPtr = Renderer.get_staticBatchRootTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				Renderer.set_staticBatchRootTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00006D10 File Offset: 0x00004F10
		public int staticBatchIndex
		{
			get
			{
				return Renderer.get_staticBatchIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00006D22 File Offset: 0x00004F22
		public void SetStaticBatchInfo(int firstSubMesh, int subMeshCount)
		{
			Renderer.SetStaticBatchInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), firstSubMesh, subMeshCount);
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00006D36 File Offset: 0x00004F36
		public bool isPartOfStaticBatch
		{
			get
			{
				return Renderer.get_isPartOfStaticBatchDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x0002A72C File Offset: 0x0002892C
		public Matrix4x4 worldToLocalMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_worldToLocalMatrix_Injected(out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0002A744 File Offset: 0x00028944
		public Matrix4x4 localToWorldMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_localToWorldMatrix_Injected(out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x0002A75C File Offset: 0x0002895C
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x00006D48 File Offset: 0x00004F48
		public GameObject lightProbeProxyVolumeOverride
		{
			get
			{
				IntPtr intPtr = Renderer.get_lightProbeProxyVolumeOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				Renderer.set_lightProbeProxyVolumeOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x0002A788 File Offset: 0x00028988
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x00006D60 File Offset: 0x00004F60
		public Transform probeAnchor
		{
			get
			{
				IntPtr intPtr = Renderer.get_probeAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				Renderer.set_probeAnchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00006D78 File Offset: 0x00004F78
		public void SetLightmapIndex(int index, global::UnityEngineInternal.LightmapType lt)
		{
			Renderer.SetLightmapIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, lt);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0002A7B4 File Offset: 0x000289B4
		public Vector4 GetLightmapST(global::UnityEngineInternal.LightmapType lt)
		{
			Vector4 vector;
			this.GetLightmapST_Injected(lt, out vector);
			return vector;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00006D8C File Offset: 0x00004F8C
		public void SetLightmapST(Vector4 st, global::UnityEngineInternal.LightmapType lt)
		{
			this.SetLightmapST_Injected(ref st, lt);
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x0002A7CC File Offset: 0x000289CC
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x00006DA3 File Offset: 0x00004FA3
		public int realtimeLightmapIndex
		{
			get
			{
				return this.GetLightmapIndex(global::UnityEngineInternal.LightmapType.DynamicLightmap);
			}
			set
			{
				this.SetLightmapIndex(value, global::UnityEngineInternal.LightmapType.DynamicLightmap);
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x0002A7E8 File Offset: 0x000289E8
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x00006DAF File Offset: 0x00004FAF
		public Vector4 lightmapScaleOffset
		{
			get
			{
				return this.GetLightmapST(global::UnityEngineInternal.LightmapType.StaticLightmap);
			}
			set
			{
				this.SetStaticLightmapST(value);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x0002A804 File Offset: 0x00028A04
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00006DBA File Offset: 0x00004FBA
		public Vector4 realtimeLightmapScaleOffset
		{
			get
			{
				return this.GetLightmapST(global::UnityEngineInternal.LightmapType.DynamicLightmap);
			}
			set
			{
				this.SetLightmapST(value, global::UnityEngineInternal.LightmapType.DynamicLightmap);
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00006DC6 File Offset: 0x00004FC6
		public int GetMaterialCount()
		{
			return Renderer.GetMaterialCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0002A820 File Offset: 0x00028A20
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00006DD8 File Offset: 0x00004FD8
		public Il2CppReferenceArray<Material> materials
		{
			get
			{
				return this.GetMaterialArray();
			}
			set
			{
				this.SetMaterialArray(value);
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0002A838 File Offset: 0x00028A38
		public void GetMaterials(List<Material> m)
		{
			bool flag = m == null;
			if (flag)
			{
				throw new ArgumentNullException("The result material list cannot be null.", "m");
			}
			NoAllocHelpers.EnsureListElemCount<Material>(m, this.GetMaterialCount());
			this.CopyMaterialArray(NoAllocHelpers.ExtractArrayFromListT<Material>(m));
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0002A878 File Offset: 0x00028A78
		public void GetSharedMaterials(List<Material> m)
		{
			bool flag = m == null;
			if (flag)
			{
				throw new ArgumentNullException("The result material list cannot be null.", "m");
			}
			NoAllocHelpers.EnsureListElemCount<Material>(m, this.GetMaterialCount());
			this.CopySharedMaterialArray(NoAllocHelpers.ExtractArrayFromListT<Material>(m));
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00006DEE File Offset: 0x00004FEE
		public void SetStaticLightmapST_Injected(ref Vector4 st)
		{
			Renderer.SetStaticLightmapST_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref st);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00006E01 File Offset: 0x00005001
		public void get_worldToLocalMatrix_Injected(out Matrix4x4 ret)
		{
			Renderer.get_worldToLocalMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00006E14 File Offset: 0x00005014
		public void get_localToWorldMatrix_Injected(out Matrix4x4 ret)
		{
			Renderer.get_localToWorldMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00006E27 File Offset: 0x00005027
		public void GetLightmapST_Injected(global::UnityEngineInternal.LightmapType lt, out Vector4 ret)
		{
			Renderer.GetLightmapST_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), lt, out ret);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00006E3B File Offset: 0x0000503B
		public void SetLightmapST_Injected(ref Vector4 st, global::UnityEngineInternal.LightmapType lt)
		{
			Renderer.SetLightmapST_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref st, lt);
		}

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Private_Material_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Private_Void_Material_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowCastingMode_Public_get_ShadowCastingMode_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowCastingMode_Public_set_Void_ShadowCastingMode_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_set_receiveShadows_Public_set_Void_Boolean_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingGroupID_Internal_get_Int32_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingGroupOrder_Internal_get_Int32_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_GetLightmapIndex_Private_Int32_LightmapType_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_get_lightmapIndex_Public_get_Int32_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMaterialArray_Private_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_get_Material_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Public_set_Void_Material_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMaterials_Public_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly Renderer.GetMaterialArrayDelegate GetMaterialArrayDelegateField;

		// Token: 0x040005E6 RID: 1510
		private static readonly Renderer.CopyMaterialArrayDelegate CopyMaterialArrayDelegateField;

		// Token: 0x040005E7 RID: 1511
		private static readonly Renderer.CopySharedMaterialArrayDelegate CopySharedMaterialArrayDelegateField;

		// Token: 0x040005E8 RID: 1512
		private static readonly Renderer.SetMaterialArrayDelegate SetMaterialArrayDelegateField;

		// Token: 0x040005E9 RID: 1513
		private static readonly Renderer.Internal_SetPropertyBlockDelegate Internal_SetPropertyBlockDelegateField;

		// Token: 0x040005EA RID: 1514
		private static readonly Renderer.Internal_GetPropertyBlockDelegate Internal_GetPropertyBlockDelegateField;

		// Token: 0x040005EB RID: 1515
		private static readonly Renderer.Internal_SetPropertyBlockMaterialIndexDelegate Internal_SetPropertyBlockMaterialIndexDelegateField;

		// Token: 0x040005EC RID: 1516
		private static readonly Renderer.Internal_GetPropertyBlockMaterialIndexDelegate Internal_GetPropertyBlockMaterialIndexDelegateField;

		// Token: 0x040005ED RID: 1517
		private static readonly Renderer.HasPropertyBlockDelegate HasPropertyBlockDelegateField;

		// Token: 0x040005EE RID: 1518
		private static readonly Renderer.GetClosestReflectionProbesInternalDelegate GetClosestReflectionProbesInternalDelegateField;

		// Token: 0x040005EF RID: 1519
		private static readonly Renderer.get_receiveShadowsDelegate get_receiveShadowsDelegateField;

		// Token: 0x040005F0 RID: 1520
		private static readonly Renderer.get_forceRenderingOffDelegate get_forceRenderingOffDelegateField;

		// Token: 0x040005F1 RID: 1521
		private static readonly Renderer.set_forceRenderingOffDelegate set_forceRenderingOffDelegateField;

		// Token: 0x040005F2 RID: 1522
		private static readonly Renderer.get_motionVectorGenerationModeDelegate get_motionVectorGenerationModeDelegateField;

		// Token: 0x040005F3 RID: 1523
		private static readonly Renderer.set_motionVectorGenerationModeDelegate set_motionVectorGenerationModeDelegateField;

		// Token: 0x040005F4 RID: 1524
		private static readonly Renderer.get_lightProbeUsageDelegate get_lightProbeUsageDelegateField;

		// Token: 0x040005F5 RID: 1525
		private static readonly Renderer.set_lightProbeUsageDelegate set_lightProbeUsageDelegateField;

		// Token: 0x040005F6 RID: 1526
		private static readonly Renderer.get_reflectionProbeUsageDelegate get_reflectionProbeUsageDelegateField;

		// Token: 0x040005F7 RID: 1527
		private static readonly Renderer.set_reflectionProbeUsageDelegate set_reflectionProbeUsageDelegateField;

		// Token: 0x040005F8 RID: 1528
		private static readonly Renderer.get_renderingLayerMaskDelegate get_renderingLayerMaskDelegateField;

		// Token: 0x040005F9 RID: 1529
		private static readonly Renderer.set_renderingLayerMaskDelegate set_renderingLayerMaskDelegateField;

		// Token: 0x040005FA RID: 1530
		private static readonly Renderer.get_rendererPriorityDelegate get_rendererPriorityDelegateField;

		// Token: 0x040005FB RID: 1531
		private static readonly Renderer.set_rendererPriorityDelegate set_rendererPriorityDelegateField;

		// Token: 0x040005FC RID: 1532
		private static readonly Renderer.get_rayTracingModeDelegate get_rayTracingModeDelegateField;

		// Token: 0x040005FD RID: 1533
		private static readonly Renderer.set_rayTracingModeDelegate set_rayTracingModeDelegateField;

		// Token: 0x040005FE RID: 1534
		private static readonly Renderer.get_sortingLayerNameDelegate get_sortingLayerNameDelegateField;

		// Token: 0x040005FF RID: 1535
		private static readonly Renderer.set_sortingGroupIDDelegate set_sortingGroupIDDelegateField;

		// Token: 0x04000600 RID: 1536
		private static readonly Renderer.set_sortingGroupOrderDelegate set_sortingGroupOrderDelegateField;

		// Token: 0x04000601 RID: 1537
		private static readonly Renderer.get_allowOcclusionWhenDynamicDelegate get_allowOcclusionWhenDynamicDelegateField;

		// Token: 0x04000602 RID: 1538
		private static readonly Renderer.set_allowOcclusionWhenDynamicDelegate set_allowOcclusionWhenDynamicDelegateField;

		// Token: 0x04000603 RID: 1539
		private static readonly Renderer.get_staticBatchRootTransformDelegate get_staticBatchRootTransformDelegateField;

		// Token: 0x04000604 RID: 1540
		private static readonly Renderer.set_staticBatchRootTransformDelegate set_staticBatchRootTransformDelegateField;

		// Token: 0x04000605 RID: 1541
		private static readonly Renderer.get_staticBatchIndexDelegate get_staticBatchIndexDelegateField;

		// Token: 0x04000606 RID: 1542
		private static readonly Renderer.SetStaticBatchInfoDelegate SetStaticBatchInfoDelegateField;

		// Token: 0x04000607 RID: 1543
		private static readonly Renderer.get_isPartOfStaticBatchDelegate get_isPartOfStaticBatchDelegateField;

		// Token: 0x04000608 RID: 1544
		private static readonly Renderer.get_lightProbeProxyVolumeOverrideDelegate get_lightProbeProxyVolumeOverrideDelegateField;

		// Token: 0x04000609 RID: 1545
		private static readonly Renderer.set_lightProbeProxyVolumeOverrideDelegate set_lightProbeProxyVolumeOverrideDelegateField;

		// Token: 0x0400060A RID: 1546
		private static readonly Renderer.get_probeAnchorDelegate get_probeAnchorDelegateField;

		// Token: 0x0400060B RID: 1547
		private static readonly Renderer.set_probeAnchorDelegate set_probeAnchorDelegateField;

		// Token: 0x0400060C RID: 1548
		private static readonly Renderer.SetLightmapIndexDelegate SetLightmapIndexDelegateField;

		// Token: 0x0400060D RID: 1549
		private static readonly Renderer.GetMaterialCountDelegate GetMaterialCountDelegateField;

		// Token: 0x0400060E RID: 1550
		private static readonly Renderer.SetStaticLightmapST_InjectedDelegate SetStaticLightmapST_InjectedDelegateField;

		// Token: 0x0400060F RID: 1551
		private static readonly Renderer.get_worldToLocalMatrix_InjectedDelegate get_worldToLocalMatrix_InjectedDelegateField;

		// Token: 0x04000610 RID: 1552
		private static readonly Renderer.get_localToWorldMatrix_InjectedDelegate get_localToWorldMatrix_InjectedDelegateField;

		// Token: 0x04000611 RID: 1553
		private static readonly Renderer.GetLightmapST_InjectedDelegate GetLightmapST_InjectedDelegateField;

		// Token: 0x04000612 RID: 1554
		private static readonly Renderer.SetLightmapST_InjectedDelegate SetLightmapST_InjectedDelegateField;

		// Token: 0x02000549 RID: 1353
		// (Invoke) Token: 0x060028C8 RID: 10440
		private delegate IntPtr GetMaterialArrayDelegate(IntPtr @this);

		// Token: 0x0200054A RID: 1354
		// (Invoke) Token: 0x060028CA RID: 10442
		private delegate void CopyMaterialArrayDelegate(IntPtr @this, [Out] IntPtr m);

		// Token: 0x0200054B RID: 1355
		// (Invoke) Token: 0x060028CC RID: 10444
		private delegate void CopySharedMaterialArrayDelegate(IntPtr @this, [Out] IntPtr m);

		// Token: 0x0200054C RID: 1356
		// (Invoke) Token: 0x060028CE RID: 10446
		private delegate void SetMaterialArrayDelegate(IntPtr @this, IntPtr m);

		// Token: 0x0200054D RID: 1357
		// (Invoke) Token: 0x060028D0 RID: 10448
		private delegate void Internal_SetPropertyBlockDelegate(IntPtr @this, IntPtr properties);

		// Token: 0x0200054E RID: 1358
		// (Invoke) Token: 0x060028D2 RID: 10450
		private delegate void Internal_GetPropertyBlockDelegate(IntPtr @this, IntPtr dest);

		// Token: 0x0200054F RID: 1359
		// (Invoke) Token: 0x060028D4 RID: 10452
		private delegate void Internal_SetPropertyBlockMaterialIndexDelegate(IntPtr @this, IntPtr properties, int materialIndex);

		// Token: 0x02000550 RID: 1360
		// (Invoke) Token: 0x060028D6 RID: 10454
		private delegate void Internal_GetPropertyBlockMaterialIndexDelegate(IntPtr @this, IntPtr dest, int materialIndex);

		// Token: 0x02000551 RID: 1361
		// (Invoke) Token: 0x060028D8 RID: 10456
		private delegate bool HasPropertyBlockDelegate(IntPtr @this);

		// Token: 0x02000552 RID: 1362
		// (Invoke) Token: 0x060028DA RID: 10458
		private delegate void GetClosestReflectionProbesInternalDelegate(IntPtr @this, IntPtr result);

		// Token: 0x02000553 RID: 1363
		// (Invoke) Token: 0x060028DC RID: 10460
		private delegate bool get_receiveShadowsDelegate(IntPtr @this);

		// Token: 0x02000554 RID: 1364
		// (Invoke) Token: 0x060028DE RID: 10462
		private delegate bool get_forceRenderingOffDelegate(IntPtr @this);

		// Token: 0x02000555 RID: 1365
		// (Invoke) Token: 0x060028E0 RID: 10464
		private delegate void set_forceRenderingOffDelegate(IntPtr @this, bool value);

		// Token: 0x02000556 RID: 1366
		// (Invoke) Token: 0x060028E2 RID: 10466
		private delegate MotionVectorGenerationMode get_motionVectorGenerationModeDelegate(IntPtr @this);

		// Token: 0x02000557 RID: 1367
		// (Invoke) Token: 0x060028E4 RID: 10468
		private delegate void set_motionVectorGenerationModeDelegate(IntPtr @this, MotionVectorGenerationMode value);

		// Token: 0x02000558 RID: 1368
		// (Invoke) Token: 0x060028E6 RID: 10470
		private delegate UnityEngine.Rendering.LightProbeUsage get_lightProbeUsageDelegate(IntPtr @this);

		// Token: 0x02000559 RID: 1369
		// (Invoke) Token: 0x060028E8 RID: 10472
		private delegate void set_lightProbeUsageDelegate(IntPtr @this, UnityEngine.Rendering.LightProbeUsage value);

		// Token: 0x0200055A RID: 1370
		// (Invoke) Token: 0x060028EA RID: 10474
		private delegate UnityEngine.Rendering.ReflectionProbeUsage get_reflectionProbeUsageDelegate(IntPtr @this);

		// Token: 0x0200055B RID: 1371
		// (Invoke) Token: 0x060028EC RID: 10476
		private delegate void set_reflectionProbeUsageDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeUsage value);

		// Token: 0x0200055C RID: 1372
		// (Invoke) Token: 0x060028EE RID: 10478
		private delegate uint get_renderingLayerMaskDelegate(IntPtr @this);

		// Token: 0x0200055D RID: 1373
		// (Invoke) Token: 0x060028F0 RID: 10480
		private delegate void set_renderingLayerMaskDelegate(IntPtr @this, uint value);

		// Token: 0x0200055E RID: 1374
		// (Invoke) Token: 0x060028F2 RID: 10482
		private delegate int get_rendererPriorityDelegate(IntPtr @this);

		// Token: 0x0200055F RID: 1375
		// (Invoke) Token: 0x060028F4 RID: 10484
		private delegate void set_rendererPriorityDelegate(IntPtr @this, int value);

		// Token: 0x02000560 RID: 1376
		// (Invoke) Token: 0x060028F6 RID: 10486
		private delegate UnityEngine.Experimental.Rendering.RayTracingMode get_rayTracingModeDelegate(IntPtr @this);

		// Token: 0x02000561 RID: 1377
		// (Invoke) Token: 0x060028F8 RID: 10488
		private delegate void set_rayTracingModeDelegate(IntPtr @this, UnityEngine.Experimental.Rendering.RayTracingMode value);

		// Token: 0x02000562 RID: 1378
		// (Invoke) Token: 0x060028FA RID: 10490
		private delegate IntPtr get_sortingLayerNameDelegate(IntPtr @this);

		// Token: 0x02000563 RID: 1379
		// (Invoke) Token: 0x060028FC RID: 10492
		private delegate void set_sortingGroupIDDelegate(IntPtr @this, int value);

		// Token: 0x02000564 RID: 1380
		// (Invoke) Token: 0x060028FE RID: 10494
		private delegate void set_sortingGroupOrderDelegate(IntPtr @this, int value);

		// Token: 0x02000565 RID: 1381
		// (Invoke) Token: 0x06002900 RID: 10496
		private delegate bool get_allowOcclusionWhenDynamicDelegate(IntPtr @this);

		// Token: 0x02000566 RID: 1382
		// (Invoke) Token: 0x06002902 RID: 10498
		private delegate void set_allowOcclusionWhenDynamicDelegate(IntPtr @this, bool value);

		// Token: 0x02000567 RID: 1383
		// (Invoke) Token: 0x06002904 RID: 10500
		private delegate IntPtr get_staticBatchRootTransformDelegate(IntPtr @this);

		// Token: 0x02000568 RID: 1384
		// (Invoke) Token: 0x06002906 RID: 10502
		private delegate void set_staticBatchRootTransformDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000569 RID: 1385
		// (Invoke) Token: 0x06002908 RID: 10504
		private delegate int get_staticBatchIndexDelegate(IntPtr @this);

		// Token: 0x0200056A RID: 1386
		// (Invoke) Token: 0x0600290A RID: 10506
		private delegate void SetStaticBatchInfoDelegate(IntPtr @this, int firstSubMesh, int subMeshCount);

		// Token: 0x0200056B RID: 1387
		// (Invoke) Token: 0x0600290C RID: 10508
		private delegate bool get_isPartOfStaticBatchDelegate(IntPtr @this);

		// Token: 0x0200056C RID: 1388
		// (Invoke) Token: 0x0600290E RID: 10510
		private delegate IntPtr get_lightProbeProxyVolumeOverrideDelegate(IntPtr @this);

		// Token: 0x0200056D RID: 1389
		// (Invoke) Token: 0x06002910 RID: 10512
		private delegate void set_lightProbeProxyVolumeOverrideDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200056E RID: 1390
		// (Invoke) Token: 0x06002912 RID: 10514
		private delegate IntPtr get_probeAnchorDelegate(IntPtr @this);

		// Token: 0x0200056F RID: 1391
		// (Invoke) Token: 0x06002914 RID: 10516
		private delegate void set_probeAnchorDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000570 RID: 1392
		// (Invoke) Token: 0x06002916 RID: 10518
		private delegate void SetLightmapIndexDelegate(IntPtr @this, int index, global::UnityEngineInternal.LightmapType lt);

		// Token: 0x02000571 RID: 1393
		// (Invoke) Token: 0x06002918 RID: 10520
		private delegate int GetMaterialCountDelegate(IntPtr @this);

		// Token: 0x02000572 RID: 1394
		// (Invoke) Token: 0x0600291A RID: 10522
		private delegate void SetStaticLightmapST_InjectedDelegate(IntPtr @this, IntPtr st);

		// Token: 0x02000573 RID: 1395
		// (Invoke) Token: 0x0600291C RID: 10524
		private delegate void get_worldToLocalMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000574 RID: 1396
		// (Invoke) Token: 0x0600291E RID: 10526
		private delegate void get_localToWorldMatrix_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000575 RID: 1397
		// (Invoke) Token: 0x06002920 RID: 10528
		private delegate void GetLightmapST_InjectedDelegate(IntPtr @this, global::UnityEngineInternal.LightmapType lt, [Out] IntPtr ret);

		// Token: 0x02000576 RID: 1398
		// (Invoke) Token: 0x06002922 RID: 10530
		private delegate void SetLightmapST_InjectedDelegate(IntPtr @this, IntPtr st, global::UnityEngineInternal.LightmapType lt);
	}
}
