using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200001C RID: 28
	public sealed class ColorGradingRenderer : PostProcessEffectRenderer<ColorGrading>
	{
		// Token: 0x0600010D RID: 269 RVA: 0x000089A8 File Offset: 0x00006BA8
		// Note: this type is marked as 'beforefieldinit'.
		static ColorGradingRenderer()
		{
			Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "ColorGradingRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr);
			ColorGradingRenderer.NativeFieldInfoPtr_m_GradingCurves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, "m_GradingCurves");
			ColorGradingRenderer.NativeFieldInfoPtr_m_Pixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, "m_Pixels");
			ColorGradingRenderer.NativeFieldInfoPtr_m_InternalLdrLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, "m_InternalLdrLut");
			ColorGradingRenderer.NativeFieldInfoPtr_m_InternalLogLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, "m_InternalLogLut");
			ColorGradingRenderer.NativeFieldInfoPtr_k_Lut2DSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, "k_Lut2DSize");
			ColorGradingRenderer.NativeFieldInfoPtr_k_Lut3DSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, "k_Lut3DSize");
			ColorGradingRenderer.NativeFieldInfoPtr_m_HableCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, "m_HableCurve");
			ColorGradingRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, 100663343);
			ColorGradingRenderer.NativeMethodInfoPtr_RenderExternalPipeline3D_Private_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, 100663344);
			ColorGradingRenderer.NativeMethodInfoPtr_RenderHDRPipeline3D_Private_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, 100663345);
			ColorGradingRenderer.NativeMethodInfoPtr_RenderHDRPipeline2D_Private_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, 100663346);
			ColorGradingRenderer.NativeMethodInfoPtr_RenderLDRPipeline2D_Private_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, 100663347);
			ColorGradingRenderer.NativeMethodInfoPtr_CheckInternalLogLut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, 100663348);
			ColorGradingRenderer.NativeMethodInfoPtr_CheckInternalStripLut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, 100663349);
			ColorGradingRenderer.NativeMethodInfoPtr_GetCurveTexture_Private_Texture2D_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, 100663350);
			ColorGradingRenderer.NativeMethodInfoPtr_IsRenderTextureFormatSupportedForLinearFiltering_Private_Static_Boolean_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, 100663351);
			ColorGradingRenderer.NativeMethodInfoPtr_GetLutFormat_Private_Static_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, 100663352);
			ColorGradingRenderer.NativeMethodInfoPtr_GetCurveFormat_Private_Static_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, 100663353);
			ColorGradingRenderer.NativeMethodInfoPtr_Release_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, 100663354);
			ColorGradingRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr, 100663355);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00008B68 File Offset: 0x00006D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442445, XrefRangeEnd = 442466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00008BAC File Offset: 0x00006DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442466, XrefRangeEnd = 442496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderExternalPipeline3D(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingRenderer.NativeMethodInfoPtr_RenderExternalPipeline3D_Private_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00008BF0 File Offset: 0x00006DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442496, XrefRangeEnd = 442604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderHDRPipeline3D(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingRenderer.NativeMethodInfoPtr_RenderHDRPipeline3D_Private_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00008C34 File Offset: 0x00006E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442604, XrefRangeEnd = 442776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderHDRPipeline2D(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingRenderer.NativeMethodInfoPtr_RenderHDRPipeline2D_Private_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00008C78 File Offset: 0x00006E78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 442914, RefRangeEnd = 442915, XrefRangeStart = 442776, XrefRangeEnd = 442914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderLDRPipeline2D(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingRenderer.NativeMethodInfoPtr_RenderLDRPipeline2D_Private_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00008CBC File Offset: 0x00006EBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 442961, RefRangeEnd = 442962, XrefRangeStart = 442915, XrefRangeEnd = 442961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckInternalLogLut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingRenderer.NativeMethodInfoPtr_CheckInternalLogLut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00008CF0 File Offset: 0x00006EF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 443004, RefRangeEnd = 443006, XrefRangeStart = 442962, XrefRangeEnd = 443004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckInternalStripLut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingRenderer.NativeMethodInfoPtr_CheckInternalStripLut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00008D24 File Offset: 0x00006F24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 443039, RefRangeEnd = 443042, XrefRangeStart = 443006, XrefRangeEnd = 443039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GetCurveTexture(bool hdr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hdr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingRenderer.NativeMethodInfoPtr_GetCurveTexture_Private_Texture2D_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00008D70 File Offset: 0x00006F70
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 443054, RefRangeEnd = 443060, XrefRangeStart = 443042, XrefRangeEnd = 443054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingRenderer.NativeMethodInfoPtr_IsRenderTextureFormatSupportedForLinearFiltering_Private_Static_Boolean_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00008DB0 File Offset: 0x00006FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443060, XrefRangeEnd = 443062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTextureFormat GetLutFormat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingRenderer.NativeMethodInfoPtr_GetLutFormat_Private_Static_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00008DE0 File Offset: 0x00006FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443062, XrefRangeEnd = 443063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextureFormat GetCurveFormat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingRenderer.NativeMethodInfoPtr_GetCurveFormat_Private_Static_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00008E10 File Offset: 0x00007010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443063, XrefRangeEnd = 443069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingRenderer.NativeMethodInfoPtr_Release_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00008E44 File Offset: 0x00007044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443069, XrefRangeEnd = 443077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorGradingRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002CBD File Offset: 0x00000EBD
		public ColorGradingRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00008E80 File Offset: 0x00007080
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002CC6 File Offset: 0x00000EC6
		public unsafe Texture2D m_GradingCurves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingRenderer.NativeFieldInfoPtr_m_GradingCurves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingRenderer.NativeFieldInfoPtr_m_GradingCurves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00008EB0 File Offset: 0x000070B0
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002CE5 File Offset: 0x00000EE5
		public unsafe Il2CppStructArray<Color> m_Pixels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingRenderer.NativeFieldInfoPtr_m_Pixels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingRenderer.NativeFieldInfoPtr_m_Pixels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00008EE0 File Offset: 0x000070E0
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002D04 File Offset: 0x00000F04
		public unsafe RenderTexture m_InternalLdrLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingRenderer.NativeFieldInfoPtr_m_InternalLdrLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingRenderer.NativeFieldInfoPtr_m_InternalLdrLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00008F10 File Offset: 0x00007110
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00002D23 File Offset: 0x00000F23
		public unsafe RenderTexture m_InternalLogLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingRenderer.NativeFieldInfoPtr_m_InternalLogLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingRenderer.NativeFieldInfoPtr_m_InternalLogLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00008F40 File Offset: 0x00007140
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00002D42 File Offset: 0x00000F42
		public unsafe static int k_Lut2DSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ColorGradingRenderer.NativeFieldInfoPtr_k_Lut2DSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorGradingRenderer.NativeFieldInfoPtr_k_Lut2DSize, (void*)(&value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00008F5C File Offset: 0x0000715C
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00002D50 File Offset: 0x00000F50
		public unsafe static int k_Lut3DSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ColorGradingRenderer.NativeFieldInfoPtr_k_Lut3DSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorGradingRenderer.NativeFieldInfoPtr_k_Lut3DSize, (void*)(&value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00008F78 File Offset: 0x00007178
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002D5E File Offset: 0x00000F5E
		public unsafe HableCurve m_HableCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingRenderer.NativeFieldInfoPtr_m_HableCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HableCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingRenderer.NativeFieldInfoPtr_m_HableCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_m_GradingCurves;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_m_Pixels;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalLdrLut;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalLogLut;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_k_Lut2DSize;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_k_Lut3DSize;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_m_HableCurve;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_RenderExternalPipeline3D_Private_Void_PostProcessRenderContext_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_RenderHDRPipeline3D_Private_Void_PostProcessRenderContext_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_RenderHDRPipeline2D_Private_Void_PostProcessRenderContext_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_RenderLDRPipeline2D_Private_Void_PostProcessRenderContext_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_CheckInternalLogLut_Private_Void_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_CheckInternalStripLut_Private_Void_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_GetCurveTexture_Private_Texture2D_Boolean_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderTextureFormatSupportedForLinearFiltering_Private_Static_Boolean_RenderTextureFormat_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_GetLutFormat_Private_Static_RenderTextureFormat_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_GetCurveFormat_Private_Static_TextureFormat_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200006B RID: 107
		[OriginalName("Unity.Postprocessing.Runtime.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x04000478 RID: 1144
			LutGenLDRFromScratch,
			// Token: 0x04000479 RID: 1145
			LutGenLDR,
			// Token: 0x0400047A RID: 1146
			LutGenHDR2D
		}
	}
}
