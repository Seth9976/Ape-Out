using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000037 RID: 55
	public sealed class VignetteRenderer : PostProcessEffectRenderer<Vignette>
	{
		// Token: 0x06000255 RID: 597 RVA: 0x0000C9D0 File Offset: 0x0000ABD0
		// Note: this type is marked as 'beforefieldinit'.
		static VignetteRenderer()
		{
			Il2CppClassPointerStore<VignetteRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "VignetteRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VignetteRenderer>.NativeClassPtr);
			VignetteRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteRenderer>.NativeClassPtr, 100663452);
			VignetteRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteRenderer>.NativeClassPtr, 100663453);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000CA28 File Offset: 0x0000AC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445208, XrefRangeEnd = 445229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VignetteRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000CA6C File Offset: 0x0000AC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 445229, XrefRangeEnd = 445230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VignetteRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VignetteRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VignetteRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00003828 File Offset: 0x00001A28
		public VignetteRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
