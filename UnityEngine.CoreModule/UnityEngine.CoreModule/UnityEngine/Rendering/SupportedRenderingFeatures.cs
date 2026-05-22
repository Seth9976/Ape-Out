using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000178 RID: 376
	public class SupportedRenderingFeatures : Object
	{
		// Token: 0x06001C8E RID: 7310 RVA: 0x00069D9C File Offset: 0x00067F9C
		// Note: this type is marked as 'beforefieldinit'.
		static SupportedRenderingFeatures()
		{
			Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SupportedRenderingFeatures");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr);
			SupportedRenderingFeatures.NativeFieldInfoPtr_s_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "s_Active");
			SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbeModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbeModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<defaultMixedLightingModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__mixedLightingModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<mixedLightingModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightmapBakeTypes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapsModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightmapsModes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__enlighten_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<enlighten>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<lightProbeProxyVolumes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__motionVectors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<motionVectors>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__receiveShadows_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<receiveShadows>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<reflectionProbes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__rendererPriority_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendererPriority>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__terrainDetailUnsupported_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<terrainDetailUnsupported>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__rendersUIOverlay_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendersUIOverlay>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesEnvironmentLighting>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesFog_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesFog>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesRealtimeReflectionProbes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesOtherLightingSettings>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<editableMaterialRenderQueue>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLODBias_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesLODBias>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesMaximumLODLevel>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__rendererProbes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<rendererProbes>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__particleSystemInstancing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<particleSystemInstancing>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<autoAmbientProbeBaking>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<autoDefaultReflectionProbeBaking>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overridesShadowmask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overridesShadowmask>k__BackingField");
			SupportedRenderingFeatures.NativeFieldInfoPtr__overrideShadowmaskMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, "<overrideShadowmaskMessage>k__BackingField");
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665863);
			SupportedRenderingFeatures.NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665864);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665865);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665866);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665867);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665868);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665869);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665870);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoAmbientProbeBaking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665871);
			SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoDefaultReflectionProbeBaking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665872);
			SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665873);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665874);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665875);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665876);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665877);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665878);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665879);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665880);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665881);
			SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665882);
			SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665883);
			SupportedRenderingFeatures.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr, 100665884);
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x0006A1A0 File Offset: 0x000683A0
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x0006A1D4 File Offset: 0x000683D4
		public unsafe static SupportedRenderingFeatures active
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 503223, RefRangeEnd = 503241, XrefRangeStart = 503211, XrefRangeEnd = 503223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SupportedRenderingFeatures>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503241, XrefRangeEnd = 503245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x0006A20C File Offset: 0x0006840C
		// (set) Token: 0x06001CDE RID: 7390 RVA: 0x0000F7B2 File Offset: 0x0000D9B2
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._defaultMixedLightingModes_k__BackingField = value;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x0006A248 File Offset: 0x00068448
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x0000F7BB File Offset: 0x0000D9BB
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._mixedLightingModes_k__BackingField = value;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x0006A284 File Offset: 0x00068484
		// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x0000F7C4 File Offset: 0x0000D9C4
		public unsafe LightmapBakeType lightmapBakeTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._lightmapBakeTypes_k__BackingField = value;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x0006A2C0 File Offset: 0x000684C0
		// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x0000F7CD File Offset: 0x0000D9CD
		public unsafe LightmapsMode lightmapsModes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._lightmapsModes_k__BackingField = value;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x0006A2FC File Offset: 0x000684FC
		// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x0000F7D6 File Offset: 0x0000D9D6
		public unsafe bool enlighten
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._enlighten_k__BackingField = value;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x0006A338 File Offset: 0x00068538
		// (set) Token: 0x06001CEF RID: 7407 RVA: 0x0000F845 File Offset: 0x0000DA45
		public unsafe bool rendersUIOverlay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._rendersUIOverlay_k__BackingField = value;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x0006A374 File Offset: 0x00068574
		// (set) Token: 0x06001D02 RID: 7426 RVA: 0x0000F8E7 File Offset: 0x0000DAE7
		public unsafe bool autoAmbientProbeBaking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoAmbientProbeBaking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._autoAmbientProbeBaking_k__BackingField = value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x0006A3B0 File Offset: 0x000685B0
		// (set) Token: 0x06001D03 RID: 7427 RVA: 0x0000F8F0 File Offset: 0x0000DAF0
		public unsafe bool autoDefaultReflectionProbeBaking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_get_autoDefaultReflectionProbeBaking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._autoDefaultReflectionProbeBaking_k__BackingField = value;
			}
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x0006A3EC File Offset: 0x000685EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503245, XrefRangeEnd = 503257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fallbackModePtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0006A420 File Offset: 0x00068620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503257, XrefRangeEnd = 503268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mixedMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0006A460 File Offset: 0x00068660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503268, XrefRangeEnd = 503275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mixedMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0006A4A0 File Offset: 0x000686A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 503292, RefRangeEnd = 503296, XrefRangeStart = 503275, XrefRangeEnd = 503292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bakeType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0006A4E0 File Offset: 0x000686E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503296, XrefRangeEnd = 503309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bakeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0006A520 File Offset: 0x00068720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503309, XrefRangeEnd = 503313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0006A560 File Offset: 0x00068760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503313, XrefRangeEnd = 503317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lightmapper;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSupportedPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0006A5A0 File Offset: 0x000687A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503317, XrefRangeEnd = 503321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isSupportedPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x0006A5D4 File Offset: 0x000687D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503321, XrefRangeEnd = 503325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isSupportedPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0006A608 File Offset: 0x00068808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503325, XrefRangeEnd = 503329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isSupportedPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_IsAutoDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0006A63C File Offset: 0x0006883C
		[CallerCount(0)]
		public unsafe static void FallbackLightmapperByRef(IntPtr lightmapperPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lightmapperPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0006A670 File Offset: 0x00068870
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 503331, RefRangeEnd = 503333, XrefRangeStart = 503329, XrefRangeEnd = 503331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupportedRenderingFeatures()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupportedRenderingFeatures>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupportedRenderingFeatures.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
		public SupportedRenderingFeatures(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x0006A6AC File Offset: 0x000688AC
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x0000F4CD File Offset: 0x0000D6CD
		public unsafe static SupportedRenderingFeatures s_Active
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SupportedRenderingFeatures.NativeFieldInfoPtr_s_Active, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SupportedRenderingFeatures>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SupportedRenderingFeatures.NativeFieldInfoPtr_s_Active, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x0006A6D4 File Offset: 0x000688D4
		// (set) Token: 0x06001CA9 RID: 7337 RVA: 0x0000F4DF File Offset: 0x0000D6DF
		public unsafe SupportedRenderingFeatures.ReflectionProbeModes _reflectionProbeModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbeModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbeModes_k__BackingField)) = value;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x0006A6FC File Offset: 0x000688FC
		// (set) Token: 0x06001CAB RID: 7339 RVA: 0x0000F4FA File Offset: 0x0000D6FA
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes _defaultMixedLightingModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField)) = value;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x0006A724 File Offset: 0x00068924
		// (set) Token: 0x06001CAD RID: 7341 RVA: 0x0000F515 File Offset: 0x0000D715
		public unsafe SupportedRenderingFeatures.LightmapMixedBakeModes _mixedLightingModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__mixedLightingModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__mixedLightingModes_k__BackingField)) = value;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x0006A74C File Offset: 0x0006894C
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x0000F530 File Offset: 0x0000D730
		public unsafe LightmapBakeType _lightmapBakeTypes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField)) = value;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x0006A774 File Offset: 0x00068974
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x0000F54B File Offset: 0x0000D74B
		public unsafe LightmapsMode _lightmapsModes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapsModes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightmapsModes_k__BackingField)) = value;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x0006A79C File Offset: 0x0006899C
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x0000F566 File Offset: 0x0000D766
		public unsafe bool _enlighten_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlighten_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__enlighten_k__BackingField)) = value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x0006A7C4 File Offset: 0x000689C4
		// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x0000F581 File Offset: 0x0000D781
		public unsafe bool _lightProbeProxyVolumes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField)) = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x0006A7EC File Offset: 0x000689EC
		// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x0000F59C File Offset: 0x0000D79C
		public unsafe bool _motionVectors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__motionVectors_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__motionVectors_k__BackingField)) = value;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x0006A814 File Offset: 0x00068A14
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x0000F5B7 File Offset: 0x0000D7B7
		public unsafe bool _receiveShadows_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__receiveShadows_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__receiveShadows_k__BackingField)) = value;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x0006A83C File Offset: 0x00068A3C
		// (set) Token: 0x06001CBB RID: 7355 RVA: 0x0000F5D2 File Offset: 0x0000D7D2
		public unsafe bool _reflectionProbes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__reflectionProbes_k__BackingField)) = value;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x0006A864 File Offset: 0x00068A64
		// (set) Token: 0x06001CBD RID: 7357 RVA: 0x0000F5ED File Offset: 0x0000D7ED
		public unsafe bool _rendererPriority_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererPriority_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererPriority_k__BackingField)) = value;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x0006A88C File Offset: 0x00068A8C
		// (set) Token: 0x06001CBF RID: 7359 RVA: 0x0000F608 File Offset: 0x0000D808
		public unsafe bool _terrainDetailUnsupported_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__terrainDetailUnsupported_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__terrainDetailUnsupported_k__BackingField)) = value;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x0006A8B4 File Offset: 0x00068AB4
		// (set) Token: 0x06001CC1 RID: 7361 RVA: 0x0000F623 File Offset: 0x0000D823
		public unsafe bool _rendersUIOverlay_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendersUIOverlay_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendersUIOverlay_k__BackingField)) = value;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x0006A8DC File Offset: 0x00068ADC
		// (set) Token: 0x06001CC3 RID: 7363 RVA: 0x0000F63E File Offset: 0x0000D83E
		public unsafe bool _overridesEnvironmentLighting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField)) = value;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x0006A904 File Offset: 0x00068B04
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x0000F659 File Offset: 0x0000D859
		public unsafe bool _overridesFog_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesFog_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesFog_k__BackingField)) = value;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x0006A92C File Offset: 0x00068B2C
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x0000F674 File Offset: 0x0000D874
		public unsafe bool _overridesRealtimeReflectionProbes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField)) = value;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x0006A954 File Offset: 0x00068B54
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x0000F68F File Offset: 0x0000D88F
		public unsafe bool _overridesOtherLightingSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField)) = value;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x0006A97C File Offset: 0x00068B7C
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x0000F6AA File Offset: 0x0000D8AA
		public unsafe bool _editableMaterialRenderQueue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField)) = value;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x0006A9A4 File Offset: 0x00068BA4
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x0000F6C5 File Offset: 0x0000D8C5
		public unsafe bool _overridesLODBias_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLODBias_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesLODBias_k__BackingField)) = value;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x0006A9CC File Offset: 0x00068BCC
		// (set) Token: 0x06001CCF RID: 7375 RVA: 0x0000F6E0 File Offset: 0x0000D8E0
		public unsafe bool _overridesMaximumLODLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x0006A9F4 File Offset: 0x00068BF4
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x0000F6FB File Offset: 0x0000D8FB
		public unsafe bool _rendererProbes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererProbes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__rendererProbes_k__BackingField)) = value;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x0006AA1C File Offset: 0x00068C1C
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x0000F716 File Offset: 0x0000D916
		public unsafe bool _particleSystemInstancing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__particleSystemInstancing_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__particleSystemInstancing_k__BackingField)) = value;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x0006AA44 File Offset: 0x00068C44
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x0000F731 File Offset: 0x0000D931
		public unsafe bool _autoAmbientProbeBaking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField)) = value;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x0006AA6C File Offset: 0x00068C6C
		// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x0000F74C File Offset: 0x0000D94C
		public unsafe bool _autoDefaultReflectionProbeBaking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField)) = value;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x0006AA94 File Offset: 0x00068C94
		// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x0000F767 File Offset: 0x0000D967
		public unsafe bool _overridesShadowmask_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesShadowmask_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overridesShadowmask_k__BackingField)) = value;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x0006AABC File Offset: 0x00068CBC
		// (set) Token: 0x06001CDB RID: 7387 RVA: 0x0000F782 File Offset: 0x0000D982
		public unsafe string _overrideShadowmaskMessage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overrideShadowmaskMessage_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupportedRenderingFeatures.NativeFieldInfoPtr__overrideShadowmaskMessage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x0000F7A1 File Offset: 0x0000D9A1
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x0000F7A9 File Offset: 0x0000D9A9
		public SupportedRenderingFeatures.ReflectionProbeModes reflectionProbeModes
		{
			get
			{
				return this._reflectionProbeModes_k__BackingField;
			}
			set
			{
				this._reflectionProbeModes_k__BackingField = value;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x0000F7DF File Offset: 0x0000D9DF
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x0000F7E7 File Offset: 0x0000D9E7
		public bool lightProbeProxyVolumes
		{
			get
			{
				return this._lightProbeProxyVolumes_k__BackingField;
			}
			set
			{
				this._lightProbeProxyVolumes_k__BackingField = value;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x0000F7F0 File Offset: 0x0000D9F0
		// (set) Token: 0x06001CE6 RID: 7398 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		public bool motionVectors
		{
			get
			{
				return this._motionVectors_k__BackingField;
			}
			set
			{
				this._motionVectors_k__BackingField = value;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x0000F801 File Offset: 0x0000DA01
		// (set) Token: 0x06001CE8 RID: 7400 RVA: 0x0000F809 File Offset: 0x0000DA09
		public bool receiveShadows
		{
			get
			{
				return this._receiveShadows_k__BackingField;
			}
			set
			{
				this._receiveShadows_k__BackingField = value;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x0000F812 File Offset: 0x0000DA12
		// (set) Token: 0x06001CEA RID: 7402 RVA: 0x0000F81A File Offset: 0x0000DA1A
		public bool reflectionProbes
		{
			get
			{
				return this._reflectionProbes_k__BackingField;
			}
			set
			{
				this._reflectionProbes_k__BackingField = value;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x0000F823 File Offset: 0x0000DA23
		// (set) Token: 0x06001CEC RID: 7404 RVA: 0x0000F82B File Offset: 0x0000DA2B
		public bool rendererPriority
		{
			get
			{
				return this._rendererPriority_k__BackingField;
			}
			set
			{
				this._rendererPriority_k__BackingField = value;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x0000F834 File Offset: 0x0000DA34
		// (set) Token: 0x06001CEE RID: 7406 RVA: 0x0000F83C File Offset: 0x0000DA3C
		public bool terrainDetailUnsupported
		{
			get
			{
				return this._terrainDetailUnsupported_k__BackingField;
			}
			set
			{
				this._terrainDetailUnsupported_k__BackingField = value;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x0000F84E File Offset: 0x0000DA4E
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x0000F856 File Offset: 0x0000DA56
		public bool overridesEnvironmentLighting
		{
			get
			{
				return this._overridesEnvironmentLighting_k__BackingField;
			}
			set
			{
				this._overridesEnvironmentLighting_k__BackingField = value;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x0000F85F File Offset: 0x0000DA5F
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x0000F867 File Offset: 0x0000DA67
		public bool overridesFog
		{
			get
			{
				return this._overridesFog_k__BackingField;
			}
			set
			{
				this._overridesFog_k__BackingField = value;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x0000F870 File Offset: 0x0000DA70
		// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x0000F878 File Offset: 0x0000DA78
		public bool overridesRealtimeReflectionProbes
		{
			get
			{
				return this._overridesRealtimeReflectionProbes_k__BackingField;
			}
			set
			{
				this._overridesRealtimeReflectionProbes_k__BackingField = value;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x0000F881 File Offset: 0x0000DA81
		// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x0000F889 File Offset: 0x0000DA89
		public bool overridesOtherLightingSettings
		{
			get
			{
				return this._overridesOtherLightingSettings_k__BackingField;
			}
			set
			{
				this._overridesOtherLightingSettings_k__BackingField = value;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x0000F892 File Offset: 0x0000DA92
		// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x0000F89A File Offset: 0x0000DA9A
		public bool editableMaterialRenderQueue
		{
			get
			{
				return this._editableMaterialRenderQueue_k__BackingField;
			}
			set
			{
				this._editableMaterialRenderQueue_k__BackingField = value;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x0000F8A3 File Offset: 0x0000DAA3
		// (set) Token: 0x06001CFB RID: 7419 RVA: 0x0000F8AB File Offset: 0x0000DAAB
		public bool overridesLODBias
		{
			get
			{
				return this._overridesLODBias_k__BackingField;
			}
			set
			{
				this._overridesLODBias_k__BackingField = value;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x0000F8B4 File Offset: 0x0000DAB4
		// (set) Token: 0x06001CFD RID: 7421 RVA: 0x0000F8BC File Offset: 0x0000DABC
		public bool overridesMaximumLODLevel
		{
			get
			{
				return this._overridesMaximumLODLevel_k__BackingField;
			}
			set
			{
				this._overridesMaximumLODLevel_k__BackingField = value;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x0000F8C5 File Offset: 0x0000DAC5
		// (set) Token: 0x06001CFF RID: 7423 RVA: 0x0000F8CD File Offset: 0x0000DACD
		public bool rendererProbes
		{
			get
			{
				return this._rendererProbes_k__BackingField;
			}
			set
			{
				this._rendererProbes_k__BackingField = value;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x0000F8D6 File Offset: 0x0000DAD6
		// (set) Token: 0x06001D01 RID: 7425 RVA: 0x0000F8DE File Offset: 0x0000DADE
		public bool particleSystemInstancing
		{
			get
			{
				return this._particleSystemInstancing_k__BackingField;
			}
			set
			{
				this._particleSystemInstancing_k__BackingField = value;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x0000F8F9 File Offset: 0x0000DAF9
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x0000F901 File Offset: 0x0000DB01
		public bool overridesShadowmask
		{
			get
			{
				return this._overridesShadowmask_k__BackingField;
			}
			set
			{
				this._overridesShadowmask_k__BackingField = value;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x0000F90A File Offset: 0x0000DB0A
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x0000F912 File Offset: 0x0000DB12
		public string overrideShadowmaskMessage
		{
			get
			{
				return this._overrideShadowmaskMessage_k__BackingField;
			}
			set
			{
				this._overrideShadowmaskMessage_k__BackingField = value;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x0006AAE4 File Offset: 0x00068CE4
		public string shadowmaskMessage
		{
			get
			{
				bool flag = !this.overridesShadowmask;
				string text;
				if (flag)
				{
					text = "The Shadowmask Mode used at run time can be set in the Quality Settings panel.";
				}
				else
				{
					text = this.overrideShadowmaskMessage;
				}
				return text;
			}
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x0006AB14 File Offset: 0x00068D14
		public unsafe static MixedLightingMode FallbackMixedLightingMode()
		{
			MixedLightingMode mixedLightingMode;
			SupportedRenderingFeatures.FallbackMixedLightingModeByRef(new IntPtr((void*)(&mixedLightingMode)));
			return mixedLightingMode;
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x0006AB38 File Offset: 0x00068D38
		public unsafe static bool IsLightmapsModeSupported(LightmapsMode mode)
		{
			bool flag;
			SupportedRenderingFeatures.IsLightmapsModeSupportedByRef(mode, new IntPtr((void*)(&flag)));
			return flag;
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x0006AB5C File Offset: 0x00068D5C
		public unsafe static bool IsLightmapperSupported(int lightmapper)
		{
			bool flag;
			SupportedRenderingFeatures.IsLightmapperSupportedByRef(lightmapper, new IntPtr((void*)(&flag)));
			return flag;
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x0006AB80 File Offset: 0x00068D80
		public unsafe static int FallbackLightmapper()
		{
			int num;
			SupportedRenderingFeatures.FallbackLightmapperByRef(new IntPtr((void*)(&num)));
			return num;
		}

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeFieldInfoPtr_s_Active;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeFieldInfoPtr__reflectionProbeModes_k__BackingField;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeFieldInfoPtr__defaultMixedLightingModes_k__BackingField;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeFieldInfoPtr__mixedLightingModes_k__BackingField;

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeFieldInfoPtr__lightmapBakeTypes_k__BackingField;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeFieldInfoPtr__lightmapsModes_k__BackingField;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeFieldInfoPtr__enlighten_k__BackingField;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeFieldInfoPtr__lightProbeProxyVolumes_k__BackingField;

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeFieldInfoPtr__motionVectors_k__BackingField;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeFieldInfoPtr__receiveShadows_k__BackingField;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeFieldInfoPtr__reflectionProbes_k__BackingField;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeFieldInfoPtr__rendererPriority_k__BackingField;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeFieldInfoPtr__terrainDetailUnsupported_k__BackingField;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeFieldInfoPtr__rendersUIOverlay_k__BackingField;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeFieldInfoPtr__overridesEnvironmentLighting_k__BackingField;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeFieldInfoPtr__overridesFog_k__BackingField;

		// Token: 0x04001621 RID: 5665
		private static readonly IntPtr NativeFieldInfoPtr__overridesRealtimeReflectionProbes_k__BackingField;

		// Token: 0x04001622 RID: 5666
		private static readonly IntPtr NativeFieldInfoPtr__overridesOtherLightingSettings_k__BackingField;

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeFieldInfoPtr__editableMaterialRenderQueue_k__BackingField;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeFieldInfoPtr__overridesLODBias_k__BackingField;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeFieldInfoPtr__overridesMaximumLODLevel_k__BackingField;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeFieldInfoPtr__rendererProbes_k__BackingField;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeFieldInfoPtr__particleSystemInstancing_k__BackingField;

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeFieldInfoPtr__autoAmbientProbeBaking_k__BackingField;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeFieldInfoPtr__autoDefaultReflectionProbeBaking_k__BackingField;

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeFieldInfoPtr__overridesShadowmask_k__BackingField;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeFieldInfoPtr__overrideShadowmaskMessage_k__BackingField;

		// Token: 0x0400162C RID: 5676
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Static_get_SupportedRenderingFeatures_0;

		// Token: 0x0400162D RID: 5677
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Public_Static_set_Void_SupportedRenderingFeatures_0;

		// Token: 0x0400162E RID: 5678
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultMixedLightingModes_Public_get_LightmapMixedBakeModes_0;

		// Token: 0x0400162F RID: 5679
		private static readonly IntPtr NativeMethodInfoPtr_get_mixedLightingModes_Public_get_LightmapMixedBakeModes_0;

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeMethodInfoPtr_get_lightmapBakeTypes_Public_get_LightmapBakeType_0;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeMethodInfoPtr_get_lightmapsModes_Public_get_LightmapsMode_0;

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeMethodInfoPtr_get_enlighten_Public_get_Boolean_0;

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeMethodInfoPtr_get_rendersUIOverlay_Public_get_Boolean_0;

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeMethodInfoPtr_get_autoAmbientProbeBaking_Public_get_Boolean_0;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeMethodInfoPtr_get_autoDefaultReflectionProbeBaking_Public_get_Boolean_0;

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeMethodInfoPtr_FallbackMixedLightingModeByRef_Internal_Static_Void_IntPtr_0;

		// Token: 0x04001637 RID: 5687
		private static readonly IntPtr NativeMethodInfoPtr_IsMixedLightingModeSupported_Internal_Static_Boolean_MixedLightingMode_0;

		// Token: 0x04001638 RID: 5688
		private static readonly IntPtr NativeMethodInfoPtr_IsMixedLightingModeSupportedByRef_Internal_Static_Void_MixedLightingMode_IntPtr_0;

		// Token: 0x04001639 RID: 5689
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapBakeTypeSupported_Internal_Static_Boolean_LightmapBakeType_0;

		// Token: 0x0400163A RID: 5690
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapBakeTypeSupportedByRef_Internal_Static_Void_LightmapBakeType_IntPtr_0;

		// Token: 0x0400163B RID: 5691
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapsModeSupportedByRef_Internal_Static_Void_LightmapsMode_IntPtr_0;

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeMethodInfoPtr_IsLightmapperSupportedByRef_Internal_Static_Void_Int32_IntPtr_0;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeMethodInfoPtr_IsUIOverlayRenderedBySRP_Internal_Static_Void_IntPtr_0;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeMethodInfoPtr_IsAutoAmbientProbeBakingSupported_Internal_Static_Void_IntPtr_0;

		// Token: 0x0400163F RID: 5695
		private static readonly IntPtr NativeMethodInfoPtr_IsAutoDefaultReflectionProbeBakingSupported_Internal_Static_Void_IntPtr_0;

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeMethodInfoPtr_FallbackLightmapperByRef_Internal_Static_Void_IntPtr_0;

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009E9 RID: 2537
		[OriginalName("UnityEngine.CoreModule.dll", "", "ReflectionProbeModes")]
		[Flags]
		public enum ReflectionProbeModes
		{
			// Token: 0x04001FC7 RID: 8135
			None = 0,
			// Token: 0x04001FC8 RID: 8136
			Rotation = 1
		}

		// Token: 0x020009EA RID: 2538
		[OriginalName("UnityEngine.CoreModule.dll", "", "LightmapMixedBakeModes")]
		[Flags]
		public enum LightmapMixedBakeModes
		{
			// Token: 0x04001FCA RID: 8138
			None = 0,
			// Token: 0x04001FCB RID: 8139
			IndirectOnly = 1,
			// Token: 0x04001FCC RID: 8140
			Subtractive = 2,
			// Token: 0x04001FCD RID: 8141
			Shadowmask = 4
		}
	}
}
