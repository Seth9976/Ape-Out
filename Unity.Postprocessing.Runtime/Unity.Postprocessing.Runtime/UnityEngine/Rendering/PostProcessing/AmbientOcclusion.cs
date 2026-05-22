using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200000C RID: 12
	[Serializable]
	public sealed class AmbientOcclusion : PostProcessEffectSettings
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000066E8 File Offset: 0x000048E8
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientOcclusion()
		{
			Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "AmbientOcclusion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr);
			AmbientOcclusion.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr, "mode");
			AmbientOcclusion.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr, "intensity");
			AmbientOcclusion.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr, "color");
			AmbientOcclusion.NativeFieldInfoPtr_ambientOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr, "ambientOnly");
			AmbientOcclusion.NativeFieldInfoPtr_noiseFilterTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr, "noiseFilterTolerance");
			AmbientOcclusion.NativeFieldInfoPtr_blurTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr, "blurTolerance");
			AmbientOcclusion.NativeFieldInfoPtr_upsampleTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr, "upsampleTolerance");
			AmbientOcclusion.NativeFieldInfoPtr_thicknessModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr, "thicknessModifier");
			AmbientOcclusion.NativeFieldInfoPtr_directLightingStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr, "directLightingStrength");
			AmbientOcclusion.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr, "radius");
			AmbientOcclusion.NativeFieldInfoPtr_quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr, "quality");
			AmbientOcclusion.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr, 100663306);
			AmbientOcclusion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr, 100663307);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000681C File Offset: 0x00004A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441581, XrefRangeEnd = 441626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusion.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000686C File Offset: 0x00004A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441626, XrefRangeEnd = 441677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientOcclusion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientOcclusion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000223F File Offset: 0x0000043F
		public AmbientOcclusion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000068A8 File Offset: 0x00004AA8
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002248 File Offset: 0x00000448
		public unsafe AmbientOcclusionModeParameter mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_mode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmbientOcclusionModeParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_mode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000068D8 File Offset: 0x00004AD8
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002267 File Offset: 0x00000467
		public unsafe FloatParameter intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_intensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00006908 File Offset: 0x00004B08
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002286 File Offset: 0x00000486
		public unsafe ColorParameter color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00006938 File Offset: 0x00004B38
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000022A5 File Offset: 0x000004A5
		public unsafe BoolParameter ambientOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_ambientOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_ambientOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00006968 File Offset: 0x00004B68
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000022C4 File Offset: 0x000004C4
		public unsafe FloatParameter noiseFilterTolerance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_noiseFilterTolerance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_noiseFilterTolerance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00006998 File Offset: 0x00004B98
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000022E3 File Offset: 0x000004E3
		public unsafe FloatParameter blurTolerance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_blurTolerance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_blurTolerance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000069C8 File Offset: 0x00004BC8
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002302 File Offset: 0x00000502
		public unsafe FloatParameter upsampleTolerance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_upsampleTolerance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_upsampleTolerance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000069F8 File Offset: 0x00004BF8
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002321 File Offset: 0x00000521
		public unsafe FloatParameter thicknessModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_thicknessModifier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_thicknessModifier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00006A28 File Offset: 0x00004C28
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002340 File Offset: 0x00000540
		public unsafe FloatParameter directLightingStrength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_directLightingStrength);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_directLightingStrength), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00006A58 File Offset: 0x00004C58
		// (set) Token: 0x06000047 RID: 71 RVA: 0x0000235F File Offset: 0x0000055F
		public unsafe FloatParameter radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_radius);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_radius), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00006A88 File Offset: 0x00004C88
		// (set) Token: 0x06000049 RID: 73 RVA: 0x0000237E File Offset: 0x0000057E
		public unsafe AmbientOcclusionQualityParameter quality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_quality);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmbientOcclusionQualityParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusion.NativeFieldInfoPtr_quality), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_ambientOnly;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_noiseFilterTolerance;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_blurTolerance;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_upsampleTolerance;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_thicknessModifier;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_directLightingStrength;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_quality;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
