using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200002B RID: 43
	[Serializable]
	public sealed class ScalableAO : Object
	{
		// Token: 0x060001CC RID: 460 RVA: 0x0000B154 File Offset: 0x00009354
		// Note: this type is marked as 'beforefieldinit'.
		static ScalableAO()
		{
			Il2CppClassPointerStore<ScalableAO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "ScalableAO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScalableAO>.NativeClassPtr);
			ScalableAO.NativeFieldInfoPtr_m_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableAO>.NativeClassPtr, "m_Result");
			ScalableAO.NativeFieldInfoPtr_m_PropertySheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableAO>.NativeClassPtr, "m_PropertySheet");
			ScalableAO.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableAO>.NativeClassPtr, "m_Settings");
			ScalableAO.NativeFieldInfoPtr_m_MRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableAO>.NativeClassPtr, "m_MRT");
			ScalableAO.NativeFieldInfoPtr_m_SampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableAO>.NativeClassPtr, "m_SampleCount");
			ScalableAO.NativeMethodInfoPtr__ctor_Public_Void_AmbientOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableAO>.NativeClassPtr, 100663412);
			ScalableAO.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_Final_New_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableAO>.NativeClassPtr, 100663413);
			ScalableAO.NativeMethodInfoPtr_DoLazyInitialization_Private_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableAO>.NativeClassPtr, 100663414);
			ScalableAO.NativeMethodInfoPtr_Render_Private_Void_PostProcessRenderContext_CommandBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableAO>.NativeClassPtr, 100663415);
			ScalableAO.NativeMethodInfoPtr_RenderAfterOpaque_Public_Virtual_Final_New_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableAO>.NativeClassPtr, 100663416);
			ScalableAO.NativeMethodInfoPtr_RenderAmbientOnly_Public_Virtual_Final_New_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableAO>.NativeClassPtr, 100663417);
			ScalableAO.NativeMethodInfoPtr_CompositeAmbientOnly_Public_Virtual_Final_New_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableAO>.NativeClassPtr, 100663418);
			ScalableAO.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableAO>.NativeClassPtr, 100663419);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000B288 File Offset: 0x00009488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 444427, RefRangeEnd = 444428, XrefRangeStart = 444416, XrefRangeEnd = 444427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScalableAO(AmbientOcclusion settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScalableAO>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableAO.NativeMethodInfoPtr__ctor_Public_Void_AmbientOcclusion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000B2D4 File Offset: 0x000094D4
		[CallerCount(0)]
		public unsafe DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableAO.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_Final_New_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000B310 File Offset: 0x00009510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 444452, RefRangeEnd = 444453, XrefRangeStart = 444428, XrefRangeEnd = 444452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoLazyInitialization(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableAO.NativeMethodInfoPtr_DoLazyInitialization_Private_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000B354 File Offset: 0x00009554
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 444520, RefRangeEnd = 444522, XrefRangeStart = 444453, XrefRangeEnd = 444520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref occlusionSource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableAO.NativeMethodInfoPtr_Render_Private_Void_PostProcessRenderContext_CommandBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000B3B8 File Offset: 0x000095B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444522, XrefRangeEnd = 444543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderAfterOpaque(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableAO.NativeMethodInfoPtr_RenderAfterOpaque_Public_Virtual_Final_New_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000B3FC File Offset: 0x000095FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444543, XrefRangeEnd = 444556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderAmbientOnly(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableAO.NativeMethodInfoPtr_RenderAmbientOnly_Public_Virtual_Final_New_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000B440 File Offset: 0x00009640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444556, XrefRangeEnd = 444583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompositeAmbientOnly(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableAO.NativeMethodInfoPtr_CompositeAmbientOnly_Public_Virtual_Final_New_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000B484 File Offset: 0x00009684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444583, XrefRangeEnd = 444587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableAO.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000032A7 File Offset: 0x000014A7
		public ScalableAO(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000B4B8 File Offset: 0x000096B8
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x000032B0 File Offset: 0x000014B0
		public unsafe RenderTexture m_Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableAO.NativeFieldInfoPtr_m_Result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableAO.NativeFieldInfoPtr_m_Result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000B4E8 File Offset: 0x000096E8
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x000032CF File Offset: 0x000014CF
		public unsafe PropertySheet m_PropertySheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableAO.NativeFieldInfoPtr_m_PropertySheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertySheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableAO.NativeFieldInfoPtr_m_PropertySheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000B518 File Offset: 0x00009718
		// (set) Token: 0x060001DB RID: 475 RVA: 0x000032EE File Offset: 0x000014EE
		public unsafe AmbientOcclusion m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableAO.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmbientOcclusion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableAO.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000B548 File Offset: 0x00009748
		// (set) Token: 0x060001DD RID: 477 RVA: 0x0000330D File Offset: 0x0000150D
		public unsafe Il2CppStructArray<RenderTargetIdentifier> m_MRT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableAO.NativeFieldInfoPtr_m_MRT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableAO.NativeFieldInfoPtr_m_MRT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000B578 File Offset: 0x00009778
		// (set) Token: 0x060001DF RID: 479 RVA: 0x0000332C File Offset: 0x0000152C
		public unsafe Il2CppStructArray<int> m_SampleCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableAO.NativeFieldInfoPtr_m_SampleCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScalableAO.NativeFieldInfoPtr_m_SampleCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_m_Result;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertySheet;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeFieldInfoPtr_m_MRT;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeFieldInfoPtr_m_SampleCount;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AmbientOcclusion_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_Final_New_DepthTextureMode_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_DoLazyInitialization_Private_Void_PostProcessRenderContext_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_Render_Private_Void_PostProcessRenderContext_CommandBuffer_Int32_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_RenderAfterOpaque_Public_Virtual_Final_New_Void_PostProcessRenderContext_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_RenderAmbientOnly_Public_Virtual_Final_New_Void_PostProcessRenderContext_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_CompositeAmbientOnly_Public_Virtual_Final_New_Void_PostProcessRenderContext_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_0;

		// Token: 0x02000070 RID: 112
		[OriginalName("Unity.Postprocessing.Runtime.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x0400049B RID: 1179
			OcclusionEstimationForward,
			// Token: 0x0400049C RID: 1180
			OcclusionEstimationDeferred,
			// Token: 0x0400049D RID: 1181
			HorizontalBlurForward,
			// Token: 0x0400049E RID: 1182
			HorizontalBlurDeferred,
			// Token: 0x0400049F RID: 1183
			VerticalBlur,
			// Token: 0x040004A0 RID: 1184
			CompositionForward,
			// Token: 0x040004A1 RID: 1185
			CompositionDeferred,
			// Token: 0x040004A2 RID: 1186
			DebugOverlay
		}
	}
}
