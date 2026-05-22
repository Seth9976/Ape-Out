using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200000D RID: 13
	public class IAmbientOcclusionMethod : Il2CppObjectBase
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00006AB8 File Offset: 0x00004CB8
		// Note: this type is marked as 'beforefieldinit'.
		static IAmbientOcclusionMethod()
		{
			Il2CppClassPointerStore<IAmbientOcclusionMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "IAmbientOcclusionMethod");
			IAmbientOcclusionMethod.NativeMethodInfoPtr_GetCameraFlags_Public_Abstract_Virtual_New_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAmbientOcclusionMethod>.NativeClassPtr, 100663308);
			IAmbientOcclusionMethod.NativeMethodInfoPtr_RenderAfterOpaque_Public_Abstract_Virtual_New_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAmbientOcclusionMethod>.NativeClassPtr, 100663309);
			IAmbientOcclusionMethod.NativeMethodInfoPtr_RenderAmbientOnly_Public_Abstract_Virtual_New_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAmbientOcclusionMethod>.NativeClassPtr, 100663310);
			IAmbientOcclusionMethod.NativeMethodInfoPtr_CompositeAmbientOnly_Public_Abstract_Virtual_New_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAmbientOcclusionMethod>.NativeClassPtr, 100663311);
			IAmbientOcclusionMethod.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAmbientOcclusionMethod>.NativeClassPtr, 100663312);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006B44 File Offset: 0x00004D44
		[CallerCount(0)]
		public unsafe virtual DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAmbientOcclusionMethod.NativeMethodInfoPtr_GetCameraFlags_Public_Abstract_Virtual_New_DepthTextureMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006B8C File Offset: 0x00004D8C
		[CallerCount(0)]
		public unsafe virtual void RenderAfterOpaque(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAmbientOcclusionMethod.NativeMethodInfoPtr_RenderAfterOpaque_Public_Abstract_Virtual_New_Void_PostProcessRenderContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006BDC File Offset: 0x00004DDC
		[CallerCount(0)]
		public unsafe virtual void RenderAmbientOnly(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAmbientOcclusionMethod.NativeMethodInfoPtr_RenderAmbientOnly_Public_Abstract_Virtual_New_Void_PostProcessRenderContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006C2C File Offset: 0x00004E2C
		[CallerCount(0)]
		public unsafe virtual void CompositeAmbientOnly(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAmbientOcclusionMethod.NativeMethodInfoPtr_CompositeAmbientOnly_Public_Abstract_Virtual_New_Void_PostProcessRenderContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006C7C File Offset: 0x00004E7C
		[CallerCount(0)]
		public unsafe virtual void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAmbientOcclusionMethod.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000239D File Offset: 0x0000059D
		public IAmbientOcclusionMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Abstract_Virtual_New_DepthTextureMode_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_RenderAfterOpaque_Public_Abstract_Virtual_New_Void_PostProcessRenderContext_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_RenderAmbientOnly_Public_Abstract_Virtual_New_Void_PostProcessRenderContext_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_CompositeAmbientOnly_Public_Abstract_Virtual_New_Void_PostProcessRenderContext_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_0;
	}
}
