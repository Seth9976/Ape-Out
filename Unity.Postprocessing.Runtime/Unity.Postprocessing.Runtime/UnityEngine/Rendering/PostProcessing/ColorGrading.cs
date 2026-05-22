using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200001B RID: 27
	[Serializable]
	public sealed class ColorGrading : PostProcessEffectSettings
	{
		// Token: 0x060000BB RID: 187 RVA: 0x00007E68 File Offset: 0x00006068
		// Note: this type is marked as 'beforefieldinit'.
		static ColorGrading()
		{
			Il2CppClassPointerStore<ColorGrading>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "ColorGrading");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr);
			ColorGrading.NativeFieldInfoPtr_gradingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "gradingMode");
			ColorGrading.NativeFieldInfoPtr_externalLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "externalLut");
			ColorGrading.NativeFieldInfoPtr_tonemapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "tonemapper");
			ColorGrading.NativeFieldInfoPtr_toneCurveToeStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "toneCurveToeStrength");
			ColorGrading.NativeFieldInfoPtr_toneCurveToeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "toneCurveToeLength");
			ColorGrading.NativeFieldInfoPtr_toneCurveShoulderStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "toneCurveShoulderStrength");
			ColorGrading.NativeFieldInfoPtr_toneCurveShoulderLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "toneCurveShoulderLength");
			ColorGrading.NativeFieldInfoPtr_toneCurveShoulderAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "toneCurveShoulderAngle");
			ColorGrading.NativeFieldInfoPtr_toneCurveGamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "toneCurveGamma");
			ColorGrading.NativeFieldInfoPtr_ldrLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "ldrLut");
			ColorGrading.NativeFieldInfoPtr_ldrLutContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "ldrLutContribution");
			ColorGrading.NativeFieldInfoPtr_temperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "temperature");
			ColorGrading.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "tint");
			ColorGrading.NativeFieldInfoPtr_colorFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "colorFilter");
			ColorGrading.NativeFieldInfoPtr_hueShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "hueShift");
			ColorGrading.NativeFieldInfoPtr_saturation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "saturation");
			ColorGrading.NativeFieldInfoPtr_brightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "brightness");
			ColorGrading.NativeFieldInfoPtr_postExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "postExposure");
			ColorGrading.NativeFieldInfoPtr_contrast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "contrast");
			ColorGrading.NativeFieldInfoPtr_mixerRedOutRedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "mixerRedOutRedIn");
			ColorGrading.NativeFieldInfoPtr_mixerRedOutGreenIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "mixerRedOutGreenIn");
			ColorGrading.NativeFieldInfoPtr_mixerRedOutBlueIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "mixerRedOutBlueIn");
			ColorGrading.NativeFieldInfoPtr_mixerGreenOutRedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "mixerGreenOutRedIn");
			ColorGrading.NativeFieldInfoPtr_mixerGreenOutGreenIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "mixerGreenOutGreenIn");
			ColorGrading.NativeFieldInfoPtr_mixerGreenOutBlueIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "mixerGreenOutBlueIn");
			ColorGrading.NativeFieldInfoPtr_mixerBlueOutRedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "mixerBlueOutRedIn");
			ColorGrading.NativeFieldInfoPtr_mixerBlueOutGreenIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "mixerBlueOutGreenIn");
			ColorGrading.NativeFieldInfoPtr_mixerBlueOutBlueIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "mixerBlueOutBlueIn");
			ColorGrading.NativeFieldInfoPtr_lift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "lift");
			ColorGrading.NativeFieldInfoPtr_gamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "gamma");
			ColorGrading.NativeFieldInfoPtr_gain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "gain");
			ColorGrading.NativeFieldInfoPtr_masterCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "masterCurve");
			ColorGrading.NativeFieldInfoPtr_redCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "redCurve");
			ColorGrading.NativeFieldInfoPtr_greenCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "greenCurve");
			ColorGrading.NativeFieldInfoPtr_blueCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "blueCurve");
			ColorGrading.NativeFieldInfoPtr_hueVsHueCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "hueVsHueCurve");
			ColorGrading.NativeFieldInfoPtr_hueVsSatCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "hueVsSatCurve");
			ColorGrading.NativeFieldInfoPtr_satVsSatCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "satVsSatCurve");
			ColorGrading.NativeFieldInfoPtr_lumVsSatCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, "lumVsSatCurve");
			ColorGrading.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, 100663341);
			ColorGrading.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr, 100663342);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000081CC File Offset: 0x000063CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442179, XrefRangeEnd = 442183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGrading.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000821C File Offset: 0x0000641C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442183, XrefRangeEnd = 442445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorGrading()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGrading>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGrading.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000027FB File Offset: 0x000009FB
		public ColorGrading(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00008258 File Offset: 0x00006458
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002804 File Offset: 0x00000A04
		public unsafe GradingModeParameter gradingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_gradingMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GradingModeParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_gradingMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00008288 File Offset: 0x00006488
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002823 File Offset: 0x00000A23
		public unsafe TextureParameter externalLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_externalLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_externalLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000082B8 File Offset: 0x000064B8
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002842 File Offset: 0x00000A42
		public unsafe TonemapperParameter tonemapper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_tonemapper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TonemapperParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_tonemapper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000082E8 File Offset: 0x000064E8
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002861 File Offset: 0x00000A61
		public unsafe FloatParameter toneCurveToeStrength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_toneCurveToeStrength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_toneCurveToeStrength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00008318 File Offset: 0x00006518
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00002880 File Offset: 0x00000A80
		public unsafe FloatParameter toneCurveToeLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_toneCurveToeLength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_toneCurveToeLength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00008348 File Offset: 0x00006548
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0000289F File Offset: 0x00000A9F
		public unsafe FloatParameter toneCurveShoulderStrength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_toneCurveShoulderStrength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_toneCurveShoulderStrength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00008378 File Offset: 0x00006578
		// (set) Token: 0x060000CC RID: 204 RVA: 0x000028BE File Offset: 0x00000ABE
		public unsafe FloatParameter toneCurveShoulderLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_toneCurveShoulderLength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_toneCurveShoulderLength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000083A8 File Offset: 0x000065A8
		// (set) Token: 0x060000CE RID: 206 RVA: 0x000028DD File Offset: 0x00000ADD
		public unsafe FloatParameter toneCurveShoulderAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_toneCurveShoulderAngle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_toneCurveShoulderAngle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000083D8 File Offset: 0x000065D8
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x000028FC File Offset: 0x00000AFC
		public unsafe FloatParameter toneCurveGamma
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_toneCurveGamma);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_toneCurveGamma), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00008408 File Offset: 0x00006608
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000291B File Offset: 0x00000B1B
		public unsafe TextureParameter ldrLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_ldrLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_ldrLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00008438 File Offset: 0x00006638
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000293A File Offset: 0x00000B3A
		public unsafe FloatParameter ldrLutContribution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_ldrLutContribution);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_ldrLutContribution), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00008468 File Offset: 0x00006668
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002959 File Offset: 0x00000B59
		public unsafe FloatParameter temperature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_temperature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_temperature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00008498 File Offset: 0x00006698
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002978 File Offset: 0x00000B78
		public unsafe FloatParameter tint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_tint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_tint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000084C8 File Offset: 0x000066C8
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00002997 File Offset: 0x00000B97
		public unsafe ColorParameter colorFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_colorFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_colorFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000084F8 File Offset: 0x000066F8
		// (set) Token: 0x060000DC RID: 220 RVA: 0x000029B6 File Offset: 0x00000BB6
		public unsafe FloatParameter hueShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_hueShift);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_hueShift), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00008528 File Offset: 0x00006728
		// (set) Token: 0x060000DE RID: 222 RVA: 0x000029D5 File Offset: 0x00000BD5
		public unsafe FloatParameter saturation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_saturation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_saturation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00008558 File Offset: 0x00006758
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x000029F4 File Offset: 0x00000BF4
		public unsafe FloatParameter brightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_brightness);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_brightness), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00008588 File Offset: 0x00006788
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002A13 File Offset: 0x00000C13
		public unsafe FloatParameter postExposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_postExposure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_postExposure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000085B8 File Offset: 0x000067B8
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002A32 File Offset: 0x00000C32
		public unsafe FloatParameter contrast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_contrast);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_contrast), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000085E8 File Offset: 0x000067E8
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002A51 File Offset: 0x00000C51
		public unsafe FloatParameter mixerRedOutRedIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerRedOutRedIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerRedOutRedIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00008618 File Offset: 0x00006818
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002A70 File Offset: 0x00000C70
		public unsafe FloatParameter mixerRedOutGreenIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerRedOutGreenIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerRedOutGreenIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00008648 File Offset: 0x00006848
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002A8F File Offset: 0x00000C8F
		public unsafe FloatParameter mixerRedOutBlueIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerRedOutBlueIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerRedOutBlueIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00008678 File Offset: 0x00006878
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00002AAE File Offset: 0x00000CAE
		public unsafe FloatParameter mixerGreenOutRedIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerGreenOutRedIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerGreenOutRedIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000086A8 File Offset: 0x000068A8
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002ACD File Offset: 0x00000CCD
		public unsafe FloatParameter mixerGreenOutGreenIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerGreenOutGreenIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerGreenOutGreenIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000086D8 File Offset: 0x000068D8
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002AEC File Offset: 0x00000CEC
		public unsafe FloatParameter mixerGreenOutBlueIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerGreenOutBlueIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerGreenOutBlueIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00008708 File Offset: 0x00006908
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002B0B File Offset: 0x00000D0B
		public unsafe FloatParameter mixerBlueOutRedIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerBlueOutRedIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerBlueOutRedIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00008738 File Offset: 0x00006938
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002B2A File Offset: 0x00000D2A
		public unsafe FloatParameter mixerBlueOutGreenIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerBlueOutGreenIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerBlueOutGreenIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00008768 File Offset: 0x00006968
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002B49 File Offset: 0x00000D49
		public unsafe FloatParameter mixerBlueOutBlueIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerBlueOutBlueIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_mixerBlueOutBlueIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00008798 File Offset: 0x00006998
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002B68 File Offset: 0x00000D68
		public unsafe Vector4Parameter lift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_lift);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector4Parameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_lift), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000087C8 File Offset: 0x000069C8
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002B87 File Offset: 0x00000D87
		public unsafe Vector4Parameter gamma
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_gamma);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector4Parameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_gamma), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000087F8 File Offset: 0x000069F8
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002BA6 File Offset: 0x00000DA6
		public unsafe Vector4Parameter gain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_gain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector4Parameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_gain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00008828 File Offset: 0x00006A28
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002BC5 File Offset: 0x00000DC5
		public unsafe SplineParameter masterCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_masterCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SplineParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_masterCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00008858 File Offset: 0x00006A58
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002BE4 File Offset: 0x00000DE4
		public unsafe SplineParameter redCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_redCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SplineParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_redCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00008888 File Offset: 0x00006A88
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002C03 File Offset: 0x00000E03
		public unsafe SplineParameter greenCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_greenCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SplineParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_greenCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000088B8 File Offset: 0x00006AB8
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00002C22 File Offset: 0x00000E22
		public unsafe SplineParameter blueCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_blueCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SplineParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_blueCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000088E8 File Offset: 0x00006AE8
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002C41 File Offset: 0x00000E41
		public unsafe SplineParameter hueVsHueCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_hueVsHueCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SplineParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_hueVsHueCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00008918 File Offset: 0x00006B18
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00002C60 File Offset: 0x00000E60
		public unsafe SplineParameter hueVsSatCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_hueVsSatCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SplineParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_hueVsSatCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00008948 File Offset: 0x00006B48
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00002C7F File Offset: 0x00000E7F
		public unsafe SplineParameter satVsSatCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_satVsSatCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SplineParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_satVsSatCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00008978 File Offset: 0x00006B78
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002C9E File Offset: 0x00000E9E
		public unsafe SplineParameter lumVsSatCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_lumVsSatCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SplineParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGrading.NativeFieldInfoPtr_lumVsSatCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_gradingMode;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_externalLut;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_tonemapper;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_toneCurveToeStrength;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_toneCurveToeLength;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_toneCurveShoulderStrength;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_toneCurveShoulderLength;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_toneCurveShoulderAngle;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_toneCurveGamma;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_ldrLut;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_ldrLutContribution;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_temperature;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_tint;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_colorFilter;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_hueShift;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_saturation;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_brightness;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_postExposure;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_contrast;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_mixerRedOutRedIn;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_mixerRedOutGreenIn;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_mixerRedOutBlueIn;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_mixerGreenOutRedIn;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_mixerGreenOutGreenIn;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_mixerGreenOutBlueIn;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_mixerBlueOutRedIn;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_mixerBlueOutGreenIn;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_mixerBlueOutBlueIn;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_lift;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_gamma;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_gain;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_masterCurve;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_redCurve;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_greenCurve;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_blueCurve;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_hueVsHueCurve;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_hueVsSatCurve;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_satVsSatCurve;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_lumVsSatCurve;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
