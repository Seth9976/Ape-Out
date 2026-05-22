using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Linq;

namespace UnityEngine.Rendering
{
	// Token: 0x0200016B RID: 363
	public sealed class GraphicsSettings : Object
	{
		// Token: 0x060019ED RID: 6637 RVA: 0x00063504 File Offset: 0x00061704
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsSettings()
		{
			Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GraphicsSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr);
			GraphicsSettings.NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100665718);
			GraphicsSettings.NativeMethodInfoPtr_get_renderPipelineAsset_Public_Static_get_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100665719);
			GraphicsSettings.NativeMethodInfoPtr_get_INTERNAL_defaultRenderPipeline_Private_Static_get_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100665720);
			GraphicsSettings.NativeMethodInfoPtr_get_defaultRenderPipeline_Public_Static_get_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100665721);
			GraphicsSettings.NativeMethodInfoPtr_GetShaderMode_Public_Static_BuiltinShaderMode_BuiltinShaderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100665722);
			GraphicsSettings.get_transparencySortModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_transparencySortModeDelegate>("UnityEngine.Rendering.GraphicsSettings::get_transparencySortMode");
			GraphicsSettings.set_transparencySortModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_transparencySortModeDelegate>("UnityEngine.Rendering.GraphicsSettings::set_transparencySortMode");
			GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegate>("UnityEngine.Rendering.GraphicsSettings::get_realtimeDirectRectangularAreaLights");
			GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegate>("UnityEngine.Rendering.GraphicsSettings::set_realtimeDirectRectangularAreaLights");
			GraphicsSettings.set_lightsUseLinearIntensityDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_lightsUseLinearIntensityDelegate>("UnityEngine.Rendering.GraphicsSettings::set_lightsUseLinearIntensity");
			GraphicsSettings.get_lightsUseColorTemperatureDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_lightsUseColorTemperatureDelegate>("UnityEngine.Rendering.GraphicsSettings::get_lightsUseColorTemperature");
			GraphicsSettings.set_lightsUseColorTemperatureDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_lightsUseColorTemperatureDelegate>("UnityEngine.Rendering.GraphicsSettings::set_lightsUseColorTemperature");
			GraphicsSettings.get_defaultRenderingLayerMaskDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_defaultRenderingLayerMaskDelegate>("UnityEngine.Rendering.GraphicsSettings::get_defaultRenderingLayerMask");
			GraphicsSettings.set_defaultRenderingLayerMaskDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_defaultRenderingLayerMaskDelegate>("UnityEngine.Rendering.GraphicsSettings::set_defaultRenderingLayerMask");
			GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_useScriptableRenderPipelineBatching");
			GraphicsSettings.set_useScriptableRenderPipelineBatchingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_useScriptableRenderPipelineBatchingDelegate>("UnityEngine.Rendering.GraphicsSettings::set_useScriptableRenderPipelineBatching");
			GraphicsSettings.get_logWhenShaderIsCompiledDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_logWhenShaderIsCompiledDelegate>("UnityEngine.Rendering.GraphicsSettings::get_logWhenShaderIsCompiled");
			GraphicsSettings.set_logWhenShaderIsCompiledDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_logWhenShaderIsCompiledDelegate>("UnityEngine.Rendering.GraphicsSettings::set_logWhenShaderIsCompiled");
			GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegate>("UnityEngine.Rendering.GraphicsSettings::get_disableBuiltinCustomRenderTextureUpdate");
			GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegate>("UnityEngine.Rendering.GraphicsSettings::set_disableBuiltinCustomRenderTextureUpdate");
			GraphicsSettings.get_videoShadersIncludeModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_videoShadersIncludeModeDelegate>("UnityEngine.Rendering.GraphicsSettings::get_videoShadersIncludeMode");
			GraphicsSettings.HasShaderDefineDelegateField = IL2CPP.ResolveICall<GraphicsSettings.HasShaderDefineDelegate>("UnityEngine.Rendering.GraphicsSettings::HasShaderDefine");
			GraphicsSettings.get_INTERNAL_currentRenderPipelineDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_INTERNAL_currentRenderPipelineDelegate>("UnityEngine.Rendering.GraphicsSettings::get_INTERNAL_currentRenderPipeline");
			GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegate>("UnityEngine.Rendering.GraphicsSettings::set_INTERNAL_defaultRenderPipeline");
			GraphicsSettings.GetAllConfiguredRenderPipelinesDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetAllConfiguredRenderPipelinesDelegate>("UnityEngine.Rendering.GraphicsSettings::GetAllConfiguredRenderPipelines");
			GraphicsSettings.GetGraphicsSettingsDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetGraphicsSettingsDelegate>("UnityEngine.Rendering.GraphicsSettings::GetGraphicsSettings");
			GraphicsSettings.SetShaderModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.SetShaderModeDelegate>("UnityEngine.Rendering.GraphicsSettings::SetShaderMode");
			GraphicsSettings.SetCustomShaderDelegateField = IL2CPP.ResolveICall<GraphicsSettings.SetCustomShaderDelegate>("UnityEngine.Rendering.GraphicsSettings::SetCustomShader");
			GraphicsSettings.GetCustomShaderDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetCustomShaderDelegate>("UnityEngine.Rendering.GraphicsSettings::GetCustomShader");
			GraphicsSettings.get_cameraRelativeLightCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_cameraRelativeLightCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_cameraRelativeLightCulling");
			GraphicsSettings.set_cameraRelativeLightCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_cameraRelativeLightCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::set_cameraRelativeLightCulling");
			GraphicsSettings.get_cameraRelativeShadowCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_cameraRelativeShadowCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_cameraRelativeShadowCulling");
			GraphicsSettings.set_cameraRelativeShadowCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_cameraRelativeShadowCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::set_cameraRelativeShadowCulling");
			GraphicsSettings.get_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_transparencySortAxis_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::get_transparencySortAxis_Injected");
			GraphicsSettings.set_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_transparencySortAxis_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::set_transparencySortAxis_Injected");
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x0006375C File Offset: 0x0006195C
		// (set) Token: 0x060019FA RID: 6650 RVA: 0x0000D92F File Offset: 0x0000BB2F
		public unsafe static bool lightsUseLinearIntensity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502526, XrefRangeEnd = 502530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				GraphicsSettings.set_lightsUseLinearIntensityDelegateField(value);
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x0006378C File Offset: 0x0006198C
		// (set) Token: 0x06001A0A RID: 6666 RVA: 0x0000D9D3 File Offset: 0x0000BBD3
		public unsafe static RenderPipelineAsset renderPipelineAsset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502530, XrefRangeEnd = 502533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_renderPipelineAsset_Public_Static_get_RenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipelineAsset>(intPtr3) : null;
			}
			set
			{
				GraphicsSettings.defaultRenderPipeline = value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x000637C0 File Offset: 0x000619C0
		// (set) Token: 0x06001A0B RID: 6667 RVA: 0x0000D9DD File Offset: 0x0000BBDD
		public unsafe static ScriptableObject INTERNAL_defaultRenderPipeline
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502533, XrefRangeEnd = 502537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_INTERNAL_defaultRenderPipeline_Private_Static_get_ScriptableObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
			}
			set
			{
				GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060019F1 RID: 6641 RVA: 0x000637F4 File Offset: 0x000619F4
		// (set) Token: 0x06001A0C RID: 6668 RVA: 0x0000D9EF File Offset: 0x0000BBEF
		public unsafe static RenderPipelineAsset defaultRenderPipeline
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_defaultRenderPipeline_Public_Static_get_RenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipelineAsset>(intPtr3) : null;
			}
			set
			{
				GraphicsSettings.INTERNAL_defaultRenderPipeline = value;
			}
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00063828 File Offset: 0x00061A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502537, XrefRangeEnd = 502541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BuiltinShaderMode GetShaderMode(BuiltinShaderType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_GetShaderMode_Public_Static_BuiltinShaderMode_BuiltinShaderType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x0000D8EB File Offset: 0x0000BAEB
		public GraphicsSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x0000D8F4 File Offset: 0x0000BAF4
		// (set) Token: 0x060019F5 RID: 6645 RVA: 0x0000D900 File Offset: 0x0000BB00
		public static TransparencySortMode transparencySortMode
		{
			get
			{
				return GraphicsSettings.get_transparencySortModeDelegateField();
			}
			set
			{
				GraphicsSettings.set_transparencySortModeDelegateField(value);
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x00063868 File Offset: 0x00061A68
		// (set) Token: 0x060019F7 RID: 6647 RVA: 0x0000D90D File Offset: 0x0000BB0D
		public static Vector3 transparencySortAxis
		{
			get
			{
				Vector3 vector;
				GraphicsSettings.get_transparencySortAxis_Injected(out vector);
				return vector;
			}
			set
			{
				GraphicsSettings.set_transparencySortAxis_Injected(ref value);
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x0000D916 File Offset: 0x0000BB16
		// (set) Token: 0x060019F9 RID: 6649 RVA: 0x0000D922 File Offset: 0x0000BB22
		public static bool realtimeDirectRectangularAreaLights
		{
			get
			{
				return GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegateField();
			}
			set
			{
				GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegateField(value);
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x0000D93C File Offset: 0x0000BB3C
		// (set) Token: 0x060019FC RID: 6652 RVA: 0x0000D948 File Offset: 0x0000BB48
		public static bool lightsUseColorTemperature
		{
			get
			{
				return GraphicsSettings.get_lightsUseColorTemperatureDelegateField();
			}
			set
			{
				GraphicsSettings.set_lightsUseColorTemperatureDelegateField(value);
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x0000D955 File Offset: 0x0000BB55
		// (set) Token: 0x060019FE RID: 6654 RVA: 0x0000D961 File Offset: 0x0000BB61
		public static uint defaultRenderingLayerMask
		{
			get
			{
				return GraphicsSettings.get_defaultRenderingLayerMaskDelegateField();
			}
			set
			{
				GraphicsSettings.set_defaultRenderingLayerMaskDelegateField(value);
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x0000D96E File Offset: 0x0000BB6E
		// (set) Token: 0x06001A00 RID: 6656 RVA: 0x0000D97A File Offset: 0x0000BB7A
		public static bool useScriptableRenderPipelineBatching
		{
			get
			{
				return GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegateField();
			}
			set
			{
				GraphicsSettings.set_useScriptableRenderPipelineBatchingDelegateField(value);
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x0000D987 File Offset: 0x0000BB87
		// (set) Token: 0x06001A02 RID: 6658 RVA: 0x0000D993 File Offset: 0x0000BB93
		public static bool logWhenShaderIsCompiled
		{
			get
			{
				return GraphicsSettings.get_logWhenShaderIsCompiledDelegateField();
			}
			set
			{
				GraphicsSettings.set_logWhenShaderIsCompiledDelegateField(value);
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x0000D9A0 File Offset: 0x0000BBA0
		// (set) Token: 0x06001A04 RID: 6660 RVA: 0x0000D9AC File Offset: 0x0000BBAC
		public static bool disableBuiltinCustomRenderTextureUpdate
		{
			get
			{
				return GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegateField();
			}
			set
			{
				GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegateField(value);
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x0000D9B9 File Offset: 0x0000BBB9
		public static VideoShadersIncludeMode videoShadersIncludeMode
		{
			get
			{
				return GraphicsSettings.get_videoShadersIncludeModeDelegateField();
			}
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0000D9C5 File Offset: 0x0000BBC5
		public static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash)
		{
			return GraphicsSettings.HasShaderDefineDelegateField(tier, defineHash);
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00063880 File Offset: 0x00061A80
		public static bool HasShaderDefine(BuiltinShaderDefine defineHash)
		{
			return GraphicsSettings.HasShaderDefine(Graphics.activeTier, defineHash);
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x000638A0 File Offset: 0x00061AA0
		public static ScriptableObject INTERNAL_currentRenderPipeline
		{
			get
			{
				IntPtr intPtr = GraphicsSettings.get_INTERNAL_currentRenderPipelineDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x000638C8 File Offset: 0x00061AC8
		public static RenderPipelineAsset currentRenderPipeline
		{
			get
			{
				return GraphicsSettings.INTERNAL_currentRenderPipeline.TryCast<RenderPipelineAsset>();
			}
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x000638E4 File Offset: 0x00061AE4
		public static Il2CppReferenceArray<ScriptableObject> GetAllConfiguredRenderPipelines()
		{
			IntPtr intPtr = GraphicsSettings.GetAllConfiguredRenderPipelinesDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScriptableObject>>(intPtr2) : null;
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x0006390C File Offset: 0x00061B0C
		public static Il2CppReferenceArray<RenderPipelineAsset> allConfiguredRenderPipelines
		{
			get
			{
				return GraphicsSettings.GetAllConfiguredRenderPipelines().Cast<RenderPipelineAsset>().ToArray<RenderPipelineAsset>();
			}
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x00063930 File Offset: 0x00061B30
		public static Object GetGraphicsSettings()
		{
			IntPtr intPtr = GraphicsSettings.GetGraphicsSettingsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0000D9F9 File Offset: 0x0000BBF9
		public static void SetShaderMode(BuiltinShaderType type, BuiltinShaderMode mode)
		{
			GraphicsSettings.SetShaderModeDelegateField(type, mode);
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x0000DA07 File Offset: 0x0000BC07
		public static void SetCustomShader(BuiltinShaderType type, Shader shader)
		{
			GraphicsSettings.SetCustomShaderDelegateField(type, IL2CPP.Il2CppObjectBaseToPtr(shader));
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00063958 File Offset: 0x00061B58
		public static Shader GetCustomShader(BuiltinShaderType type)
		{
			IntPtr intPtr = GraphicsSettings.GetCustomShaderDelegateField(type);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x0000DA1A File Offset: 0x0000BC1A
		// (set) Token: 0x06001A14 RID: 6676 RVA: 0x0000DA26 File Offset: 0x0000BC26
		public static bool cameraRelativeLightCulling
		{
			get
			{
				return GraphicsSettings.get_cameraRelativeLightCullingDelegateField();
			}
			set
			{
				GraphicsSettings.set_cameraRelativeLightCullingDelegateField(value);
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x0000DA33 File Offset: 0x0000BC33
		// (set) Token: 0x06001A16 RID: 6678 RVA: 0x0000DA3F File Offset: 0x0000BC3F
		public static bool cameraRelativeShadowCulling
		{
			get
			{
				return GraphicsSettings.get_cameraRelativeShadowCullingDelegateField();
			}
			set
			{
				GraphicsSettings.set_cameraRelativeShadowCullingDelegateField(value);
			}
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0000DA4C File Offset: 0x0000BC4C
		public static void get_transparencySortAxis_Injected(out Vector3 ret)
		{
			GraphicsSettings.get_transparencySortAxis_InjectedDelegateField(out ret);
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x0000DA59 File Offset: 0x0000BC59
		public static void set_transparencySortAxis_Injected(ref Vector3 value)
		{
			GraphicsSettings.set_transparencySortAxis_InjectedDelegateField(ref value);
		}

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr_get_renderPipelineAsset_Public_Static_get_RenderPipelineAsset_0;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeMethodInfoPtr_get_INTERNAL_defaultRenderPipeline_Private_Static_get_ScriptableObject_0;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultRenderPipeline_Public_Static_get_RenderPipelineAsset_0;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderMode_Public_Static_BuiltinShaderMode_BuiltinShaderType_0;

		// Token: 0x040014B3 RID: 5299
		private static readonly GraphicsSettings.get_transparencySortModeDelegate get_transparencySortModeDelegateField;

		// Token: 0x040014B4 RID: 5300
		private static readonly GraphicsSettings.set_transparencySortModeDelegate set_transparencySortModeDelegateField;

		// Token: 0x040014B5 RID: 5301
		private static readonly GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegate get_realtimeDirectRectangularAreaLightsDelegateField;

		// Token: 0x040014B6 RID: 5302
		private static readonly GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegate set_realtimeDirectRectangularAreaLightsDelegateField;

		// Token: 0x040014B7 RID: 5303
		private static readonly GraphicsSettings.set_lightsUseLinearIntensityDelegate set_lightsUseLinearIntensityDelegateField;

		// Token: 0x040014B8 RID: 5304
		private static readonly GraphicsSettings.get_lightsUseColorTemperatureDelegate get_lightsUseColorTemperatureDelegateField;

		// Token: 0x040014B9 RID: 5305
		private static readonly GraphicsSettings.set_lightsUseColorTemperatureDelegate set_lightsUseColorTemperatureDelegateField;

		// Token: 0x040014BA RID: 5306
		private static readonly GraphicsSettings.get_defaultRenderingLayerMaskDelegate get_defaultRenderingLayerMaskDelegateField;

		// Token: 0x040014BB RID: 5307
		private static readonly GraphicsSettings.set_defaultRenderingLayerMaskDelegate set_defaultRenderingLayerMaskDelegateField;

		// Token: 0x040014BC RID: 5308
		private static readonly GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegate get_useScriptableRenderPipelineBatchingDelegateField;

		// Token: 0x040014BD RID: 5309
		private static readonly GraphicsSettings.set_useScriptableRenderPipelineBatchingDelegate set_useScriptableRenderPipelineBatchingDelegateField;

		// Token: 0x040014BE RID: 5310
		private static readonly GraphicsSettings.get_logWhenShaderIsCompiledDelegate get_logWhenShaderIsCompiledDelegateField;

		// Token: 0x040014BF RID: 5311
		private static readonly GraphicsSettings.set_logWhenShaderIsCompiledDelegate set_logWhenShaderIsCompiledDelegateField;

		// Token: 0x040014C0 RID: 5312
		private static readonly GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegate get_disableBuiltinCustomRenderTextureUpdateDelegateField;

		// Token: 0x040014C1 RID: 5313
		private static readonly GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegate set_disableBuiltinCustomRenderTextureUpdateDelegateField;

		// Token: 0x040014C2 RID: 5314
		private static readonly GraphicsSettings.get_videoShadersIncludeModeDelegate get_videoShadersIncludeModeDelegateField;

		// Token: 0x040014C3 RID: 5315
		private static readonly GraphicsSettings.HasShaderDefineDelegate HasShaderDefineDelegateField;

		// Token: 0x040014C4 RID: 5316
		private static readonly GraphicsSettings.get_INTERNAL_currentRenderPipelineDelegate get_INTERNAL_currentRenderPipelineDelegateField;

		// Token: 0x040014C5 RID: 5317
		private static readonly GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegate set_INTERNAL_defaultRenderPipelineDelegateField;

		// Token: 0x040014C6 RID: 5318
		private static readonly GraphicsSettings.GetAllConfiguredRenderPipelinesDelegate GetAllConfiguredRenderPipelinesDelegateField;

		// Token: 0x040014C7 RID: 5319
		private static readonly GraphicsSettings.GetGraphicsSettingsDelegate GetGraphicsSettingsDelegateField;

		// Token: 0x040014C8 RID: 5320
		private static readonly GraphicsSettings.SetShaderModeDelegate SetShaderModeDelegateField;

		// Token: 0x040014C9 RID: 5321
		private static readonly GraphicsSettings.SetCustomShaderDelegate SetCustomShaderDelegateField;

		// Token: 0x040014CA RID: 5322
		private static readonly GraphicsSettings.GetCustomShaderDelegate GetCustomShaderDelegateField;

		// Token: 0x040014CB RID: 5323
		private static readonly GraphicsSettings.get_cameraRelativeLightCullingDelegate get_cameraRelativeLightCullingDelegateField;

		// Token: 0x040014CC RID: 5324
		private static readonly GraphicsSettings.set_cameraRelativeLightCullingDelegate set_cameraRelativeLightCullingDelegateField;

		// Token: 0x040014CD RID: 5325
		private static readonly GraphicsSettings.get_cameraRelativeShadowCullingDelegate get_cameraRelativeShadowCullingDelegateField;

		// Token: 0x040014CE RID: 5326
		private static readonly GraphicsSettings.set_cameraRelativeShadowCullingDelegate set_cameraRelativeShadowCullingDelegateField;

		// Token: 0x040014CF RID: 5327
		private static readonly GraphicsSettings.get_transparencySortAxis_InjectedDelegate get_transparencySortAxis_InjectedDelegateField;

		// Token: 0x040014D0 RID: 5328
		private static readonly GraphicsSettings.set_transparencySortAxis_InjectedDelegate set_transparencySortAxis_InjectedDelegateField;

		// Token: 0x02000947 RID: 2375
		// (Invoke) Token: 0x06003123 RID: 12579
		private delegate TransparencySortMode get_transparencySortModeDelegate();

		// Token: 0x02000948 RID: 2376
		// (Invoke) Token: 0x06003125 RID: 12581
		private delegate void set_transparencySortModeDelegate(TransparencySortMode value);

		// Token: 0x02000949 RID: 2377
		// (Invoke) Token: 0x06003127 RID: 12583
		private delegate bool get_realtimeDirectRectangularAreaLightsDelegate();

		// Token: 0x0200094A RID: 2378
		// (Invoke) Token: 0x06003129 RID: 12585
		private delegate void set_realtimeDirectRectangularAreaLightsDelegate(bool value);

		// Token: 0x0200094B RID: 2379
		// (Invoke) Token: 0x0600312B RID: 12587
		private delegate void set_lightsUseLinearIntensityDelegate(bool value);

		// Token: 0x0200094C RID: 2380
		// (Invoke) Token: 0x0600312D RID: 12589
		private delegate bool get_lightsUseColorTemperatureDelegate();

		// Token: 0x0200094D RID: 2381
		// (Invoke) Token: 0x0600312F RID: 12591
		private delegate void set_lightsUseColorTemperatureDelegate(bool value);

		// Token: 0x0200094E RID: 2382
		// (Invoke) Token: 0x06003131 RID: 12593
		private delegate uint get_defaultRenderingLayerMaskDelegate();

		// Token: 0x0200094F RID: 2383
		// (Invoke) Token: 0x06003133 RID: 12595
		private delegate void set_defaultRenderingLayerMaskDelegate(uint value);

		// Token: 0x02000950 RID: 2384
		// (Invoke) Token: 0x06003135 RID: 12597
		private delegate bool get_useScriptableRenderPipelineBatchingDelegate();

		// Token: 0x02000951 RID: 2385
		// (Invoke) Token: 0x06003137 RID: 12599
		private delegate void set_useScriptableRenderPipelineBatchingDelegate(bool value);

		// Token: 0x02000952 RID: 2386
		// (Invoke) Token: 0x06003139 RID: 12601
		private delegate bool get_logWhenShaderIsCompiledDelegate();

		// Token: 0x02000953 RID: 2387
		// (Invoke) Token: 0x0600313B RID: 12603
		private delegate void set_logWhenShaderIsCompiledDelegate(bool value);

		// Token: 0x02000954 RID: 2388
		// (Invoke) Token: 0x0600313D RID: 12605
		private delegate bool get_disableBuiltinCustomRenderTextureUpdateDelegate();

		// Token: 0x02000955 RID: 2389
		// (Invoke) Token: 0x0600313F RID: 12607
		private delegate void set_disableBuiltinCustomRenderTextureUpdateDelegate(bool value);

		// Token: 0x02000956 RID: 2390
		// (Invoke) Token: 0x06003141 RID: 12609
		private delegate VideoShadersIncludeMode get_videoShadersIncludeModeDelegate();

		// Token: 0x02000957 RID: 2391
		// (Invoke) Token: 0x06003143 RID: 12611
		private delegate bool HasShaderDefineDelegate(GraphicsTier tier, BuiltinShaderDefine defineHash);

		// Token: 0x02000958 RID: 2392
		// (Invoke) Token: 0x06003145 RID: 12613
		private delegate IntPtr get_INTERNAL_currentRenderPipelineDelegate();

		// Token: 0x02000959 RID: 2393
		// (Invoke) Token: 0x06003147 RID: 12615
		private delegate void set_INTERNAL_defaultRenderPipelineDelegate(IntPtr value);

		// Token: 0x0200095A RID: 2394
		// (Invoke) Token: 0x06003149 RID: 12617
		private delegate IntPtr GetAllConfiguredRenderPipelinesDelegate();

		// Token: 0x0200095B RID: 2395
		// (Invoke) Token: 0x0600314B RID: 12619
		private delegate IntPtr GetGraphicsSettingsDelegate();

		// Token: 0x0200095C RID: 2396
		// (Invoke) Token: 0x0600314D RID: 12621
		private delegate void SetShaderModeDelegate(BuiltinShaderType type, BuiltinShaderMode mode);

		// Token: 0x0200095D RID: 2397
		// (Invoke) Token: 0x0600314F RID: 12623
		private delegate void SetCustomShaderDelegate(BuiltinShaderType type, IntPtr shader);

		// Token: 0x0200095E RID: 2398
		// (Invoke) Token: 0x06003151 RID: 12625
		private delegate IntPtr GetCustomShaderDelegate(BuiltinShaderType type);

		// Token: 0x0200095F RID: 2399
		// (Invoke) Token: 0x06003153 RID: 12627
		private delegate bool get_cameraRelativeLightCullingDelegate();

		// Token: 0x02000960 RID: 2400
		// (Invoke) Token: 0x06003155 RID: 12629
		private delegate void set_cameraRelativeLightCullingDelegate(bool value);

		// Token: 0x02000961 RID: 2401
		// (Invoke) Token: 0x06003157 RID: 12631
		private delegate bool get_cameraRelativeShadowCullingDelegate();

		// Token: 0x02000962 RID: 2402
		// (Invoke) Token: 0x06003159 RID: 12633
		private delegate void set_cameraRelativeShadowCullingDelegate(bool value);

		// Token: 0x02000963 RID: 2403
		// (Invoke) Token: 0x0600315B RID: 12635
		private delegate void get_transparencySortAxis_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000964 RID: 2404
		// (Invoke) Token: 0x0600315D RID: 12637
		private delegate void set_transparencySortAxis_InjectedDelegate(IntPtr value);
	}
}
