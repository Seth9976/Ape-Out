using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000030 RID: 48
	[Serializable]
	public sealed class ScreenSpaceReflections : PostProcessEffectSettings
	{
		// Token: 0x060001E6 RID: 486 RVA: 0x0000B620 File Offset: 0x00009820
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenSpaceReflections()
		{
			Il2CppClassPointerStore<ScreenSpaceReflections>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "ScreenSpaceReflections");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceReflections>.NativeClassPtr);
			ScreenSpaceReflections.NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflections>.NativeClassPtr, "preset");
			ScreenSpaceReflections.NativeFieldInfoPtr_maximumIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflections>.NativeClassPtr, "maximumIterationCount");
			ScreenSpaceReflections.NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflections>.NativeClassPtr, "resolution");
			ScreenSpaceReflections.NativeFieldInfoPtr_thickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflections>.NativeClassPtr, "thickness");
			ScreenSpaceReflections.NativeFieldInfoPtr_maximumMarchDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflections>.NativeClassPtr, "maximumMarchDistance");
			ScreenSpaceReflections.NativeFieldInfoPtr_distanceFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflections>.NativeClassPtr, "distanceFade");
			ScreenSpaceReflections.NativeFieldInfoPtr_vignette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceReflections>.NativeClassPtr, "vignette");
			ScreenSpaceReflections.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflections>.NativeClassPtr, 100663422);
			ScreenSpaceReflections.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceReflections>.NativeClassPtr, 100663423);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000B704 File Offset: 0x00009904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444593, XrefRangeEnd = 444608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflections.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000B754 File Offset: 0x00009954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444608, XrefRangeEnd = 444642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenSpaceReflections()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceReflections>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenSpaceReflections.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000033CF File Offset: 0x000015CF
		public ScreenSpaceReflections(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000B790 File Offset: 0x00009990
		// (set) Token: 0x060001EB RID: 491 RVA: 0x000033D8 File Offset: 0x000015D8
		public unsafe ScreenSpaceReflectionPresetParameter preset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflections.NativeFieldInfoPtr_preset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenSpaceReflectionPresetParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflections.NativeFieldInfoPtr_preset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000B7C0 File Offset: 0x000099C0
		// (set) Token: 0x060001ED RID: 493 RVA: 0x000033F7 File Offset: 0x000015F7
		public unsafe IntParameter maximumIterationCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflections.NativeFieldInfoPtr_maximumIterationCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflections.NativeFieldInfoPtr_maximumIterationCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000B7F0 File Offset: 0x000099F0
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00003416 File Offset: 0x00001616
		public unsafe ScreenSpaceReflectionResolutionParameter resolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflections.NativeFieldInfoPtr_resolution);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenSpaceReflectionResolutionParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflections.NativeFieldInfoPtr_resolution), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000B820 File Offset: 0x00009A20
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00003435 File Offset: 0x00001635
		public unsafe FloatParameter thickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflections.NativeFieldInfoPtr_thickness);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflections.NativeFieldInfoPtr_thickness), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000B850 File Offset: 0x00009A50
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00003454 File Offset: 0x00001654
		public unsafe FloatParameter maximumMarchDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflections.NativeFieldInfoPtr_maximumMarchDistance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflections.NativeFieldInfoPtr_maximumMarchDistance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000B880 File Offset: 0x00009A80
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00003473 File Offset: 0x00001673
		public unsafe FloatParameter distanceFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflections.NativeFieldInfoPtr_distanceFade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflections.NativeFieldInfoPtr_distanceFade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00003492 File Offset: 0x00001692
		public unsafe FloatParameter vignette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflections.NativeFieldInfoPtr_vignette);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenSpaceReflections.NativeFieldInfoPtr_vignette), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_preset;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr_maximumIterationCount;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr_resolution;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_thickness;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_maximumMarchDistance;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_distanceFade;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_vignette;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
