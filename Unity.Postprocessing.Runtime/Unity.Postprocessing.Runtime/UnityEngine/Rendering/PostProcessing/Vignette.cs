using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000036 RID: 54
	[Serializable]
	public sealed class Vignette : PostProcessEffectSettings
	{
		// Token: 0x0600023F RID: 575 RVA: 0x0000C688 File Offset: 0x0000A888
		// Note: this type is marked as 'beforefieldinit'.
		static Vignette()
		{
			Il2CppClassPointerStore<Vignette>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "Vignette");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vignette>.NativeClassPtr);
			Vignette.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vignette>.NativeClassPtr, "mode");
			Vignette.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vignette>.NativeClassPtr, "color");
			Vignette.NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vignette>.NativeClassPtr, "center");
			Vignette.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vignette>.NativeClassPtr, "intensity");
			Vignette.NativeFieldInfoPtr_smoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vignette>.NativeClassPtr, "smoothness");
			Vignette.NativeFieldInfoPtr_roundness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vignette>.NativeClassPtr, "roundness");
			Vignette.NativeFieldInfoPtr_rounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vignette>.NativeClassPtr, "rounded");
			Vignette.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vignette>.NativeClassPtr, "mask");
			Vignette.NativeFieldInfoPtr_opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vignette>.NativeClassPtr, "opacity");
			Vignette.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vignette>.NativeClassPtr, 100663450);
			Vignette.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vignette>.NativeClassPtr, 100663451);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000C794 File Offset: 0x0000A994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445163, XrefRangeEnd = 445164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vignette.NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000C7E4 File Offset: 0x0000A9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445164, XrefRangeEnd = 445208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vignette()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vignette>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vignette.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00003708 File Offset: 0x00001908
		public Vignette(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0000C820 File Offset: 0x0000AA20
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00003711 File Offset: 0x00001911
		public unsafe VignetteModeParameter mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_mode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VignetteModeParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_mode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000C850 File Offset: 0x0000AA50
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00003730 File Offset: 0x00001930
		public unsafe ColorParameter color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0000C880 File Offset: 0x0000AA80
		// (set) Token: 0x06000248 RID: 584 RVA: 0x0000374F File Offset: 0x0000194F
		public unsafe Vector2Parameter center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_center);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2Parameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_center), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000C8B0 File Offset: 0x0000AAB0
		// (set) Token: 0x0600024A RID: 586 RVA: 0x0000376E File Offset: 0x0000196E
		public unsafe FloatParameter intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_intensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000C8E0 File Offset: 0x0000AAE0
		// (set) Token: 0x0600024C RID: 588 RVA: 0x0000378D File Offset: 0x0000198D
		public unsafe FloatParameter smoothness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_smoothness);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_smoothness), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000C910 File Offset: 0x0000AB10
		// (set) Token: 0x0600024E RID: 590 RVA: 0x000037AC File Offset: 0x000019AC
		public unsafe FloatParameter roundness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_roundness);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_roundness), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000C940 File Offset: 0x0000AB40
		// (set) Token: 0x06000250 RID: 592 RVA: 0x000037CB File Offset: 0x000019CB
		public unsafe BoolParameter rounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_rounded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_rounded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000C970 File Offset: 0x0000AB70
		// (set) Token: 0x06000252 RID: 594 RVA: 0x000037EA File Offset: 0x000019EA
		public unsafe TextureParameter mask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_mask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_mask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000C9A0 File Offset: 0x0000ABA0
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00003809 File Offset: 0x00001A09
		public unsafe FloatParameter opacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_opacity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vignette.NativeFieldInfoPtr_opacity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_center;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr_smoothness;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr_roundness;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr_rounded;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr_mask;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr_opacity;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_IsEnabledAndSupported_Public_Virtual_Boolean_PostProcessRenderContext_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
