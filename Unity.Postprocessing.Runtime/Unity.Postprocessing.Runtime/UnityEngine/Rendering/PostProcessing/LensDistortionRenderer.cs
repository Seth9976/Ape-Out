using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000027 RID: 39
	public sealed class LensDistortionRenderer : PostProcessEffectRenderer<LensDistortion>
	{
		// Token: 0x0600018D RID: 397 RVA: 0x0000A0A0 File Offset: 0x000082A0
		// Note: this type is marked as 'beforefieldinit'.
		static LensDistortionRenderer()
		{
			Il2CppClassPointerStore<LensDistortionRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "LensDistortionRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensDistortionRenderer>.NativeClassPtr);
			LensDistortionRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensDistortionRenderer>.NativeClassPtr, 100663381);
			LensDistortionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensDistortionRenderer>.NativeClassPtr, 100663382);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000A0F8 File Offset: 0x000082F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443509, XrefRangeEnd = 443526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensDistortionRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000A13C File Offset: 0x0000833C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443526, XrefRangeEnd = 443527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LensDistortionRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensDistortionRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensDistortionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000310F File Offset: 0x0000130F
		public LensDistortionRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
