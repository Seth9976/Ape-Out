using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000074 RID: 116
	public sealed class Light : Behaviour
	{
		// Token: 0x06000A7B RID: 2683 RVA: 0x0002E6DC File Offset: 0x0002C8DC
		// Note: this type is marked as 'beforefieldinit'.
		static Light()
		{
			Il2CppClassPointerStore<Light>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Light");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Light>.NativeClassPtr);
			Light.NativeFieldInfoPtr_m_BakedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Light>.NativeClassPtr, "m_BakedIndex");
			Light.NativeMethodInfoPtr_get_type_Public_get_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664001);
			Light.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664002);
			Light.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664003);
			Light.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664004);
			Light.NativeMethodInfoPtr_get_intensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664005);
			Light.NativeMethodInfoPtr_set_intensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664006);
			Light.NativeMethodInfoPtr_get_bounceIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664007);
			Light.NativeMethodInfoPtr_get_range_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664008);
			Light.NativeMethodInfoPtr_get_bakingOutput_Public_get_LightBakingOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664009);
			Light.NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664010);
			Light.NativeMethodInfoPtr_get_shadows_Public_get_LightShadows_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664011);
			Light.NativeMethodInfoPtr_get_shadowStrength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664012);
			Light.NativeMethodInfoPtr_set_shadowStrength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664013);
			Light.NativeMethodInfoPtr_get_cookieSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664014);
			Light.NativeMethodInfoPtr_get_cookie_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664015);
			Light.NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664016);
			Light.NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664017);
			Light.NativeMethodInfoPtr_get_bakingOutput_Injected_Private_Void_byref_LightBakingOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Light>.NativeClassPtr, 100664018);
			Light.set_typeDelegateField = IL2CPP.ResolveICall<Light.set_typeDelegate>("UnityEngine.Light::set_type");
			Light.get_shapeDelegateField = IL2CPP.ResolveICall<Light.get_shapeDelegate>("UnityEngine.Light::get_shape");
			Light.set_shapeDelegateField = IL2CPP.ResolveICall<Light.set_shapeDelegate>("UnityEngine.Light::set_shape");
			Light.set_spotAngleDelegateField = IL2CPP.ResolveICall<Light.set_spotAngleDelegate>("UnityEngine.Light::set_spotAngle");
			Light.get_innerSpotAngleDelegateField = IL2CPP.ResolveICall<Light.get_innerSpotAngleDelegate>("UnityEngine.Light::get_innerSpotAngle");
			Light.set_innerSpotAngleDelegateField = IL2CPP.ResolveICall<Light.set_innerSpotAngleDelegate>("UnityEngine.Light::set_innerSpotAngle");
			Light.get_colorTemperatureDelegateField = IL2CPP.ResolveICall<Light.get_colorTemperatureDelegate>("UnityEngine.Light::get_colorTemperature");
			Light.set_colorTemperatureDelegateField = IL2CPP.ResolveICall<Light.set_colorTemperatureDelegate>("UnityEngine.Light::set_colorTemperature");
			Light.get_useColorTemperatureDelegateField = IL2CPP.ResolveICall<Light.get_useColorTemperatureDelegate>("UnityEngine.Light::get_useColorTemperature");
			Light.set_useColorTemperatureDelegateField = IL2CPP.ResolveICall<Light.set_useColorTemperatureDelegate>("UnityEngine.Light::set_useColorTemperature");
			Light.set_bounceIntensityDelegateField = IL2CPP.ResolveICall<Light.set_bounceIntensityDelegate>("UnityEngine.Light::set_bounceIntensity");
			Light.get_useBoundingSphereOverrideDelegateField = IL2CPP.ResolveICall<Light.get_useBoundingSphereOverrideDelegate>("UnityEngine.Light::get_useBoundingSphereOverride");
			Light.set_useBoundingSphereOverrideDelegateField = IL2CPP.ResolveICall<Light.set_useBoundingSphereOverrideDelegate>("UnityEngine.Light::set_useBoundingSphereOverride");
			Light.get_useViewFrustumForShadowCasterCullDelegateField = IL2CPP.ResolveICall<Light.get_useViewFrustumForShadowCasterCullDelegate>("UnityEngine.Light::get_useViewFrustumForShadowCasterCull");
			Light.set_useViewFrustumForShadowCasterCullDelegateField = IL2CPP.ResolveICall<Light.set_useViewFrustumForShadowCasterCullDelegate>("UnityEngine.Light::set_useViewFrustumForShadowCasterCull");
			Light.get_shadowCustomResolutionDelegateField = IL2CPP.ResolveICall<Light.get_shadowCustomResolutionDelegate>("UnityEngine.Light::get_shadowCustomResolution");
			Light.set_shadowCustomResolutionDelegateField = IL2CPP.ResolveICall<Light.set_shadowCustomResolutionDelegate>("UnityEngine.Light::set_shadowCustomResolution");
			Light.get_shadowBiasDelegateField = IL2CPP.ResolveICall<Light.get_shadowBiasDelegate>("UnityEngine.Light::get_shadowBias");
			Light.set_shadowBiasDelegateField = IL2CPP.ResolveICall<Light.set_shadowBiasDelegate>("UnityEngine.Light::set_shadowBias");
			Light.get_shadowNormalBiasDelegateField = IL2CPP.ResolveICall<Light.get_shadowNormalBiasDelegate>("UnityEngine.Light::get_shadowNormalBias");
			Light.set_shadowNormalBiasDelegateField = IL2CPP.ResolveICall<Light.set_shadowNormalBiasDelegate>("UnityEngine.Light::set_shadowNormalBias");
			Light.get_shadowNearPlaneDelegateField = IL2CPP.ResolveICall<Light.get_shadowNearPlaneDelegate>("UnityEngine.Light::get_shadowNearPlane");
			Light.set_shadowNearPlaneDelegateField = IL2CPP.ResolveICall<Light.set_shadowNearPlaneDelegate>("UnityEngine.Light::set_shadowNearPlane");
			Light.get_useShadowMatrixOverrideDelegateField = IL2CPP.ResolveICall<Light.get_useShadowMatrixOverrideDelegate>("UnityEngine.Light::get_useShadowMatrixOverride");
			Light.set_useShadowMatrixOverrideDelegateField = IL2CPP.ResolveICall<Light.set_useShadowMatrixOverrideDelegate>("UnityEngine.Light::set_useShadowMatrixOverride");
			Light.set_rangeDelegateField = IL2CPP.ResolveICall<Light.set_rangeDelegate>("UnityEngine.Light::set_range");
			Light.get_flareDelegateField = IL2CPP.ResolveICall<Light.get_flareDelegate>("UnityEngine.Light::get_flare");
			Light.set_flareDelegateField = IL2CPP.ResolveICall<Light.set_flareDelegate>("UnityEngine.Light::set_flare");
			Light.set_cullingMaskDelegateField = IL2CPP.ResolveICall<Light.set_cullingMaskDelegate>("UnityEngine.Light::set_cullingMask");
			Light.get_renderingLayerMaskDelegateField = IL2CPP.ResolveICall<Light.get_renderingLayerMaskDelegate>("UnityEngine.Light::get_renderingLayerMask");
			Light.set_renderingLayerMaskDelegateField = IL2CPP.ResolveICall<Light.set_renderingLayerMaskDelegate>("UnityEngine.Light::set_renderingLayerMask");
			Light.get_lightShadowCasterModeDelegateField = IL2CPP.ResolveICall<Light.get_lightShadowCasterModeDelegate>("UnityEngine.Light::get_lightShadowCasterMode");
			Light.set_lightShadowCasterModeDelegateField = IL2CPP.ResolveICall<Light.set_lightShadowCasterModeDelegate>("UnityEngine.Light::set_lightShadowCasterMode");
			Light.ResetDelegateField = IL2CPP.ResolveICall<Light.ResetDelegate>("UnityEngine.Light::Reset");
			Light.set_shadowsDelegateField = IL2CPP.ResolveICall<Light.set_shadowsDelegate>("UnityEngine.Light::set_shadows");
			Light.get_shadowResolutionDelegateField = IL2CPP.ResolveICall<Light.get_shadowResolutionDelegate>("UnityEngine.Light::get_shadowResolution");
			Light.set_shadowResolutionDelegateField = IL2CPP.ResolveICall<Light.set_shadowResolutionDelegate>("UnityEngine.Light::set_shadowResolution");
			Light.get_layerShadowCullDistancesDelegateField = IL2CPP.ResolveICall<Light.get_layerShadowCullDistancesDelegate>("UnityEngine.Light::get_layerShadowCullDistances");
			Light.set_layerShadowCullDistancesDelegateField = IL2CPP.ResolveICall<Light.set_layerShadowCullDistancesDelegate>("UnityEngine.Light::set_layerShadowCullDistances");
			Light.set_cookieSizeDelegateField = IL2CPP.ResolveICall<Light.set_cookieSizeDelegate>("UnityEngine.Light::set_cookieSize");
			Light.set_cookieDelegateField = IL2CPP.ResolveICall<Light.set_cookieDelegate>("UnityEngine.Light::set_cookie");
			Light.get_renderModeDelegateField = IL2CPP.ResolveICall<Light.get_renderModeDelegate>("UnityEngine.Light::get_renderMode");
			Light.set_renderModeDelegateField = IL2CPP.ResolveICall<Light.set_renderModeDelegate>("UnityEngine.Light::set_renderMode");
			Light.AddCommandBufferDelegateField = IL2CPP.ResolveICall<Light.AddCommandBufferDelegate>("UnityEngine.Light::AddCommandBuffer");
			Light.AddCommandBufferAsyncDelegateField = IL2CPP.ResolveICall<Light.AddCommandBufferAsyncDelegate>("UnityEngine.Light::AddCommandBufferAsync");
			Light.RemoveCommandBufferDelegateField = IL2CPP.ResolveICall<Light.RemoveCommandBufferDelegate>("UnityEngine.Light::RemoveCommandBuffer");
			Light.RemoveCommandBuffersDelegateField = IL2CPP.ResolveICall<Light.RemoveCommandBuffersDelegate>("UnityEngine.Light::RemoveCommandBuffers");
			Light.RemoveAllCommandBuffersDelegateField = IL2CPP.ResolveICall<Light.RemoveAllCommandBuffersDelegate>("UnityEngine.Light::RemoveAllCommandBuffers");
			Light.GetCommandBuffersDelegateField = IL2CPP.ResolveICall<Light.GetCommandBuffersDelegate>("UnityEngine.Light::GetCommandBuffers");
			Light.get_commandBufferCountDelegateField = IL2CPP.ResolveICall<Light.get_commandBufferCountDelegate>("UnityEngine.Light::get_commandBufferCount");
			Light.GetLightsDelegateField = IL2CPP.ResolveICall<Light.GetLightsDelegate>("UnityEngine.Light::GetLights");
			Light.get_boundingSphereOverride_InjectedDelegateField = IL2CPP.ResolveICall<Light.get_boundingSphereOverride_InjectedDelegate>("UnityEngine.Light::get_boundingSphereOverride_Injected");
			Light.set_boundingSphereOverride_InjectedDelegateField = IL2CPP.ResolveICall<Light.set_boundingSphereOverride_InjectedDelegate>("UnityEngine.Light::set_boundingSphereOverride_Injected");
			Light.get_shadowMatrixOverride_InjectedDelegateField = IL2CPP.ResolveICall<Light.get_shadowMatrixOverride_InjectedDelegate>("UnityEngine.Light::get_shadowMatrixOverride_Injected");
			Light.set_shadowMatrixOverride_InjectedDelegateField = IL2CPP.ResolveICall<Light.set_shadowMatrixOverride_InjectedDelegate>("UnityEngine.Light::set_shadowMatrixOverride_Injected");
			Light.set_bakingOutput_InjectedDelegateField = IL2CPP.ResolveICall<Light.set_bakingOutput_InjectedDelegate>("UnityEngine.Light::set_bakingOutput_Injected");
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0002EBD0 File Offset: 0x0002CDD0
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x00007B3F File Offset: 0x00005D3F
		public unsafe LightType type
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 489365, RefRangeEnd = 489367, XrefRangeStart = 489361, XrefRangeEnd = 489365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_type_Public_get_LightType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_typeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0002EC0C File Offset: 0x0002CE0C
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00007B77 File Offset: 0x00005D77
		public unsafe float spotAngle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 489371, RefRangeEnd = 489372, XrefRangeStart = 489367, XrefRangeEnd = 489371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_spotAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0002EC48 File Offset: 0x0002CE48
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x0002EC84 File Offset: 0x0002CE84
		public unsafe Color color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489372, XrefRangeEnd = 489374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489374, XrefRangeEnd = 489376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0002ECC4 File Offset: 0x0002CEC4
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x0002ED00 File Offset: 0x0002CF00
		public unsafe float intensity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489376, XrefRangeEnd = 489380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_intensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489380, XrefRangeEnd = 489384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_intensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0002ED40 File Offset: 0x0002CF40
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x00007BF9 File Offset: 0x00005DF9
		public unsafe float bounceIntensity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489384, XrefRangeEnd = 489388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_bounceIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_bounceIntensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0002ED7C File Offset: 0x0002CF7C
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x00007D23 File Offset: 0x00005F23
		public unsafe float range
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 489392, RefRangeEnd = 489395, XrefRangeStart = 489388, XrefRangeEnd = 489392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_range_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_rangeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0002EDB8 File Offset: 0x0002CFB8
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x00007D4E File Offset: 0x00005F4E
		public unsafe LightBakingOutput bakingOutput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489395, XrefRangeEnd = 489397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_bakingOutput_Public_get_LightBakingOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_bakingOutput_Injected(ref value);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x0002EDF4 File Offset: 0x0002CFF4
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00007D58 File Offset: 0x00005F58
		public unsafe int cullingMask
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489397, XrefRangeEnd = 489401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_cullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0002EE30 File Offset: 0x0002D030
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00007DC7 File Offset: 0x00005FC7
		public unsafe LightShadows shadows
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 489405, RefRangeEnd = 489406, XrefRangeStart = 489401, XrefRangeEnd = 489405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadows_Public_get_LightShadows_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_shadowsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0002EE6C File Offset: 0x0002D06C
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x0002EEA8 File Offset: 0x0002D0A8
		public unsafe float shadowStrength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489406, XrefRangeEnd = 489410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_shadowStrength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489410, XrefRangeEnd = 489414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_shadowStrength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0002EEE8 File Offset: 0x0002D0E8
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00007E1D File Offset: 0x0000601D
		public unsafe float cookieSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489414, XrefRangeEnd = 489418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_cookieSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Light.set_cookieSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0002EF24 File Offset: 0x0002D124
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00007E30 File Offset: 0x00006030
		public unsafe Texture cookie
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489418, XrefRangeEnd = 489422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_cookie_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
			set
			{
				Light.set_cookieDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0002EF64 File Offset: 0x0002D164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489422, XrefRangeEnd = 489426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_color_Injected(out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0002EFA4 File Offset: 0x0002D1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489426, XrefRangeEnd = 489430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_color_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0002EFE4 File Offset: 0x0002D1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489430, XrefRangeEnd = 489434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bakingOutput_Injected(out LightBakingOutput ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Light.NativeMethodInfoPtr_get_bakingOutput_Injected_Private_Void_byref_LightBakingOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00007B1B File Offset: 0x00005D1B
		public Light(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0002F024 File Offset: 0x0002D224
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x00007B24 File Offset: 0x00005D24
		public unsafe int m_BakedIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light.NativeFieldInfoPtr_m_BakedIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Light.NativeFieldInfoPtr_m_BakedIndex)) = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x00007B52 File Offset: 0x00005D52
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x00007B64 File Offset: 0x00005D64
		public LightShape shape
		{
			get
			{
				return Light.get_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00007B8A File Offset: 0x00005D8A
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00007B9C File Offset: 0x00005D9C
		public float innerSpotAngle
		{
			get
			{
				return Light.get_innerSpotAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_innerSpotAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00007BAF File Offset: 0x00005DAF
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x00007BC1 File Offset: 0x00005DC1
		public float colorTemperature
		{
			get
			{
				return Light.get_colorTemperatureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_colorTemperatureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00007BD4 File Offset: 0x00005DD4
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x00007BE6 File Offset: 0x00005DE6
		public bool useColorTemperature
		{
			get
			{
				return Light.get_useColorTemperatureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_useColorTemperatureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00007C0C File Offset: 0x00005E0C
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x00007C1E File Offset: 0x00005E1E
		public bool useBoundingSphereOverride
		{
			get
			{
				return Light.get_useBoundingSphereOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_useBoundingSphereOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0002F04C File Offset: 0x0002D24C
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x00007C31 File Offset: 0x00005E31
		public Vector4 boundingSphereOverride
		{
			get
			{
				Vector4 vector;
				this.get_boundingSphereOverride_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_boundingSphereOverride_Injected(ref value);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x00007C3B File Offset: 0x00005E3B
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x00007C4D File Offset: 0x00005E4D
		public bool useViewFrustumForShadowCasterCull
		{
			get
			{
				return Light.get_useViewFrustumForShadowCasterCullDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_useViewFrustumForShadowCasterCullDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00007C60 File Offset: 0x00005E60
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x00007C72 File Offset: 0x00005E72
		public int shadowCustomResolution
		{
			get
			{
				return Light.get_shadowCustomResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_shadowCustomResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x00007C85 File Offset: 0x00005E85
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x00007C97 File Offset: 0x00005E97
		public float shadowBias
		{
			get
			{
				return Light.get_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_shadowBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x00007CAA File Offset: 0x00005EAA
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x00007CBC File Offset: 0x00005EBC
		public float shadowNormalBias
		{
			get
			{
				return Light.get_shadowNormalBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_shadowNormalBiasDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x00007CCF File Offset: 0x00005ECF
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x00007CE1 File Offset: 0x00005EE1
		public float shadowNearPlane
		{
			get
			{
				return Light.get_shadowNearPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_shadowNearPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x00007CF4 File Offset: 0x00005EF4
		// (set) Token: 0x06000AAB RID: 2731 RVA: 0x00007D06 File Offset: 0x00005F06
		public bool useShadowMatrixOverride
		{
			get
			{
				return Light.get_useShadowMatrixOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_useShadowMatrixOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x0002F064 File Offset: 0x0002D264
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x00007D19 File Offset: 0x00005F19
		public Matrix4x4 shadowMatrixOverride
		{
			get
			{
				Matrix4x4 matrix4x;
				this.get_shadowMatrixOverride_Injected(out matrix4x);
				return matrix4x;
			}
			set
			{
				this.set_shadowMatrixOverride_Injected(ref value);
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0002F07C File Offset: 0x0002D27C
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x00007D36 File Offset: 0x00005F36
		public Flare flare
		{
			get
			{
				IntPtr intPtr = Light.get_flareDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Flare>(intPtr2) : null;
			}
			set
			{
				Light.set_flareDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x00007D6B File Offset: 0x00005F6B
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x00007D7D File Offset: 0x00005F7D
		public int renderingLayerMask
		{
			get
			{
				return Light.get_renderingLayerMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_renderingLayerMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00007D90 File Offset: 0x00005F90
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00007DA2 File Offset: 0x00005FA2
		public LightShadowCasterMode lightShadowCasterMode
		{
			get
			{
				return Light.get_lightShadowCasterModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_lightShadowCasterModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00007DB5 File Offset: 0x00005FB5
		public void Reset()
		{
			Light.ResetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00007DDA File Offset: 0x00005FDA
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00007DEC File Offset: 0x00005FEC
		public UnityEngine.Rendering.LightShadowResolution shadowResolution
		{
			get
			{
				return Light.get_shadowResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_shadowResolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0002F0A8 File Offset: 0x0002D2A8
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00007DFF File Offset: 0x00005FFF
		public float shadowSoftness
		{
			get
			{
				return 4f;
			}
			set
			{
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0002F0C0 File Offset: 0x0002D2C0
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00007E02 File Offset: 0x00006002
		public float shadowSoftnessFade
		{
			get
			{
				return 1f;
			}
			set
			{
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0002F0D8 File Offset: 0x0002D2D8
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00007E05 File Offset: 0x00006005
		public Il2CppStructArray<float> layerShadowCullDistances
		{
			get
			{
				IntPtr intPtr = Light.get_layerShadowCullDistancesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				Light.set_layerShadowCullDistancesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00007E48 File Offset: 0x00006048
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00007E5A File Offset: 0x0000605A
		public LightRenderMode renderMode
		{
			get
			{
				return Light.get_renderModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Light.set_renderModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0002F104 File Offset: 0x0002D304
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00007E6D File Offset: 0x0000606D
		public int bakedIndex
		{
			get
			{
				return this.m_BakedIndex;
			}
			set
			{
				this.m_BakedIndex = value;
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00007E77 File Offset: 0x00006077
		public void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			this.AddCommandBuffer(evt, buffer, UnityEngine.Rendering.ShadowMapPass.All);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00007E88 File Offset: 0x00006088
		public void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask)
		{
			Light.AddCommandBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt, IL2CPP.Il2CppObjectBaseToPtr(buffer), shadowPassMask);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00007EA2 File Offset: 0x000060A2
		public void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			this.AddCommandBufferAsync(evt, buffer, UnityEngine.Rendering.ShadowMapPass.All, queueType);
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00007EB4 File Offset: 0x000060B4
		public void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			Light.AddCommandBufferAsyncDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt, IL2CPP.Il2CppObjectBaseToPtr(buffer), shadowPassMask, queueType);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00007ED0 File Offset: 0x000060D0
		public void RemoveCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			Light.RemoveCommandBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00007EE9 File Offset: 0x000060E9
		public void RemoveCommandBuffers(UnityEngine.Rendering.LightEvent evt)
		{
			Light.RemoveCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00007EFC File Offset: 0x000060FC
		public void RemoveAllCommandBuffers()
		{
			Light.RemoveAllCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0002F11C File Offset: 0x0002D31C
		public Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer> GetCommandBuffers(UnityEngine.Rendering.LightEvent evt)
		{
			IntPtr intPtr = Light.GetCommandBuffersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), evt);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer>>(intPtr2) : null;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00007F0E File Offset: 0x0000610E
		public int commandBufferCount
		{
			get
			{
				return Light.get_commandBufferCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0002F14C File Offset: 0x0002D34C
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x00007F20 File Offset: 0x00006120
		public static int pixelLightCount
		{
			get
			{
				return QualitySettings.pixelLightCount;
			}
			set
			{
				QualitySettings.pixelLightCount = value;
			}
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0002F164 File Offset: 0x0002D364
		public static Il2CppReferenceArray<Light> GetLights(LightType type, int layer)
		{
			IntPtr intPtr = Light.GetLightsDelegateField(type, layer);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light>>(intPtr2) : null;
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0002F18C File Offset: 0x0002D38C
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00007F2A File Offset: 0x0000612A
		public float shadowConstantBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0002F1A4 File Offset: 0x0002D3A4
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00007F2D File Offset: 0x0000612D
		public float shadowObjectSizeBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0002F1BC File Offset: 0x0002D3BC
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00007F30 File Offset: 0x00006130
		public bool attenuate
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00007F33 File Offset: 0x00006133
		public void get_boundingSphereOverride_Injected(out Vector4 ret)
		{
			Light.get_boundingSphereOverride_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00007F46 File Offset: 0x00006146
		public void set_boundingSphereOverride_Injected(ref Vector4 value)
		{
			Light.set_boundingSphereOverride_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00007F59 File Offset: 0x00006159
		public void get_shadowMatrixOverride_Injected(out Matrix4x4 ret)
		{
			Light.get_shadowMatrixOverride_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00007F6C File Offset: 0x0000616C
		public void set_shadowMatrixOverride_Injected(ref Matrix4x4 value)
		{
			Light.set_shadowMatrixOverride_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00007F7F File Offset: 0x0000617F
		public void set_bakingOutput_Injected(ref LightBakingOutput value)
		{
			Light.set_bakingOutput_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeFieldInfoPtr_m_BakedIndex;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_LightType_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_get_intensity_Public_get_Single_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_set_intensity_Public_set_Void_Single_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_get_bounceIntensity_Public_get_Single_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_get_range_Public_get_Single_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_get_bakingOutput_Public_get_LightBakingOutput_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_get_shadows_Public_get_LightShadows_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowStrength_Public_get_Single_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowStrength_Public_set_Void_Single_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_get_cookieSize_Public_get_Single_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_get_cookie_Public_get_Texture_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr_get_bakingOutput_Injected_Private_Void_byref_LightBakingOutput_0;

		// Token: 0x0400071C RID: 1820
		private static readonly Light.set_typeDelegate set_typeDelegateField;

		// Token: 0x0400071D RID: 1821
		private static readonly Light.get_shapeDelegate get_shapeDelegateField;

		// Token: 0x0400071E RID: 1822
		private static readonly Light.set_shapeDelegate set_shapeDelegateField;

		// Token: 0x0400071F RID: 1823
		private static readonly Light.set_spotAngleDelegate set_spotAngleDelegateField;

		// Token: 0x04000720 RID: 1824
		private static readonly Light.get_innerSpotAngleDelegate get_innerSpotAngleDelegateField;

		// Token: 0x04000721 RID: 1825
		private static readonly Light.set_innerSpotAngleDelegate set_innerSpotAngleDelegateField;

		// Token: 0x04000722 RID: 1826
		private static readonly Light.get_colorTemperatureDelegate get_colorTemperatureDelegateField;

		// Token: 0x04000723 RID: 1827
		private static readonly Light.set_colorTemperatureDelegate set_colorTemperatureDelegateField;

		// Token: 0x04000724 RID: 1828
		private static readonly Light.get_useColorTemperatureDelegate get_useColorTemperatureDelegateField;

		// Token: 0x04000725 RID: 1829
		private static readonly Light.set_useColorTemperatureDelegate set_useColorTemperatureDelegateField;

		// Token: 0x04000726 RID: 1830
		private static readonly Light.set_bounceIntensityDelegate set_bounceIntensityDelegateField;

		// Token: 0x04000727 RID: 1831
		private static readonly Light.get_useBoundingSphereOverrideDelegate get_useBoundingSphereOverrideDelegateField;

		// Token: 0x04000728 RID: 1832
		private static readonly Light.set_useBoundingSphereOverrideDelegate set_useBoundingSphereOverrideDelegateField;

		// Token: 0x04000729 RID: 1833
		private static readonly Light.get_useViewFrustumForShadowCasterCullDelegate get_useViewFrustumForShadowCasterCullDelegateField;

		// Token: 0x0400072A RID: 1834
		private static readonly Light.set_useViewFrustumForShadowCasterCullDelegate set_useViewFrustumForShadowCasterCullDelegateField;

		// Token: 0x0400072B RID: 1835
		private static readonly Light.get_shadowCustomResolutionDelegate get_shadowCustomResolutionDelegateField;

		// Token: 0x0400072C RID: 1836
		private static readonly Light.set_shadowCustomResolutionDelegate set_shadowCustomResolutionDelegateField;

		// Token: 0x0400072D RID: 1837
		private static readonly Light.get_shadowBiasDelegate get_shadowBiasDelegateField;

		// Token: 0x0400072E RID: 1838
		private static readonly Light.set_shadowBiasDelegate set_shadowBiasDelegateField;

		// Token: 0x0400072F RID: 1839
		private static readonly Light.get_shadowNormalBiasDelegate get_shadowNormalBiasDelegateField;

		// Token: 0x04000730 RID: 1840
		private static readonly Light.set_shadowNormalBiasDelegate set_shadowNormalBiasDelegateField;

		// Token: 0x04000731 RID: 1841
		private static readonly Light.get_shadowNearPlaneDelegate get_shadowNearPlaneDelegateField;

		// Token: 0x04000732 RID: 1842
		private static readonly Light.set_shadowNearPlaneDelegate set_shadowNearPlaneDelegateField;

		// Token: 0x04000733 RID: 1843
		private static readonly Light.get_useShadowMatrixOverrideDelegate get_useShadowMatrixOverrideDelegateField;

		// Token: 0x04000734 RID: 1844
		private static readonly Light.set_useShadowMatrixOverrideDelegate set_useShadowMatrixOverrideDelegateField;

		// Token: 0x04000735 RID: 1845
		private static readonly Light.set_rangeDelegate set_rangeDelegateField;

		// Token: 0x04000736 RID: 1846
		private static readonly Light.get_flareDelegate get_flareDelegateField;

		// Token: 0x04000737 RID: 1847
		private static readonly Light.set_flareDelegate set_flareDelegateField;

		// Token: 0x04000738 RID: 1848
		private static readonly Light.set_cullingMaskDelegate set_cullingMaskDelegateField;

		// Token: 0x04000739 RID: 1849
		private static readonly Light.get_renderingLayerMaskDelegate get_renderingLayerMaskDelegateField;

		// Token: 0x0400073A RID: 1850
		private static readonly Light.set_renderingLayerMaskDelegate set_renderingLayerMaskDelegateField;

		// Token: 0x0400073B RID: 1851
		private static readonly Light.get_lightShadowCasterModeDelegate get_lightShadowCasterModeDelegateField;

		// Token: 0x0400073C RID: 1852
		private static readonly Light.set_lightShadowCasterModeDelegate set_lightShadowCasterModeDelegateField;

		// Token: 0x0400073D RID: 1853
		private static readonly Light.ResetDelegate ResetDelegateField;

		// Token: 0x0400073E RID: 1854
		private static readonly Light.set_shadowsDelegate set_shadowsDelegateField;

		// Token: 0x0400073F RID: 1855
		private static readonly Light.get_shadowResolutionDelegate get_shadowResolutionDelegateField;

		// Token: 0x04000740 RID: 1856
		private static readonly Light.set_shadowResolutionDelegate set_shadowResolutionDelegateField;

		// Token: 0x04000741 RID: 1857
		private static readonly Light.get_layerShadowCullDistancesDelegate get_layerShadowCullDistancesDelegateField;

		// Token: 0x04000742 RID: 1858
		private static readonly Light.set_layerShadowCullDistancesDelegate set_layerShadowCullDistancesDelegateField;

		// Token: 0x04000743 RID: 1859
		private static readonly Light.set_cookieSizeDelegate set_cookieSizeDelegateField;

		// Token: 0x04000744 RID: 1860
		private static readonly Light.set_cookieDelegate set_cookieDelegateField;

		// Token: 0x04000745 RID: 1861
		private static readonly Light.get_renderModeDelegate get_renderModeDelegateField;

		// Token: 0x04000746 RID: 1862
		private static readonly Light.set_renderModeDelegate set_renderModeDelegateField;

		// Token: 0x04000747 RID: 1863
		private static readonly Light.AddCommandBufferDelegate AddCommandBufferDelegateField;

		// Token: 0x04000748 RID: 1864
		private static readonly Light.AddCommandBufferAsyncDelegate AddCommandBufferAsyncDelegateField;

		// Token: 0x04000749 RID: 1865
		private static readonly Light.RemoveCommandBufferDelegate RemoveCommandBufferDelegateField;

		// Token: 0x0400074A RID: 1866
		private static readonly Light.RemoveCommandBuffersDelegate RemoveCommandBuffersDelegateField;

		// Token: 0x0400074B RID: 1867
		private static readonly Light.RemoveAllCommandBuffersDelegate RemoveAllCommandBuffersDelegateField;

		// Token: 0x0400074C RID: 1868
		private static readonly Light.GetCommandBuffersDelegate GetCommandBuffersDelegateField;

		// Token: 0x0400074D RID: 1869
		private static readonly Light.get_commandBufferCountDelegate get_commandBufferCountDelegateField;

		// Token: 0x0400074E RID: 1870
		private static readonly Light.GetLightsDelegate GetLightsDelegateField;

		// Token: 0x0400074F RID: 1871
		private static readonly Light.get_boundingSphereOverride_InjectedDelegate get_boundingSphereOverride_InjectedDelegateField;

		// Token: 0x04000750 RID: 1872
		private static readonly Light.set_boundingSphereOverride_InjectedDelegate set_boundingSphereOverride_InjectedDelegateField;

		// Token: 0x04000751 RID: 1873
		private static readonly Light.get_shadowMatrixOverride_InjectedDelegate get_shadowMatrixOverride_InjectedDelegateField;

		// Token: 0x04000752 RID: 1874
		private static readonly Light.set_shadowMatrixOverride_InjectedDelegate set_shadowMatrixOverride_InjectedDelegateField;

		// Token: 0x04000753 RID: 1875
		private static readonly Light.set_bakingOutput_InjectedDelegate set_bakingOutput_InjectedDelegateField;

		// Token: 0x020005FE RID: 1534
		// (Invoke) Token: 0x06002A32 RID: 10802
		private delegate void set_typeDelegate(IntPtr @this, LightType value);

		// Token: 0x020005FF RID: 1535
		// (Invoke) Token: 0x06002A34 RID: 10804
		private delegate LightShape get_shapeDelegate(IntPtr @this);

		// Token: 0x02000600 RID: 1536
		// (Invoke) Token: 0x06002A36 RID: 10806
		private delegate void set_shapeDelegate(IntPtr @this, LightShape value);

		// Token: 0x02000601 RID: 1537
		// (Invoke) Token: 0x06002A38 RID: 10808
		private delegate void set_spotAngleDelegate(IntPtr @this, float value);

		// Token: 0x02000602 RID: 1538
		// (Invoke) Token: 0x06002A3A RID: 10810
		private delegate float get_innerSpotAngleDelegate(IntPtr @this);

		// Token: 0x02000603 RID: 1539
		// (Invoke) Token: 0x06002A3C RID: 10812
		private delegate void set_innerSpotAngleDelegate(IntPtr @this, float value);

		// Token: 0x02000604 RID: 1540
		// (Invoke) Token: 0x06002A3E RID: 10814
		private delegate float get_colorTemperatureDelegate(IntPtr @this);

		// Token: 0x02000605 RID: 1541
		// (Invoke) Token: 0x06002A40 RID: 10816
		private delegate void set_colorTemperatureDelegate(IntPtr @this, float value);

		// Token: 0x02000606 RID: 1542
		// (Invoke) Token: 0x06002A42 RID: 10818
		private delegate bool get_useColorTemperatureDelegate(IntPtr @this);

		// Token: 0x02000607 RID: 1543
		// (Invoke) Token: 0x06002A44 RID: 10820
		private delegate void set_useColorTemperatureDelegate(IntPtr @this, bool value);

		// Token: 0x02000608 RID: 1544
		// (Invoke) Token: 0x06002A46 RID: 10822
		private delegate void set_bounceIntensityDelegate(IntPtr @this, float value);

		// Token: 0x02000609 RID: 1545
		// (Invoke) Token: 0x06002A48 RID: 10824
		private delegate bool get_useBoundingSphereOverrideDelegate(IntPtr @this);

		// Token: 0x0200060A RID: 1546
		// (Invoke) Token: 0x06002A4A RID: 10826
		private delegate void set_useBoundingSphereOverrideDelegate(IntPtr @this, bool value);

		// Token: 0x0200060B RID: 1547
		// (Invoke) Token: 0x06002A4C RID: 10828
		private delegate bool get_useViewFrustumForShadowCasterCullDelegate(IntPtr @this);

		// Token: 0x0200060C RID: 1548
		// (Invoke) Token: 0x06002A4E RID: 10830
		private delegate void set_useViewFrustumForShadowCasterCullDelegate(IntPtr @this, bool value);

		// Token: 0x0200060D RID: 1549
		// (Invoke) Token: 0x06002A50 RID: 10832
		private delegate int get_shadowCustomResolutionDelegate(IntPtr @this);

		// Token: 0x0200060E RID: 1550
		// (Invoke) Token: 0x06002A52 RID: 10834
		private delegate void set_shadowCustomResolutionDelegate(IntPtr @this, int value);

		// Token: 0x0200060F RID: 1551
		// (Invoke) Token: 0x06002A54 RID: 10836
		private delegate float get_shadowBiasDelegate(IntPtr @this);

		// Token: 0x02000610 RID: 1552
		// (Invoke) Token: 0x06002A56 RID: 10838
		private delegate void set_shadowBiasDelegate(IntPtr @this, float value);

		// Token: 0x02000611 RID: 1553
		// (Invoke) Token: 0x06002A58 RID: 10840
		private delegate float get_shadowNormalBiasDelegate(IntPtr @this);

		// Token: 0x02000612 RID: 1554
		// (Invoke) Token: 0x06002A5A RID: 10842
		private delegate void set_shadowNormalBiasDelegate(IntPtr @this, float value);

		// Token: 0x02000613 RID: 1555
		// (Invoke) Token: 0x06002A5C RID: 10844
		private delegate float get_shadowNearPlaneDelegate(IntPtr @this);

		// Token: 0x02000614 RID: 1556
		// (Invoke) Token: 0x06002A5E RID: 10846
		private delegate void set_shadowNearPlaneDelegate(IntPtr @this, float value);

		// Token: 0x02000615 RID: 1557
		// (Invoke) Token: 0x06002A60 RID: 10848
		private delegate bool get_useShadowMatrixOverrideDelegate(IntPtr @this);

		// Token: 0x02000616 RID: 1558
		// (Invoke) Token: 0x06002A62 RID: 10850
		private delegate void set_useShadowMatrixOverrideDelegate(IntPtr @this, bool value);

		// Token: 0x02000617 RID: 1559
		// (Invoke) Token: 0x06002A64 RID: 10852
		private delegate void set_rangeDelegate(IntPtr @this, float value);

		// Token: 0x02000618 RID: 1560
		// (Invoke) Token: 0x06002A66 RID: 10854
		private delegate IntPtr get_flareDelegate(IntPtr @this);

		// Token: 0x02000619 RID: 1561
		// (Invoke) Token: 0x06002A68 RID: 10856
		private delegate void set_flareDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200061A RID: 1562
		// (Invoke) Token: 0x06002A6A RID: 10858
		private delegate void set_cullingMaskDelegate(IntPtr @this, int value);

		// Token: 0x0200061B RID: 1563
		// (Invoke) Token: 0x06002A6C RID: 10860
		private delegate int get_renderingLayerMaskDelegate(IntPtr @this);

		// Token: 0x0200061C RID: 1564
		// (Invoke) Token: 0x06002A6E RID: 10862
		private delegate void set_renderingLayerMaskDelegate(IntPtr @this, int value);

		// Token: 0x0200061D RID: 1565
		// (Invoke) Token: 0x06002A70 RID: 10864
		private delegate LightShadowCasterMode get_lightShadowCasterModeDelegate(IntPtr @this);

		// Token: 0x0200061E RID: 1566
		// (Invoke) Token: 0x06002A72 RID: 10866
		private delegate void set_lightShadowCasterModeDelegate(IntPtr @this, LightShadowCasterMode value);

		// Token: 0x0200061F RID: 1567
		// (Invoke) Token: 0x06002A74 RID: 10868
		private delegate void ResetDelegate(IntPtr @this);

		// Token: 0x02000620 RID: 1568
		// (Invoke) Token: 0x06002A76 RID: 10870
		private delegate void set_shadowsDelegate(IntPtr @this, LightShadows value);

		// Token: 0x02000621 RID: 1569
		// (Invoke) Token: 0x06002A78 RID: 10872
		private delegate UnityEngine.Rendering.LightShadowResolution get_shadowResolutionDelegate(IntPtr @this);

		// Token: 0x02000622 RID: 1570
		// (Invoke) Token: 0x06002A7A RID: 10874
		private delegate void set_shadowResolutionDelegate(IntPtr @this, UnityEngine.Rendering.LightShadowResolution value);

		// Token: 0x02000623 RID: 1571
		// (Invoke) Token: 0x06002A7C RID: 10876
		private delegate IntPtr get_layerShadowCullDistancesDelegate(IntPtr @this);

		// Token: 0x02000624 RID: 1572
		// (Invoke) Token: 0x06002A7E RID: 10878
		private delegate void set_layerShadowCullDistancesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000625 RID: 1573
		// (Invoke) Token: 0x06002A80 RID: 10880
		private delegate void set_cookieSizeDelegate(IntPtr @this, float value);

		// Token: 0x02000626 RID: 1574
		// (Invoke) Token: 0x06002A82 RID: 10882
		private delegate void set_cookieDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000627 RID: 1575
		// (Invoke) Token: 0x06002A84 RID: 10884
		private delegate LightRenderMode get_renderModeDelegate(IntPtr @this);

		// Token: 0x02000628 RID: 1576
		// (Invoke) Token: 0x06002A86 RID: 10886
		private delegate void set_renderModeDelegate(IntPtr @this, LightRenderMode value);

		// Token: 0x02000629 RID: 1577
		// (Invoke) Token: 0x06002A88 RID: 10888
		private delegate void AddCommandBufferDelegate(IntPtr @this, UnityEngine.Rendering.LightEvent evt, IntPtr buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask);

		// Token: 0x0200062A RID: 1578
		// (Invoke) Token: 0x06002A8A RID: 10890
		private delegate void AddCommandBufferAsyncDelegate(IntPtr @this, UnityEngine.Rendering.LightEvent evt, IntPtr buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType);

		// Token: 0x0200062B RID: 1579
		// (Invoke) Token: 0x06002A8C RID: 10892
		private delegate void RemoveCommandBufferDelegate(IntPtr @this, UnityEngine.Rendering.LightEvent evt, IntPtr buffer);

		// Token: 0x0200062C RID: 1580
		// (Invoke) Token: 0x06002A8E RID: 10894
		private delegate void RemoveCommandBuffersDelegate(IntPtr @this, UnityEngine.Rendering.LightEvent evt);

		// Token: 0x0200062D RID: 1581
		// (Invoke) Token: 0x06002A90 RID: 10896
		private delegate void RemoveAllCommandBuffersDelegate(IntPtr @this);

		// Token: 0x0200062E RID: 1582
		// (Invoke) Token: 0x06002A92 RID: 10898
		private delegate IntPtr GetCommandBuffersDelegate(IntPtr @this, UnityEngine.Rendering.LightEvent evt);

		// Token: 0x0200062F RID: 1583
		// (Invoke) Token: 0x06002A94 RID: 10900
		private delegate int get_commandBufferCountDelegate(IntPtr @this);

		// Token: 0x02000630 RID: 1584
		// (Invoke) Token: 0x06002A96 RID: 10902
		private delegate IntPtr GetLightsDelegate(LightType type, int layer);

		// Token: 0x02000631 RID: 1585
		// (Invoke) Token: 0x06002A98 RID: 10904
		private delegate void get_boundingSphereOverride_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000632 RID: 1586
		// (Invoke) Token: 0x06002A9A RID: 10906
		private delegate void set_boundingSphereOverride_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000633 RID: 1587
		// (Invoke) Token: 0x06002A9C RID: 10908
		private delegate void get_shadowMatrixOverride_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000634 RID: 1588
		// (Invoke) Token: 0x06002A9E RID: 10910
		private delegate void set_shadowMatrixOverride_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000635 RID: 1589
		// (Invoke) Token: 0x06002AA0 RID: 10912
		private delegate void set_bakingOutput_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
