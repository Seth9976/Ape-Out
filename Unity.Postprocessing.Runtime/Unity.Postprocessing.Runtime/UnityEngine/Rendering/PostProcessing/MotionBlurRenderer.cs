using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000029 RID: 41
	public sealed class MotionBlurRenderer : PostProcessEffectRenderer<MotionBlur>
	{
		// Token: 0x06000199 RID: 409 RVA: 0x0000A2E4 File Offset: 0x000084E4
		// Note: this type is marked as 'beforefieldinit'.
		static MotionBlurRenderer()
		{
			Il2CppClassPointerStore<MotionBlurRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "MotionBlurRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionBlurRenderer>.NativeClassPtr);
			MotionBlurRenderer.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurRenderer>.NativeClassPtr, 100663385);
			MotionBlurRenderer.NativeMethodInfoPtr_CreateTemporaryRT_Private_Void_PostProcessRenderContext_Int32_Int32_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurRenderer>.NativeClassPtr, 100663386);
			MotionBlurRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurRenderer>.NativeClassPtr, 100663387);
			MotionBlurRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionBlurRenderer>.NativeClassPtr, 100663388);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000A364 File Offset: 0x00008564
		[CallerCount(0)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurRenderer.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000A3A0 File Offset: 0x000085A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 443552, RefRangeEnd = 443558, XrefRangeStart = 443549, XrefRangeEnd = 443552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTemporaryRT(PostProcessRenderContext context, int nameID, int width, int height, RenderTextureFormat RTFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref RTFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurRenderer.NativeMethodInfoPtr_CreateTemporaryRT_Private_Void_PostProcessRenderContext_Int32_Int32_Int32_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000A41C File Offset: 0x0000861C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443558, XrefRangeEnd = 443660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurRenderer.NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000A460 File Offset: 0x00008660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443660, XrefRangeEnd = 443661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotionBlurRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionBlurRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotionBlurRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000315F File Offset: 0x0000135F
		public MotionBlurRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_CreateTemporaryRT_Private_Void_PostProcessRenderContext_Int32_Int32_Int32_RenderTextureFormat_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_PostProcessRenderContext_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200006D RID: 109
		[OriginalName("Unity.Postprocessing.Runtime.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x04000487 RID: 1159
			VelocitySetup,
			// Token: 0x04000488 RID: 1160
			TileMax1,
			// Token: 0x04000489 RID: 1161
			TileMax2,
			// Token: 0x0400048A RID: 1162
			TileMaxV,
			// Token: 0x0400048B RID: 1163
			NeighborMax,
			// Token: 0x0400048C RID: 1164
			Reconstruction
		}
	}
}
