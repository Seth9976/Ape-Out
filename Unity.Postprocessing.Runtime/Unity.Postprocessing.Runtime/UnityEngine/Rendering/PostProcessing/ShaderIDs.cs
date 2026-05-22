using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000062 RID: 98
	public static class ShaderIDs : Object
	{
		// Token: 0x0600057B RID: 1403 RVA: 0x00018178 File Offset: 0x00016378
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderIDs()
		{
			Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "ShaderIDs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr);
			ShaderIDs.NativeFieldInfoPtr_MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "MainTex");
			ShaderIDs.NativeFieldInfoPtr_Jitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Jitter");
			ShaderIDs.NativeFieldInfoPtr_Sharpness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Sharpness");
			ShaderIDs.NativeFieldInfoPtr_FinalBlendParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "FinalBlendParameters");
			ShaderIDs.NativeFieldInfoPtr_HistoryTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "HistoryTex");
			ShaderIDs.NativeFieldInfoPtr_SMAA_Flip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "SMAA_Flip");
			ShaderIDs.NativeFieldInfoPtr_SMAA_Flop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "SMAA_Flop");
			ShaderIDs.NativeFieldInfoPtr_AOParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "AOParams");
			ShaderIDs.NativeFieldInfoPtr_AOColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "AOColor");
			ShaderIDs.NativeFieldInfoPtr_OcclusionTexture1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "OcclusionTexture1");
			ShaderIDs.NativeFieldInfoPtr_OcclusionTexture2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "OcclusionTexture2");
			ShaderIDs.NativeFieldInfoPtr_SAOcclusionTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "SAOcclusionTexture");
			ShaderIDs.NativeFieldInfoPtr_MSVOcclusionTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "MSVOcclusionTexture");
			ShaderIDs.NativeFieldInfoPtr_DepthCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "DepthCopy");
			ShaderIDs.NativeFieldInfoPtr_LinearDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "LinearDepth");
			ShaderIDs.NativeFieldInfoPtr_LowDepth1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "LowDepth1");
			ShaderIDs.NativeFieldInfoPtr_LowDepth2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "LowDepth2");
			ShaderIDs.NativeFieldInfoPtr_LowDepth3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "LowDepth3");
			ShaderIDs.NativeFieldInfoPtr_LowDepth4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "LowDepth4");
			ShaderIDs.NativeFieldInfoPtr_TiledDepth1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "TiledDepth1");
			ShaderIDs.NativeFieldInfoPtr_TiledDepth2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "TiledDepth2");
			ShaderIDs.NativeFieldInfoPtr_TiledDepth3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "TiledDepth3");
			ShaderIDs.NativeFieldInfoPtr_TiledDepth4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "TiledDepth4");
			ShaderIDs.NativeFieldInfoPtr_Occlusion1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Occlusion1");
			ShaderIDs.NativeFieldInfoPtr_Occlusion2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Occlusion2");
			ShaderIDs.NativeFieldInfoPtr_Occlusion3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Occlusion3");
			ShaderIDs.NativeFieldInfoPtr_Occlusion4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Occlusion4");
			ShaderIDs.NativeFieldInfoPtr_Combined1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Combined1");
			ShaderIDs.NativeFieldInfoPtr_Combined2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Combined2");
			ShaderIDs.NativeFieldInfoPtr_Combined3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Combined3");
			ShaderIDs.NativeFieldInfoPtr_SSRResolveTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "SSRResolveTemp");
			ShaderIDs.NativeFieldInfoPtr_Noise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Noise");
			ShaderIDs.NativeFieldInfoPtr_Test = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Test");
			ShaderIDs.NativeFieldInfoPtr_Resolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Resolve");
			ShaderIDs.NativeFieldInfoPtr_History = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "History");
			ShaderIDs.NativeFieldInfoPtr_ViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "ViewMatrix");
			ShaderIDs.NativeFieldInfoPtr_InverseViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "InverseViewMatrix");
			ShaderIDs.NativeFieldInfoPtr_InverseProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "InverseProjectionMatrix");
			ShaderIDs.NativeFieldInfoPtr_ScreenSpaceProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "ScreenSpaceProjectionMatrix");
			ShaderIDs.NativeFieldInfoPtr_Params2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Params2");
			ShaderIDs.NativeFieldInfoPtr_FogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "FogColor");
			ShaderIDs.NativeFieldInfoPtr_FogParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "FogParams");
			ShaderIDs.NativeFieldInfoPtr_VelocityScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "VelocityScale");
			ShaderIDs.NativeFieldInfoPtr_MaxBlurRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "MaxBlurRadius");
			ShaderIDs.NativeFieldInfoPtr_RcpMaxBlurRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "RcpMaxBlurRadius");
			ShaderIDs.NativeFieldInfoPtr_VelocityTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "VelocityTex");
			ShaderIDs.NativeFieldInfoPtr_Tile2RT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Tile2RT");
			ShaderIDs.NativeFieldInfoPtr_Tile4RT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Tile4RT");
			ShaderIDs.NativeFieldInfoPtr_Tile8RT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Tile8RT");
			ShaderIDs.NativeFieldInfoPtr_TileMaxOffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "TileMaxOffs");
			ShaderIDs.NativeFieldInfoPtr_TileMaxLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "TileMaxLoop");
			ShaderIDs.NativeFieldInfoPtr_TileVRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "TileVRT");
			ShaderIDs.NativeFieldInfoPtr_NeighborMaxTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "NeighborMaxTex");
			ShaderIDs.NativeFieldInfoPtr_LoopCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "LoopCount");
			ShaderIDs.NativeFieldInfoPtr_DepthOfFieldTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "DepthOfFieldTemp");
			ShaderIDs.NativeFieldInfoPtr_DepthOfFieldTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "DepthOfFieldTex");
			ShaderIDs.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Distance");
			ShaderIDs.NativeFieldInfoPtr_LensCoeff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "LensCoeff");
			ShaderIDs.NativeFieldInfoPtr_MaxCoC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "MaxCoC");
			ShaderIDs.NativeFieldInfoPtr_RcpMaxCoC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "RcpMaxCoC");
			ShaderIDs.NativeFieldInfoPtr_RcpAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "RcpAspect");
			ShaderIDs.NativeFieldInfoPtr_CoCTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "CoCTex");
			ShaderIDs.NativeFieldInfoPtr_TaaParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "TaaParams");
			ShaderIDs.NativeFieldInfoPtr_AutoExposureTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "AutoExposureTex");
			ShaderIDs.NativeFieldInfoPtr_HistogramBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "HistogramBuffer");
			ShaderIDs.NativeFieldInfoPtr_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Params");
			ShaderIDs.NativeFieldInfoPtr_ScaleOffsetRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "ScaleOffsetRes");
			ShaderIDs.NativeFieldInfoPtr_BloomTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "BloomTex");
			ShaderIDs.NativeFieldInfoPtr_SampleScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "SampleScale");
			ShaderIDs.NativeFieldInfoPtr_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Threshold");
			ShaderIDs.NativeFieldInfoPtr_ColorIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "ColorIntensity");
			ShaderIDs.NativeFieldInfoPtr_Bloom_DirtTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Bloom_DirtTex");
			ShaderIDs.NativeFieldInfoPtr_Bloom_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Bloom_Settings");
			ShaderIDs.NativeFieldInfoPtr_Bloom_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Bloom_Color");
			ShaderIDs.NativeFieldInfoPtr_Bloom_DirtTileOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Bloom_DirtTileOffset");
			ShaderIDs.NativeFieldInfoPtr_ChromaticAberration_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "ChromaticAberration_Amount");
			ShaderIDs.NativeFieldInfoPtr_ChromaticAberration_SpectralLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "ChromaticAberration_SpectralLut");
			ShaderIDs.NativeFieldInfoPtr_Distortion_CenterScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Distortion_CenterScale");
			ShaderIDs.NativeFieldInfoPtr_Distortion_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Distortion_Amount");
			ShaderIDs.NativeFieldInfoPtr_Lut2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Lut2D");
			ShaderIDs.NativeFieldInfoPtr_Lut3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Lut3D");
			ShaderIDs.NativeFieldInfoPtr_Lut3D_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Lut3D_Params");
			ShaderIDs.NativeFieldInfoPtr_Lut2D_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Lut2D_Params");
			ShaderIDs.NativeFieldInfoPtr_UserLut2D_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "UserLut2D_Params");
			ShaderIDs.NativeFieldInfoPtr_PostExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "PostExposure");
			ShaderIDs.NativeFieldInfoPtr_ColorBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "ColorBalance");
			ShaderIDs.NativeFieldInfoPtr_ColorFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "ColorFilter");
			ShaderIDs.NativeFieldInfoPtr_HueSatCon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "HueSatCon");
			ShaderIDs.NativeFieldInfoPtr_Brightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Brightness");
			ShaderIDs.NativeFieldInfoPtr_ChannelMixerRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "ChannelMixerRed");
			ShaderIDs.NativeFieldInfoPtr_ChannelMixerGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "ChannelMixerGreen");
			ShaderIDs.NativeFieldInfoPtr_ChannelMixerBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "ChannelMixerBlue");
			ShaderIDs.NativeFieldInfoPtr_Lift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Lift");
			ShaderIDs.NativeFieldInfoPtr_InvGamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "InvGamma");
			ShaderIDs.NativeFieldInfoPtr_Gain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Gain");
			ShaderIDs.NativeFieldInfoPtr_Curves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Curves");
			ShaderIDs.NativeFieldInfoPtr_CustomToneCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "CustomToneCurve");
			ShaderIDs.NativeFieldInfoPtr_ToeSegmentA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "ToeSegmentA");
			ShaderIDs.NativeFieldInfoPtr_ToeSegmentB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "ToeSegmentB");
			ShaderIDs.NativeFieldInfoPtr_MidSegmentA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "MidSegmentA");
			ShaderIDs.NativeFieldInfoPtr_MidSegmentB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "MidSegmentB");
			ShaderIDs.NativeFieldInfoPtr_ShoSegmentA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "ShoSegmentA");
			ShaderIDs.NativeFieldInfoPtr_ShoSegmentB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "ShoSegmentB");
			ShaderIDs.NativeFieldInfoPtr_Vignette_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Vignette_Color");
			ShaderIDs.NativeFieldInfoPtr_Vignette_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Vignette_Center");
			ShaderIDs.NativeFieldInfoPtr_Vignette_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Vignette_Settings");
			ShaderIDs.NativeFieldInfoPtr_Vignette_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Vignette_Mask");
			ShaderIDs.NativeFieldInfoPtr_Vignette_Opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Vignette_Opacity");
			ShaderIDs.NativeFieldInfoPtr_Vignette_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Vignette_Mode");
			ShaderIDs.NativeFieldInfoPtr_Grain_Params1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Grain_Params1");
			ShaderIDs.NativeFieldInfoPtr_Grain_Params2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Grain_Params2");
			ShaderIDs.NativeFieldInfoPtr_GrainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "GrainTex");
			ShaderIDs.NativeFieldInfoPtr_Phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Phase");
			ShaderIDs.NativeFieldInfoPtr_GrainNoiseParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "GrainNoiseParameters");
			ShaderIDs.NativeFieldInfoPtr_LumaInAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "LumaInAlpha");
			ShaderIDs.NativeFieldInfoPtr_DitheringTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "DitheringTex");
			ShaderIDs.NativeFieldInfoPtr_Dithering_Coords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Dithering_Coords");
			ShaderIDs.NativeFieldInfoPtr_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "From");
			ShaderIDs.NativeFieldInfoPtr_To = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "To");
			ShaderIDs.NativeFieldInfoPtr_Interp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "Interp");
			ShaderIDs.NativeFieldInfoPtr_TargetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "TargetColor");
			ShaderIDs.NativeFieldInfoPtr_HalfResFinalCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "HalfResFinalCopy");
			ShaderIDs.NativeFieldInfoPtr_WaveformSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "WaveformSource");
			ShaderIDs.NativeFieldInfoPtr_WaveformBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "WaveformBuffer");
			ShaderIDs.NativeFieldInfoPtr_VectorscopeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "VectorscopeBuffer");
			ShaderIDs.NativeFieldInfoPtr_RenderViewportScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "RenderViewportScaleFactor");
			ShaderIDs.NativeFieldInfoPtr_UVTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "UVTransform");
			ShaderIDs.NativeFieldInfoPtr_DepthSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "DepthSlice");
			ShaderIDs.NativeFieldInfoPtr_UVScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "UVScaleOffset");
			ShaderIDs.NativeFieldInfoPtr_PosScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "PosScaleOffset");
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00004C9B File Offset: 0x00002E9B
		public ShaderIDs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00018BD0 File Offset: 0x00016DD0
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00004CA4 File Offset: 0x00002EA4
		public unsafe static int MainTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_MainTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_MainTex, (void*)(&value));
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00018BEC File Offset: 0x00016DEC
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00004CB2 File Offset: 0x00002EB2
		public unsafe static int Jitter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Jitter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Jitter, (void*)(&value));
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00018C08 File Offset: 0x00016E08
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00004CC0 File Offset: 0x00002EC0
		public unsafe static int Sharpness
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Sharpness, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Sharpness, (void*)(&value));
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00018C24 File Offset: 0x00016E24
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00004CCE File Offset: 0x00002ECE
		public unsafe static int FinalBlendParameters
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_FinalBlendParameters, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_FinalBlendParameters, (void*)(&value));
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00018C40 File Offset: 0x00016E40
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00004CDC File Offset: 0x00002EDC
		public unsafe static int HistoryTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_HistoryTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_HistoryTex, (void*)(&value));
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00018C5C File Offset: 0x00016E5C
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00004CEA File Offset: 0x00002EEA
		public unsafe static int SMAA_Flip
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_SMAA_Flip, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_SMAA_Flip, (void*)(&value));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00018C78 File Offset: 0x00016E78
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00004CF8 File Offset: 0x00002EF8
		public unsafe static int SMAA_Flop
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_SMAA_Flop, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_SMAA_Flop, (void*)(&value));
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00018C94 File Offset: 0x00016E94
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00004D06 File Offset: 0x00002F06
		public unsafe static int AOParams
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_AOParams, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_AOParams, (void*)(&value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00018CB0 File Offset: 0x00016EB0
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00004D14 File Offset: 0x00002F14
		public unsafe static int AOColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_AOColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_AOColor, (void*)(&value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00018CCC File Offset: 0x00016ECC
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00004D22 File Offset: 0x00002F22
		public unsafe static int OcclusionTexture1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_OcclusionTexture1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_OcclusionTexture1, (void*)(&value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00018CE8 File Offset: 0x00016EE8
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00004D30 File Offset: 0x00002F30
		public unsafe static int OcclusionTexture2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_OcclusionTexture2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_OcclusionTexture2, (void*)(&value));
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00018D04 File Offset: 0x00016F04
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00004D3E File Offset: 0x00002F3E
		public unsafe static int SAOcclusionTexture
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_SAOcclusionTexture, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_SAOcclusionTexture, (void*)(&value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00018D20 File Offset: 0x00016F20
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x00004D4C File Offset: 0x00002F4C
		public unsafe static int MSVOcclusionTexture
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_MSVOcclusionTexture, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_MSVOcclusionTexture, (void*)(&value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00018D3C File Offset: 0x00016F3C
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00004D5A File Offset: 0x00002F5A
		public unsafe static int DepthCopy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_DepthCopy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_DepthCopy, (void*)(&value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00018D58 File Offset: 0x00016F58
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00004D68 File Offset: 0x00002F68
		public unsafe static int LinearDepth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_LinearDepth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_LinearDepth, (void*)(&value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00018D74 File Offset: 0x00016F74
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x00004D76 File Offset: 0x00002F76
		public unsafe static int LowDepth1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_LowDepth1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_LowDepth1, (void*)(&value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00018D90 File Offset: 0x00016F90
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x00004D84 File Offset: 0x00002F84
		public unsafe static int LowDepth2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_LowDepth2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_LowDepth2, (void*)(&value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00018DAC File Offset: 0x00016FAC
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00004D92 File Offset: 0x00002F92
		public unsafe static int LowDepth3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_LowDepth3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_LowDepth3, (void*)(&value));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00018DC8 File Offset: 0x00016FC8
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00004DA0 File Offset: 0x00002FA0
		public unsafe static int LowDepth4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_LowDepth4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_LowDepth4, (void*)(&value));
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00018DE4 File Offset: 0x00016FE4
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00004DAE File Offset: 0x00002FAE
		public unsafe static int TiledDepth1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_TiledDepth1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_TiledDepth1, (void*)(&value));
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00018E00 File Offset: 0x00017000
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00004DBC File Offset: 0x00002FBC
		public unsafe static int TiledDepth2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_TiledDepth2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_TiledDepth2, (void*)(&value));
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00018E1C File Offset: 0x0001701C
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x00004DCA File Offset: 0x00002FCA
		public unsafe static int TiledDepth3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_TiledDepth3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_TiledDepth3, (void*)(&value));
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00018E38 File Offset: 0x00017038
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x00004DD8 File Offset: 0x00002FD8
		public unsafe static int TiledDepth4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_TiledDepth4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_TiledDepth4, (void*)(&value));
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00018E54 File Offset: 0x00017054
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x00004DE6 File Offset: 0x00002FE6
		public unsafe static int Occlusion1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Occlusion1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Occlusion1, (void*)(&value));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x00018E70 File Offset: 0x00017070
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x00004DF4 File Offset: 0x00002FF4
		public unsafe static int Occlusion2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Occlusion2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Occlusion2, (void*)(&value));
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00018E8C File Offset: 0x0001708C
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x00004E02 File Offset: 0x00003002
		public unsafe static int Occlusion3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Occlusion3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Occlusion3, (void*)(&value));
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00018EA8 File Offset: 0x000170A8
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x00004E10 File Offset: 0x00003010
		public unsafe static int Occlusion4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Occlusion4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Occlusion4, (void*)(&value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00018EC4 File Offset: 0x000170C4
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x00004E1E File Offset: 0x0000301E
		public unsafe static int Combined1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Combined1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Combined1, (void*)(&value));
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00018EE0 File Offset: 0x000170E0
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x00004E2C File Offset: 0x0000302C
		public unsafe static int Combined2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Combined2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Combined2, (void*)(&value));
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00018EFC File Offset: 0x000170FC
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00004E3A File Offset: 0x0000303A
		public unsafe static int Combined3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Combined3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Combined3, (void*)(&value));
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00018F18 File Offset: 0x00017118
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00004E48 File Offset: 0x00003048
		public unsafe static int SSRResolveTemp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_SSRResolveTemp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_SSRResolveTemp, (void*)(&value));
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x00018F34 File Offset: 0x00017134
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00004E56 File Offset: 0x00003056
		public unsafe static int Noise
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Noise, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Noise, (void*)(&value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x00018F50 File Offset: 0x00017150
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x00004E64 File Offset: 0x00003064
		public unsafe static int Test
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Test, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Test, (void*)(&value));
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x00018F6C File Offset: 0x0001716C
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x00004E72 File Offset: 0x00003072
		public unsafe static int Resolve
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Resolve, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Resolve, (void*)(&value));
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00018F88 File Offset: 0x00017188
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00004E80 File Offset: 0x00003080
		public unsafe static int History
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_History, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_History, (void*)(&value));
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00018FA4 File Offset: 0x000171A4
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x00004E8E File Offset: 0x0000308E
		public unsafe static int ViewMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_ViewMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_ViewMatrix, (void*)(&value));
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00018FC0 File Offset: 0x000171C0
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00004E9C File Offset: 0x0000309C
		public unsafe static int InverseViewMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_InverseViewMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_InverseViewMatrix, (void*)(&value));
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00018FDC File Offset: 0x000171DC
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00004EAA File Offset: 0x000030AA
		public unsafe static int InverseProjectionMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_InverseProjectionMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_InverseProjectionMatrix, (void*)(&value));
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00018FF8 File Offset: 0x000171F8
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x00004EB8 File Offset: 0x000030B8
		public unsafe static int ScreenSpaceProjectionMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_ScreenSpaceProjectionMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_ScreenSpaceProjectionMatrix, (void*)(&value));
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00019014 File Offset: 0x00017214
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x00004EC6 File Offset: 0x000030C6
		public unsafe static int Params2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Params2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Params2, (void*)(&value));
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00019030 File Offset: 0x00017230
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x00004ED4 File Offset: 0x000030D4
		public unsafe static int FogColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_FogColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_FogColor, (void*)(&value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0001904C File Offset: 0x0001724C
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00004EE2 File Offset: 0x000030E2
		public unsafe static int FogParams
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_FogParams, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_FogParams, (void*)(&value));
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00019068 File Offset: 0x00017268
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x00004EF0 File Offset: 0x000030F0
		public unsafe static int VelocityScale
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_VelocityScale, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_VelocityScale, (void*)(&value));
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00019084 File Offset: 0x00017284
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00004EFE File Offset: 0x000030FE
		public unsafe static int MaxBlurRadius
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_MaxBlurRadius, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_MaxBlurRadius, (void*)(&value));
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x000190A0 File Offset: 0x000172A0
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00004F0C File Offset: 0x0000310C
		public unsafe static int RcpMaxBlurRadius
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_RcpMaxBlurRadius, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_RcpMaxBlurRadius, (void*)(&value));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x000190BC File Offset: 0x000172BC
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x00004F1A File Offset: 0x0000311A
		public unsafe static int VelocityTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_VelocityTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_VelocityTex, (void*)(&value));
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x000190D8 File Offset: 0x000172D8
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x00004F28 File Offset: 0x00003128
		public unsafe static int Tile2RT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Tile2RT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Tile2RT, (void*)(&value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x000190F4 File Offset: 0x000172F4
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00004F36 File Offset: 0x00003136
		public unsafe static int Tile4RT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Tile4RT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Tile4RT, (void*)(&value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00019110 File Offset: 0x00017310
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00004F44 File Offset: 0x00003144
		public unsafe static int Tile8RT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Tile8RT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Tile8RT, (void*)(&value));
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x0001912C File Offset: 0x0001732C
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00004F52 File Offset: 0x00003152
		public unsafe static int TileMaxOffs
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_TileMaxOffs, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_TileMaxOffs, (void*)(&value));
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00019148 File Offset: 0x00017348
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00004F60 File Offset: 0x00003160
		public unsafe static int TileMaxLoop
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_TileMaxLoop, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_TileMaxLoop, (void*)(&value));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00019164 File Offset: 0x00017364
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00004F6E File Offset: 0x0000316E
		public unsafe static int TileVRT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_TileVRT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_TileVRT, (void*)(&value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00019180 File Offset: 0x00017380
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00004F7C File Offset: 0x0000317C
		public unsafe static int NeighborMaxTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_NeighborMaxTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_NeighborMaxTex, (void*)(&value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0001919C File Offset: 0x0001739C
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00004F8A File Offset: 0x0000318A
		public unsafe static int LoopCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_LoopCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_LoopCount, (void*)(&value));
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x000191B8 File Offset: 0x000173B8
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x00004F98 File Offset: 0x00003198
		public unsafe static int DepthOfFieldTemp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_DepthOfFieldTemp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_DepthOfFieldTemp, (void*)(&value));
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x000191D4 File Offset: 0x000173D4
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00004FA6 File Offset: 0x000031A6
		public unsafe static int DepthOfFieldTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_DepthOfFieldTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_DepthOfFieldTex, (void*)(&value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x000191F0 File Offset: 0x000173F0
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00004FB4 File Offset: 0x000031B4
		public unsafe static int Distance
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Distance, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Distance, (void*)(&value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x0001920C File Offset: 0x0001740C
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00004FC2 File Offset: 0x000031C2
		public unsafe static int LensCoeff
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_LensCoeff, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_LensCoeff, (void*)(&value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00019228 File Offset: 0x00017428
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00004FD0 File Offset: 0x000031D0
		public unsafe static int MaxCoC
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_MaxCoC, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_MaxCoC, (void*)(&value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00019244 File Offset: 0x00017444
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00004FDE File Offset: 0x000031DE
		public unsafe static int RcpMaxCoC
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_RcpMaxCoC, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_RcpMaxCoC, (void*)(&value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00019260 File Offset: 0x00017460
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00004FEC File Offset: 0x000031EC
		public unsafe static int RcpAspect
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_RcpAspect, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_RcpAspect, (void*)(&value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0001927C File Offset: 0x0001747C
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00004FFA File Offset: 0x000031FA
		public unsafe static int CoCTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_CoCTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_CoCTex, (void*)(&value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00019298 File Offset: 0x00017498
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00005008 File Offset: 0x00003208
		public unsafe static int TaaParams
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_TaaParams, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_TaaParams, (void*)(&value));
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x000192B4 File Offset: 0x000174B4
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00005016 File Offset: 0x00003216
		public unsafe static int AutoExposureTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_AutoExposureTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_AutoExposureTex, (void*)(&value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x000192D0 File Offset: 0x000174D0
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00005024 File Offset: 0x00003224
		public unsafe static int HistogramBuffer
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_HistogramBuffer, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_HistogramBuffer, (void*)(&value));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x000192EC File Offset: 0x000174EC
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00005032 File Offset: 0x00003232
		public unsafe static int Params
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Params, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Params, (void*)(&value));
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00019308 File Offset: 0x00017508
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00005040 File Offset: 0x00003240
		public unsafe static int ScaleOffsetRes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_ScaleOffsetRes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_ScaleOffsetRes, (void*)(&value));
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00019324 File Offset: 0x00017524
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x0000504E File Offset: 0x0000324E
		public unsafe static int BloomTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_BloomTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_BloomTex, (void*)(&value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00019340 File Offset: 0x00017540
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x0000505C File Offset: 0x0000325C
		public unsafe static int SampleScale
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_SampleScale, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_SampleScale, (void*)(&value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0001935C File Offset: 0x0001755C
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x0000506A File Offset: 0x0000326A
		public unsafe static int Threshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Threshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Threshold, (void*)(&value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00019378 File Offset: 0x00017578
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x00005078 File Offset: 0x00003278
		public unsafe static int ColorIntensity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_ColorIntensity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_ColorIntensity, (void*)(&value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00019394 File Offset: 0x00017594
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x00005086 File Offset: 0x00003286
		public unsafe static int Bloom_DirtTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Bloom_DirtTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Bloom_DirtTex, (void*)(&value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x000193B0 File Offset: 0x000175B0
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x00005094 File Offset: 0x00003294
		public unsafe static int Bloom_Settings
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Bloom_Settings, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Bloom_Settings, (void*)(&value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x000193CC File Offset: 0x000175CC
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x000050A2 File Offset: 0x000032A2
		public unsafe static int Bloom_Color
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Bloom_Color, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Bloom_Color, (void*)(&value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x000193E8 File Offset: 0x000175E8
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x000050B0 File Offset: 0x000032B0
		public unsafe static int Bloom_DirtTileOffset
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Bloom_DirtTileOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Bloom_DirtTileOffset, (void*)(&value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00019404 File Offset: 0x00017604
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x000050BE File Offset: 0x000032BE
		public unsafe static int ChromaticAberration_Amount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_ChromaticAberration_Amount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_ChromaticAberration_Amount, (void*)(&value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00019420 File Offset: 0x00017620
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x000050CC File Offset: 0x000032CC
		public unsafe static int ChromaticAberration_SpectralLut
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_ChromaticAberration_SpectralLut, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_ChromaticAberration_SpectralLut, (void*)(&value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0001943C File Offset: 0x0001763C
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x000050DA File Offset: 0x000032DA
		public unsafe static int Distortion_CenterScale
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Distortion_CenterScale, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Distortion_CenterScale, (void*)(&value));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x00019458 File Offset: 0x00017658
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x000050E8 File Offset: 0x000032E8
		public unsafe static int Distortion_Amount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Distortion_Amount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Distortion_Amount, (void*)(&value));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00019474 File Offset: 0x00017674
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x000050F6 File Offset: 0x000032F6
		public unsafe static int Lut2D
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Lut2D, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Lut2D, (void*)(&value));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00019490 File Offset: 0x00017690
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x00005104 File Offset: 0x00003304
		public unsafe static int Lut3D
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Lut3D, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Lut3D, (void*)(&value));
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x000194AC File Offset: 0x000176AC
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00005112 File Offset: 0x00003312
		public unsafe static int Lut3D_Params
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Lut3D_Params, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Lut3D_Params, (void*)(&value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x000194C8 File Offset: 0x000176C8
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00005120 File Offset: 0x00003320
		public unsafe static int Lut2D_Params
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Lut2D_Params, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Lut2D_Params, (void*)(&value));
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x000194E4 File Offset: 0x000176E4
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x0000512E File Offset: 0x0000332E
		public unsafe static int UserLut2D_Params
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_UserLut2D_Params, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_UserLut2D_Params, (void*)(&value));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00019500 File Offset: 0x00017700
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x0000513C File Offset: 0x0000333C
		public unsafe static int PostExposure
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_PostExposure, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_PostExposure, (void*)(&value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x0001951C File Offset: 0x0001771C
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x0000514A File Offset: 0x0000334A
		public unsafe static int ColorBalance
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_ColorBalance, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_ColorBalance, (void*)(&value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x00019538 File Offset: 0x00017738
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00005158 File Offset: 0x00003358
		public unsafe static int ColorFilter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_ColorFilter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_ColorFilter, (void*)(&value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x00019554 File Offset: 0x00017754
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00005166 File Offset: 0x00003366
		public unsafe static int HueSatCon
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_HueSatCon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_HueSatCon, (void*)(&value));
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00019570 File Offset: 0x00017770
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x00005174 File Offset: 0x00003374
		public unsafe static int Brightness
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Brightness, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Brightness, (void*)(&value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x0001958C File Offset: 0x0001778C
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00005182 File Offset: 0x00003382
		public unsafe static int ChannelMixerRed
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_ChannelMixerRed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_ChannelMixerRed, (void*)(&value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x000195A8 File Offset: 0x000177A8
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x00005190 File Offset: 0x00003390
		public unsafe static int ChannelMixerGreen
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_ChannelMixerGreen, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_ChannelMixerGreen, (void*)(&value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x000195C4 File Offset: 0x000177C4
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x0000519E File Offset: 0x0000339E
		public unsafe static int ChannelMixerBlue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_ChannelMixerBlue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_ChannelMixerBlue, (void*)(&value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x000195E0 File Offset: 0x000177E0
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x000051AC File Offset: 0x000033AC
		public unsafe static int Lift
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Lift, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Lift, (void*)(&value));
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x000195FC File Offset: 0x000177FC
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x000051BA File Offset: 0x000033BA
		public unsafe static int InvGamma
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_InvGamma, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_InvGamma, (void*)(&value));
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00019618 File Offset: 0x00017818
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x000051C8 File Offset: 0x000033C8
		public unsafe static int Gain
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Gain, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Gain, (void*)(&value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00019634 File Offset: 0x00017834
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x000051D6 File Offset: 0x000033D6
		public unsafe static int Curves
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Curves, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Curves, (void*)(&value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00019650 File Offset: 0x00017850
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x000051E4 File Offset: 0x000033E4
		public unsafe static int CustomToneCurve
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_CustomToneCurve, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_CustomToneCurve, (void*)(&value));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x0001966C File Offset: 0x0001786C
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x000051F2 File Offset: 0x000033F2
		public unsafe static int ToeSegmentA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_ToeSegmentA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_ToeSegmentA, (void*)(&value));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00019688 File Offset: 0x00017888
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x00005200 File Offset: 0x00003400
		public unsafe static int ToeSegmentB
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_ToeSegmentB, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_ToeSegmentB, (void*)(&value));
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x000196A4 File Offset: 0x000178A4
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x0000520E File Offset: 0x0000340E
		public unsafe static int MidSegmentA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_MidSegmentA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_MidSegmentA, (void*)(&value));
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x000196C0 File Offset: 0x000178C0
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x0000521C File Offset: 0x0000341C
		public unsafe static int MidSegmentB
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_MidSegmentB, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_MidSegmentB, (void*)(&value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x000196DC File Offset: 0x000178DC
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x0000522A File Offset: 0x0000342A
		public unsafe static int ShoSegmentA
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_ShoSegmentA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_ShoSegmentA, (void*)(&value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x000196F8 File Offset: 0x000178F8
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x00005238 File Offset: 0x00003438
		public unsafe static int ShoSegmentB
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_ShoSegmentB, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_ShoSegmentB, (void*)(&value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x00019714 File Offset: 0x00017914
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x00005246 File Offset: 0x00003446
		public unsafe static int Vignette_Color
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Vignette_Color, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Vignette_Color, (void*)(&value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00019730 File Offset: 0x00017930
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00005254 File Offset: 0x00003454
		public unsafe static int Vignette_Center
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Vignette_Center, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Vignette_Center, (void*)(&value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x0001974C File Offset: 0x0001794C
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00005262 File Offset: 0x00003462
		public unsafe static int Vignette_Settings
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Vignette_Settings, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Vignette_Settings, (void*)(&value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00019768 File Offset: 0x00017968
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00005270 File Offset: 0x00003470
		public unsafe static int Vignette_Mask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Vignette_Mask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Vignette_Mask, (void*)(&value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00019784 File Offset: 0x00017984
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x0000527E File Offset: 0x0000347E
		public unsafe static int Vignette_Opacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Vignette_Opacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Vignette_Opacity, (void*)(&value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x000197A0 File Offset: 0x000179A0
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x0000528C File Offset: 0x0000348C
		public unsafe static int Vignette_Mode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Vignette_Mode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Vignette_Mode, (void*)(&value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x000197BC File Offset: 0x000179BC
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x0000529A File Offset: 0x0000349A
		public unsafe static int Grain_Params1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Grain_Params1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Grain_Params1, (void*)(&value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x000197D8 File Offset: 0x000179D8
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x000052A8 File Offset: 0x000034A8
		public unsafe static int Grain_Params2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Grain_Params2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Grain_Params2, (void*)(&value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x000197F4 File Offset: 0x000179F4
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x000052B6 File Offset: 0x000034B6
		public unsafe static int GrainTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_GrainTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_GrainTex, (void*)(&value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x00019810 File Offset: 0x00017A10
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x000052C4 File Offset: 0x000034C4
		public unsafe static int Phase
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Phase, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Phase, (void*)(&value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x0001982C File Offset: 0x00017A2C
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x000052D2 File Offset: 0x000034D2
		public unsafe static int GrainNoiseParameters
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_GrainNoiseParameters, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_GrainNoiseParameters, (void*)(&value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x00019848 File Offset: 0x00017A48
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x000052E0 File Offset: 0x000034E0
		public unsafe static int LumaInAlpha
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_LumaInAlpha, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_LumaInAlpha, (void*)(&value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x00019864 File Offset: 0x00017A64
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x000052EE File Offset: 0x000034EE
		public unsafe static int DitheringTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_DitheringTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_DitheringTex, (void*)(&value));
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00019880 File Offset: 0x00017A80
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x000052FC File Offset: 0x000034FC
		public unsafe static int Dithering_Coords
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Dithering_Coords, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Dithering_Coords, (void*)(&value));
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0001989C File Offset: 0x00017A9C
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x0000530A File Offset: 0x0000350A
		public unsafe static int From
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_From, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_From, (void*)(&value));
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x000198B8 File Offset: 0x00017AB8
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x00005318 File Offset: 0x00003518
		public unsafe static int To
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_To, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_To, (void*)(&value));
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x000198D4 File Offset: 0x00017AD4
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x00005326 File Offset: 0x00003526
		public unsafe static int Interp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_Interp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_Interp, (void*)(&value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x000198F0 File Offset: 0x00017AF0
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x00005334 File Offset: 0x00003534
		public unsafe static int TargetColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_TargetColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_TargetColor, (void*)(&value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0001990C File Offset: 0x00017B0C
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x00005342 File Offset: 0x00003542
		public unsafe static int HalfResFinalCopy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_HalfResFinalCopy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_HalfResFinalCopy, (void*)(&value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00019928 File Offset: 0x00017B28
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x00005350 File Offset: 0x00003550
		public unsafe static int WaveformSource
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_WaveformSource, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_WaveformSource, (void*)(&value));
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00019944 File Offset: 0x00017B44
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x0000535E File Offset: 0x0000355E
		public unsafe static int WaveformBuffer
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_WaveformBuffer, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_WaveformBuffer, (void*)(&value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00019960 File Offset: 0x00017B60
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x0000536C File Offset: 0x0000356C
		public unsafe static int VectorscopeBuffer
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_VectorscopeBuffer, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_VectorscopeBuffer, (void*)(&value));
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x0001997C File Offset: 0x00017B7C
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x0000537A File Offset: 0x0000357A
		public unsafe static int RenderViewportScaleFactor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_RenderViewportScaleFactor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_RenderViewportScaleFactor, (void*)(&value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00019998 File Offset: 0x00017B98
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00005388 File Offset: 0x00003588
		public unsafe static int UVTransform
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_UVTransform, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_UVTransform, (void*)(&value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x000199B4 File Offset: 0x00017BB4
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x00005396 File Offset: 0x00003596
		public unsafe static int DepthSlice
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_DepthSlice, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_DepthSlice, (void*)(&value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x000199D0 File Offset: 0x00017BD0
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x000053A4 File Offset: 0x000035A4
		public unsafe static int UVScaleOffset
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_UVScaleOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_UVScaleOffset, (void*)(&value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x000199EC File Offset: 0x00017BEC
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x000053B2 File Offset: 0x000035B2
		public unsafe static int PosScaleOffset
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderIDs.NativeFieldInfoPtr_PosScaleOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderIDs.NativeFieldInfoPtr_PosScaleOffset, (void*)(&value));
			}
		}

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeFieldInfoPtr_MainTex;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeFieldInfoPtr_Jitter;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeFieldInfoPtr_Sharpness;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeFieldInfoPtr_FinalBlendParameters;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr_HistoryTex;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr_SMAA_Flip;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeFieldInfoPtr_SMAA_Flop;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeFieldInfoPtr_AOParams;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeFieldInfoPtr_AOColor;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeFieldInfoPtr_OcclusionTexture1;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeFieldInfoPtr_OcclusionTexture2;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeFieldInfoPtr_SAOcclusionTexture;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeFieldInfoPtr_MSVOcclusionTexture;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeFieldInfoPtr_DepthCopy;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeFieldInfoPtr_LinearDepth;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeFieldInfoPtr_LowDepth1;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeFieldInfoPtr_LowDepth2;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeFieldInfoPtr_LowDepth3;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_LowDepth4;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_TiledDepth1;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_TiledDepth2;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeFieldInfoPtr_TiledDepth3;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr_TiledDepth4;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_Occlusion1;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr_Occlusion2;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr_Occlusion3;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_Occlusion4;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_Combined1;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr_Combined2;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr_Combined3;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_SSRResolveTemp;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_Noise;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr_Test;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeFieldInfoPtr_Resolve;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeFieldInfoPtr_History;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeFieldInfoPtr_ViewMatrix;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeFieldInfoPtr_InverseViewMatrix;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeFieldInfoPtr_InverseProjectionMatrix;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeFieldInfoPtr_ScreenSpaceProjectionMatrix;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeFieldInfoPtr_Params2;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeFieldInfoPtr_FogColor;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeFieldInfoPtr_FogParams;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeFieldInfoPtr_VelocityScale;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeFieldInfoPtr_MaxBlurRadius;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeFieldInfoPtr_RcpMaxBlurRadius;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeFieldInfoPtr_VelocityTex;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeFieldInfoPtr_Tile2RT;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeFieldInfoPtr_Tile4RT;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeFieldInfoPtr_Tile8RT;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeFieldInfoPtr_TileMaxOffs;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeFieldInfoPtr_TileMaxLoop;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeFieldInfoPtr_TileVRT;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeFieldInfoPtr_NeighborMaxTex;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeFieldInfoPtr_LoopCount;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeFieldInfoPtr_DepthOfFieldTemp;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeFieldInfoPtr_DepthOfFieldTex;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeFieldInfoPtr_Distance;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeFieldInfoPtr_LensCoeff;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeFieldInfoPtr_MaxCoC;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeFieldInfoPtr_RcpMaxCoC;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeFieldInfoPtr_RcpAspect;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeFieldInfoPtr_CoCTex;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeFieldInfoPtr_TaaParams;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeFieldInfoPtr_AutoExposureTex;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeFieldInfoPtr_HistogramBuffer;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeFieldInfoPtr_Params;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr_ScaleOffsetRes;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr_BloomTex;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr_SampleScale;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr_Threshold;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr_ColorIntensity;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr_Bloom_DirtTex;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr_Bloom_Settings;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr_Bloom_Color;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeFieldInfoPtr_Bloom_DirtTileOffset;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_ChromaticAberration_Amount;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_ChromaticAberration_SpectralLut;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_Distortion_CenterScale;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_Distortion_Amount;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_Lut2D;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_Lut3D;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_Lut3D_Params;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_Lut2D_Params;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_UserLut2D_Params;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_PostExposure;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr_ColorBalance;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr_ColorFilter;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr_HueSatCon;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr_Brightness;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeFieldInfoPtr_ChannelMixerRed;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeFieldInfoPtr_ChannelMixerGreen;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeFieldInfoPtr_ChannelMixerBlue;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeFieldInfoPtr_Lift;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeFieldInfoPtr_InvGamma;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeFieldInfoPtr_Gain;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeFieldInfoPtr_Curves;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeFieldInfoPtr_CustomToneCurve;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeFieldInfoPtr_ToeSegmentA;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeFieldInfoPtr_ToeSegmentB;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeFieldInfoPtr_MidSegmentA;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeFieldInfoPtr_MidSegmentB;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeFieldInfoPtr_ShoSegmentA;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeFieldInfoPtr_ShoSegmentB;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeFieldInfoPtr_Vignette_Color;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeFieldInfoPtr_Vignette_Center;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeFieldInfoPtr_Vignette_Settings;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeFieldInfoPtr_Vignette_Mask;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeFieldInfoPtr_Vignette_Opacity;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr_Vignette_Mode;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeFieldInfoPtr_Grain_Params1;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeFieldInfoPtr_Grain_Params2;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeFieldInfoPtr_GrainTex;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeFieldInfoPtr_Phase;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeFieldInfoPtr_GrainNoiseParameters;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeFieldInfoPtr_LumaInAlpha;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeFieldInfoPtr_DitheringTex;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeFieldInfoPtr_Dithering_Coords;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr_From;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeFieldInfoPtr_To;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeFieldInfoPtr_Interp;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeFieldInfoPtr_TargetColor;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeFieldInfoPtr_HalfResFinalCopy;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeFieldInfoPtr_WaveformSource;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr_WaveformBuffer;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr_VectorscopeBuffer;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_RenderViewportScaleFactor;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr_UVTransform;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeFieldInfoPtr_DepthSlice;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeFieldInfoPtr_UVScaleOffset;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeFieldInfoPtr_PosScaleOffset;
	}
}
