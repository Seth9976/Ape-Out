using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200004F RID: 79
	public class PostProcessEffectRenderer : Object
	{
		// Token: 0x0600034C RID: 844 RVA: 0x000100E4 File Offset: 0x0000E2E4
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessEffectRenderer()
		{
			Il2CppClassPointerStore<PostProcessEffectRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PostProcessEffectRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessEffectRenderer>.NativeClassPtr);
			PostProcessEffectRenderer.NativeFieldInfoPtr_m_ResetHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessEffectRenderer>.NativeClassPtr, "m_ResetHistory");
			PostProcessEffectRenderer.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectRenderer>.NativeClassPtr, 100663562);
			PostProcessEffectRenderer.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_New_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectRenderer>.NativeClassPtr, 100663563);
			PostProcessEffectRenderer.NativeMethodInfoPtr_ResetHistory_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectRenderer>.NativeClassPtr, 100663564);
			PostProcessEffectRenderer.NativeMethodInfoPtr_Release_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectRenderer>.NativeClassPtr, 100663565);
			PostProcessEffectRenderer.NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectRenderer>.NativeClassPtr, 100663566);
			PostProcessEffectRenderer.NativeMethodInfoPtr_SetSettings_Internal_Abstract_Virtual_New_Void_PostProcessEffectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectRenderer>.NativeClassPtr, 100663567);
			PostProcessEffectRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEffectRenderer>.NativeClassPtr, 100663568);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000101B4 File Offset: 0x0000E3B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessEffectRenderer.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000101F0 File Offset: 0x0000E3F0
		[CallerCount(0)]
		public unsafe virtual DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessEffectRenderer.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_New_DepthTextureMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00010238 File Offset: 0x0000E438
		[CallerCount(0)]
		public unsafe virtual void ResetHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessEffectRenderer.NativeMethodInfoPtr_ResetHistory_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00010274 File Offset: 0x0000E474
		[CallerCount(0)]
		public unsafe virtual void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessEffectRenderer.NativeMethodInfoPtr_Release_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000102B0 File Offset: 0x0000E4B0
		[CallerCount(0)]
		public unsafe virtual void Render(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessEffectRenderer.NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_PostProcessRenderContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00010300 File Offset: 0x0000E500
		[CallerCount(0)]
		public unsafe virtual void SetSettings(PostProcessEffectSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessEffectRenderer.NativeMethodInfoPtr_SetSettings_Internal_Abstract_Virtual_New_Void_PostProcessEffectSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00010350 File Offset: 0x0000E550
		[CallerCount(0)]
		public unsafe PostProcessEffectRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessEffectRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessEffectRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00003E05 File Offset: 0x00002005
		public PostProcessEffectRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0001038C File Offset: 0x0000E58C
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00003E0E File Offset: 0x0000200E
		public unsafe bool m_ResetHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessEffectRenderer.NativeFieldInfoPtr_m_ResetHistory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessEffectRenderer.NativeFieldInfoPtr_m_ResetHistory)) = value;
			}
		}

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeFieldInfoPtr_m_ResetHistory;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_New_DepthTextureMode_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_ResetHistory_Public_Virtual_New_Void_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_New_Void_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Abstract_Virtual_New_Void_PostProcessRenderContext_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_SetSettings_Internal_Abstract_Virtual_New_Void_PostProcessEffectSettings_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
