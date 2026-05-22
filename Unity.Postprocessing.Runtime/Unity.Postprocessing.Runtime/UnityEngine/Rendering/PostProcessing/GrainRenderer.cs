using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000025 RID: 37
	public sealed class GrainRenderer : PostProcessEffectRenderer<Grain>
	{
		// Token: 0x06000171 RID: 369 RVA: 0x00009C04 File Offset: 0x00007E04
		// Note: this type is marked as 'beforefieldinit'.
		static GrainRenderer()
		{
			Il2CppClassPointerStore<GrainRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "GrainRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrainRenderer>.NativeClassPtr);
			GrainRenderer.NativeFieldInfoPtr_m_GrainLookupRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainRenderer>.NativeClassPtr, "m_GrainLookupRT");
			GrainRenderer.NativeFieldInfoPtr_k_SampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainRenderer>.NativeClassPtr, "k_SampleCount");
			GrainRenderer.NativeFieldInfoPtr_m_SampleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainRenderer>.NativeClassPtr, "m_SampleIndex");
			GrainRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainRenderer>.NativeClassPtr, 100663375);
			GrainRenderer.NativeMethodInfoPtr_GetLookupFormat_Private_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainRenderer>.NativeClassPtr, 100663376);
			GrainRenderer.NativeMethodInfoPtr_Release_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainRenderer>.NativeClassPtr, 100663377);
			GrainRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainRenderer>.NativeClassPtr, 100663378);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00009CC0 File Offset: 0x00007EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443383, XrefRangeEnd = 443467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00009D04 File Offset: 0x00007F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443467, XrefRangeEnd = 443471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureFormat GetLookupFormat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainRenderer.NativeMethodInfoPtr_GetLookupFormat_Private_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00009D40 File Offset: 0x00007F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443471, XrefRangeEnd = 443475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainRenderer.NativeMethodInfoPtr_Release_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00009D74 File Offset: 0x00007F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443475, XrefRangeEnd = 443476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrainRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrainRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002FFB File Offset: 0x000011FB
		public GrainRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00009DB0 File Offset: 0x00007FB0
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00003004 File Offset: 0x00001204
		public unsafe RenderTexture m_GrainLookupRT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrainRenderer.NativeFieldInfoPtr_m_GrainLookupRT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrainRenderer.NativeFieldInfoPtr_m_GrainLookupRT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00009DE0 File Offset: 0x00007FE0
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00003023 File Offset: 0x00001223
		public unsafe static int k_SampleCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GrainRenderer.NativeFieldInfoPtr_k_SampleCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GrainRenderer.NativeFieldInfoPtr_k_SampleCount, (void*)(&value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00009DFC File Offset: 0x00007FFC
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00003031 File Offset: 0x00001231
		public unsafe int m_SampleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrainRenderer.NativeFieldInfoPtr_m_SampleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrainRenderer.NativeFieldInfoPtr_m_SampleIndex)) = value;
			}
		}

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_m_GrainLookupRT;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_k_SampleCount;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_m_SampleIndex;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_GetLookupFormat_Private_RenderTextureFormat_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
