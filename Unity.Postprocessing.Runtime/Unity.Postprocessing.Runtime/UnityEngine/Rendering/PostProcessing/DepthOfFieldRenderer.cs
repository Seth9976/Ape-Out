using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000020 RID: 32
	public sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField>
	{
		// Token: 0x06000139 RID: 313 RVA: 0x000091D8 File Offset: 0x000073D8
		// Note: this type is marked as 'beforefieldinit'.
		static DepthOfFieldRenderer()
		{
			Il2CppClassPointerStore<DepthOfFieldRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "DepthOfFieldRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfFieldRenderer>.NativeClassPtr);
			DepthOfFieldRenderer.NativeFieldInfoPtr_k_NumEyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldRenderer>.NativeClassPtr, "k_NumEyes");
			DepthOfFieldRenderer.NativeFieldInfoPtr_k_NumCoCHistoryTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldRenderer>.NativeClassPtr, "k_NumCoCHistoryTextures");
			DepthOfFieldRenderer.NativeFieldInfoPtr_m_CoCHistoryTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldRenderer>.NativeClassPtr, "m_CoCHistoryTextures");
			DepthOfFieldRenderer.NativeFieldInfoPtr_m_HistoryPingPong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldRenderer>.NativeClassPtr, "m_HistoryPingPong");
			DepthOfFieldRenderer.NativeFieldInfoPtr_k_FilmHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldRenderer>.NativeClassPtr, "k_FilmHeight");
			DepthOfFieldRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldRenderer>.NativeClassPtr, 100663359);
			DepthOfFieldRenderer.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldRenderer>.NativeClassPtr, 100663360);
			DepthOfFieldRenderer.NativeMethodInfoPtr_SelectFormat_Private_RenderTextureFormat_RenderTextureFormat_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldRenderer>.NativeClassPtr, 100663361);
			DepthOfFieldRenderer.NativeMethodInfoPtr_CalculateMaxCoCRadius_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldRenderer>.NativeClassPtr, 100663362);
			DepthOfFieldRenderer.NativeMethodInfoPtr_CheckHistory_Private_RenderTexture_Int32_Int32_PostProcessRenderContext_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldRenderer>.NativeClassPtr, 100663363);
			DepthOfFieldRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldRenderer>.NativeClassPtr, 100663364);
			DepthOfFieldRenderer.NativeMethodInfoPtr_Release_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldRenderer>.NativeClassPtr, 100663365);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000092F8 File Offset: 0x000074F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443100, XrefRangeEnd = 443112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DepthOfFieldRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOfFieldRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00009334 File Offset: 0x00007534
		[CallerCount(0)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldRenderer.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00009370 File Offset: 0x00007570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443112, XrefRangeEnd = 443119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref primary;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondary;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldRenderer.NativeMethodInfoPtr_SelectFormat_Private_RenderTextureFormat_RenderTextureFormat_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000093C8 File Offset: 0x000075C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443119, XrefRangeEnd = 443120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateMaxCoCRadius(int screenHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenHeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldRenderer.NativeMethodInfoPtr_CalculateMaxCoCRadius_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00009414 File Offset: 0x00007614
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 443153, RefRangeEnd = 443155, XrefRangeStart = 443120, XrefRangeEnd = 443153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldRenderer.NativeMethodInfoPtr_CheckHistory_Private_RenderTexture_Int32_Int32_PostProcessRenderContext_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00009490 File Offset: 0x00007690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443155, XrefRangeEnd = 443286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000094D4 File Offset: 0x000076D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443286, XrefRangeEnd = 443298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldRenderer.NativeMethodInfoPtr_Release_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002E44 File Offset: 0x00001044
		public DepthOfFieldRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00009508 File Offset: 0x00007708
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00002E4D File Offset: 0x0000104D
		public unsafe static int k_NumEyes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DepthOfFieldRenderer.NativeFieldInfoPtr_k_NumEyes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DepthOfFieldRenderer.NativeFieldInfoPtr_k_NumEyes, (void*)(&value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00009524 File Offset: 0x00007724
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00002E5B File Offset: 0x0000105B
		public unsafe static int k_NumCoCHistoryTextures
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DepthOfFieldRenderer.NativeFieldInfoPtr_k_NumCoCHistoryTextures, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DepthOfFieldRenderer.NativeFieldInfoPtr_k_NumCoCHistoryTextures, (void*)(&value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00009540 File Offset: 0x00007740
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00002E69 File Offset: 0x00001069
		public unsafe Il2CppReferenceArray<Il2CppReferenceArray<RenderTexture>> m_CoCHistoryTextures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfFieldRenderer.NativeFieldInfoPtr_m_CoCHistoryTextures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<RenderTexture>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfFieldRenderer.NativeFieldInfoPtr_m_CoCHistoryTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00009570 File Offset: 0x00007770
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002E88 File Offset: 0x00001088
		public unsafe Il2CppStructArray<int> m_HistoryPingPong
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfFieldRenderer.NativeFieldInfoPtr_m_HistoryPingPong);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfFieldRenderer.NativeFieldInfoPtr_m_HistoryPingPong), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000095A0 File Offset: 0x000077A0
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002EA7 File Offset: 0x000010A7
		public unsafe static float k_FilmHeight
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DepthOfFieldRenderer.NativeFieldInfoPtr_k_FilmHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DepthOfFieldRenderer.NativeFieldInfoPtr_k_FilmHeight, (void*)(&value));
			}
		}

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_k_NumEyes;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_k_NumCoCHistoryTextures;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_m_CoCHistoryTextures;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_m_HistoryPingPong;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_k_FilmHeight;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_SelectFormat_Private_RenderTextureFormat_RenderTextureFormat_RenderTextureFormat_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_CalculateMaxCoCRadius_Private_Single_Int32_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_CheckHistory_Private_RenderTexture_Int32_Int32_PostProcessRenderContext_RenderTextureFormat_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_0;

		// Token: 0x0200006C RID: 108
		[OriginalName("Unity.Postprocessing.Runtime.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x0400047C RID: 1148
			CoCCalculation,
			// Token: 0x0400047D RID: 1149
			CoCTemporalFilter,
			// Token: 0x0400047E RID: 1150
			DownsampleAndPrefilter,
			// Token: 0x0400047F RID: 1151
			BokehSmallKernel,
			// Token: 0x04000480 RID: 1152
			BokehMediumKernel,
			// Token: 0x04000481 RID: 1153
			BokehLargeKernel,
			// Token: 0x04000482 RID: 1154
			BokehVeryLargeKernel,
			// Token: 0x04000483 RID: 1155
			PostFilter,
			// Token: 0x04000484 RID: 1156
			Combine,
			// Token: 0x04000485 RID: 1157
			DebugOverlay
		}
	}
}
