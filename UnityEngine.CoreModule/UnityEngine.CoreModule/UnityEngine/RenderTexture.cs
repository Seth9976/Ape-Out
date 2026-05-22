using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000096 RID: 150
	public class RenderTexture : Texture
	{
		// Token: 0x06000D79 RID: 3449 RVA: 0x00038370 File Offset: 0x00036570
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTexture()
		{
			Il2CppClassPointerStore<RenderTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr);
			RenderTexture.NativeMethodInfoPtr_get_width_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664232);
			RenderTexture.NativeMethodInfoPtr_set_width_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664233);
			RenderTexture.NativeMethodInfoPtr_get_height_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664234);
			RenderTexture.NativeMethodInfoPtr_set_height_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664235);
			RenderTexture.NativeMethodInfoPtr_get_dimension_Public_Virtual_get_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664236);
			RenderTexture.NativeMethodInfoPtr_set_dimension_Public_Virtual_set_Void_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664237);
			RenderTexture.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664238);
			RenderTexture.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664239);
			RenderTexture.NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664240);
			RenderTexture.NativeMethodInfoPtr_get_format_Public_get_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664241);
			RenderTexture.NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664242);
			RenderTexture.NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664243);
			RenderTexture.NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664244);
			RenderTexture.NativeMethodInfoPtr_get_enableRandomWrite_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664245);
			RenderTexture.NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664246);
			RenderTexture.NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664247);
			RenderTexture.NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664248);
			RenderTexture.NativeMethodInfoPtr_GetActive_Private_Static_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664249);
			RenderTexture.NativeMethodInfoPtr_SetActive_Private_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664250);
			RenderTexture.NativeMethodInfoPtr_get_active_Public_Static_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664251);
			RenderTexture.NativeMethodInfoPtr_set_active_Public_Static_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664252);
			RenderTexture.NativeMethodInfoPtr_GetColorBuffer_Private_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664253);
			RenderTexture.NativeMethodInfoPtr_GetDepthBuffer_Private_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664254);
			RenderTexture.NativeMethodInfoPtr_get_colorBuffer_Public_get_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664255);
			RenderTexture.NativeMethodInfoPtr_get_depthBuffer_Public_get_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664256);
			RenderTexture.NativeMethodInfoPtr_DiscardContents_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664257);
			RenderTexture.NativeMethodInfoPtr_DiscardContents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664258);
			RenderTexture.NativeMethodInfoPtr_Create_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664259);
			RenderTexture.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664260);
			RenderTexture.NativeMethodInfoPtr_IsCreated_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664261);
			RenderTexture.NativeMethodInfoPtr_SetSRGBReadWrite_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664262);
			RenderTexture.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664263);
			RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Private_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664264);
			RenderTexture.NativeMethodInfoPtr_GetDescriptor_Private_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664265);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Private_Static_RenderTexture_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664266);
			RenderTexture.NativeMethodInfoPtr_ReleaseTemporary_Public_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664267);
			RenderTexture.NativeMethodInfoPtr_get_depth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664268);
			RenderTexture.NativeMethodInfoPtr_set_depth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664269);
			RenderTexture.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664270);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664271);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664272);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664273);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664274);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664275);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664276);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664277);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664278);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664279);
			RenderTexture.NativeMethodInfoPtr_get_descriptor_Public_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664280);
			RenderTexture.NativeMethodInfoPtr_set_descriptor_Public_set_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664281);
			RenderTexture.NativeMethodInfoPtr_ValidateRenderTextureDesc_Private_Static_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664282);
			RenderTexture.NativeMethodInfoPtr_GetCompatibleFormat_Internal_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664283);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664284);
			RenderTexture.NativeMethodInfoPtr_GetTemporaryImpl_Private_Static_RenderTexture_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664285);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664286);
			RenderTexture.NativeMethodInfoPtr_GetColorBuffer_Injected_Private_Void_byref_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664287);
			RenderTexture.NativeMethodInfoPtr_GetDepthBuffer_Injected_Private_Void_byref_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664288);
			RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664289);
			RenderTexture.NativeMethodInfoPtr_GetDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664290);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Injected_Private_Static_RenderTexture_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100664291);
			RenderTexture.get_useMipMapDelegateField = IL2CPP.ResolveICall<RenderTexture.get_useMipMapDelegate>("UnityEngine.RenderTexture::get_useMipMap");
			RenderTexture.get_sRGBDelegateField = IL2CPP.ResolveICall<RenderTexture.get_sRGBDelegate>("UnityEngine.RenderTexture::get_sRGB");
			RenderTexture.get_vrUsageDelegateField = IL2CPP.ResolveICall<RenderTexture.get_vrUsageDelegate>("UnityEngine.RenderTexture::get_vrUsage");
			RenderTexture.set_vrUsageDelegateField = IL2CPP.ResolveICall<RenderTexture.set_vrUsageDelegate>("UnityEngine.RenderTexture::set_vrUsage");
			RenderTexture.get_memorylessModeDelegateField = IL2CPP.ResolveICall<RenderTexture.get_memorylessModeDelegate>("UnityEngine.RenderTexture::get_memorylessMode");
			RenderTexture.set_memorylessModeDelegateField = IL2CPP.ResolveICall<RenderTexture.set_memorylessModeDelegate>("UnityEngine.RenderTexture::set_memorylessMode");
			RenderTexture.get_stencilFormatDelegateField = IL2CPP.ResolveICall<RenderTexture.get_stencilFormatDelegate>("UnityEngine.RenderTexture::get_stencilFormat");
			RenderTexture.set_stencilFormatDelegateField = IL2CPP.ResolveICall<RenderTexture.set_stencilFormatDelegate>("UnityEngine.RenderTexture::set_stencilFormat");
			RenderTexture.get_autoGenerateMipsDelegateField = IL2CPP.ResolveICall<RenderTexture.get_autoGenerateMipsDelegate>("UnityEngine.RenderTexture::get_autoGenerateMips");
			RenderTexture.get_antiAliasingDelegateField = IL2CPP.ResolveICall<RenderTexture.get_antiAliasingDelegate>("UnityEngine.RenderTexture::get_antiAliasing");
			RenderTexture.set_antiAliasingDelegateField = IL2CPP.ResolveICall<RenderTexture.set_antiAliasingDelegate>("UnityEngine.RenderTexture::set_antiAliasing");
			RenderTexture.get_bindTextureMSDelegateField = IL2CPP.ResolveICall<RenderTexture.get_bindTextureMSDelegate>("UnityEngine.RenderTexture::get_bindTextureMS");
			RenderTexture.set_bindTextureMSDelegateField = IL2CPP.ResolveICall<RenderTexture.set_bindTextureMSDelegate>("UnityEngine.RenderTexture::set_bindTextureMS");
			RenderTexture.GetIsPowerOfTwoDelegateField = IL2CPP.ResolveICall<RenderTexture.GetIsPowerOfTwoDelegate>("UnityEngine.RenderTexture::GetIsPowerOfTwo");
			RenderTexture.GetNativeDepthBufferPtrDelegateField = IL2CPP.ResolveICall<RenderTexture.GetNativeDepthBufferPtrDelegate>("UnityEngine.RenderTexture::GetNativeDepthBufferPtr");
			RenderTexture.MarkRestoreExpectedDelegateField = IL2CPP.ResolveICall<RenderTexture.MarkRestoreExpectedDelegate>("UnityEngine.RenderTexture::MarkRestoreExpected");
			RenderTexture.ResolveAADelegateField = IL2CPP.ResolveICall<RenderTexture.ResolveAADelegate>("UnityEngine.RenderTexture::ResolveAA");
			RenderTexture.ResolveAAToDelegateField = IL2CPP.ResolveICall<RenderTexture.ResolveAAToDelegate>("UnityEngine.RenderTexture::ResolveAATo");
			RenderTexture.SetGlobalShaderPropertyDelegateField = IL2CPP.ResolveICall<RenderTexture.SetGlobalShaderPropertyDelegate>("UnityEngine.RenderTexture::SetGlobalShaderProperty");
			RenderTexture.GenerateMipsDelegateField = IL2CPP.ResolveICall<RenderTexture.GenerateMipsDelegate>("UnityEngine.RenderTexture::GenerateMips");
			RenderTexture.ConvertToEquirectDelegateField = IL2CPP.ResolveICall<RenderTexture.ConvertToEquirectDelegate>("UnityEngine.RenderTexture::ConvertToEquirect");
			RenderTexture.SupportsStencilDelegateField = IL2CPP.ResolveICall<RenderTexture.SupportsStencilDelegate>("UnityEngine.RenderTexture::SupportsStencil");
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x0003899C File Offset: 0x00036B9C
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x000389E4 File Offset: 0x00036BE4
		public unsafe override int width
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490916, XrefRangeEnd = 490920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_get_width_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490920, XrefRangeEnd = 490924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_set_width_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x00038A30 File Offset: 0x00036C30
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x00038A78 File Offset: 0x00036C78
		public unsafe override int height
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490924, XrefRangeEnd = 490928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_get_height_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490928, XrefRangeEnd = 490932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_set_height_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00038AC4 File Offset: 0x00036CC4
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x00038B0C File Offset: 0x00036D0C
		public unsafe override UnityEngine.Rendering.TextureDimension dimension
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490932, XrefRangeEnd = 490936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_get_dimension_Public_Virtual_get_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490936, XrefRangeEnd = 490940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_set_dimension_Public_Virtual_set_Void_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00038B58 File Offset: 0x00036D58
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x00038B94 File Offset: 0x00036D94
		public new unsafe UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490940, XrefRangeEnd = 490944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490944, XrefRangeEnd = 490948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0000946B File Offset: 0x0000766B
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x00038BD4 File Offset: 0x00036DD4
		public unsafe bool useMipMap
		{
			get
			{
				return RenderTexture.get_useMipMapDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490948, XrefRangeEnd = 490952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x00038C14 File Offset: 0x00036E14
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x000094D9 File Offset: 0x000076D9
		public unsafe RenderTextureFormat format
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 490960, RefRangeEnd = 490964, XrefRangeStart = 490952, XrefRangeEnd = 490960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_format_Public_get_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.graphicsFormat = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(value, this.sRGB);
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x00009514 File Offset: 0x00007714
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x00038C50 File Offset: 0x00036E50
		public unsafe bool autoGenerateMips
		{
			get
			{
				return RenderTexture.get_autoGenerateMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 490968, RefRangeEnd = 490969, XrefRangeStart = 490964, XrefRangeEnd = 490968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x00038C90 File Offset: 0x00036E90
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x00038CCC File Offset: 0x00036ECC
		public unsafe int volumeDepth
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 490973, RefRangeEnd = 490978, XrefRangeStart = 490969, XrefRangeEnd = 490973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 490982, RefRangeEnd = 490983, XrefRangeStart = 490978, XrefRangeEnd = 490982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x00038D0C File Offset: 0x00036F0C
		// (set) Token: 0x06000D88 RID: 3464 RVA: 0x00038D48 File Offset: 0x00036F48
		public unsafe bool enableRandomWrite
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 490987, RefRangeEnd = 490988, XrefRangeStart = 490983, XrefRangeEnd = 490987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_enableRandomWrite_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 490992, RefRangeEnd = 490993, XrefRangeStart = 490988, XrefRangeEnd = 490992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x00038D88 File Offset: 0x00036F88
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x00038DC4 File Offset: 0x00036FC4
		public unsafe bool useDynamicScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490993, XrefRangeEnd = 490997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490997, XrefRangeEnd = 491001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00038E04 File Offset: 0x00037004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 491005, RefRangeEnd = 491007, XrefRangeStart = 491001, XrefRangeEnd = 491005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetActive()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetActive_Private_Static_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00038E38 File Offset: 0x00037038
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 491011, RefRangeEnd = 491014, XrefRangeStart = 491007, XrefRangeEnd = 491011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetActive(RenderTexture rt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetActive_Private_Static_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00038E70 File Offset: 0x00037070
		// (set) Token: 0x06000D8E RID: 3470 RVA: 0x00038EA4 File Offset: 0x000370A4
		public unsafe static RenderTexture active
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 491005, RefRangeEnd = 491007, XrefRangeStart = 491005, XrefRangeEnd = 491007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_active_Public_Static_get_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 491011, RefRangeEnd = 491014, XrefRangeStart = 491011, XrefRangeEnd = 491014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_active_Public_Static_set_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00038EDC File Offset: 0x000370DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491014, XrefRangeEnd = 491016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderBuffer GetColorBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetColorBuffer_Private_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00038F18 File Offset: 0x00037118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491016, XrefRangeEnd = 491018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderBuffer GetDepthBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDepthBuffer_Private_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x00038F54 File Offset: 0x00037154
		public unsafe RenderBuffer colorBuffer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 491020, RefRangeEnd = 491021, XrefRangeStart = 491018, XrefRangeEnd = 491020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_colorBuffer_Public_get_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x00038F90 File Offset: 0x00037190
		public unsafe RenderBuffer depthBuffer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491021, XrefRangeEnd = 491023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_depthBuffer_Public_get_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00038FCC File Offset: 0x000371CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491023, XrefRangeEnd = 491027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DiscardContents(bool discardColor, bool discardDepth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref discardColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref discardDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_DiscardContents_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00039018 File Offset: 0x00037218
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 491031, RefRangeEnd = 491033, XrefRangeStart = 491027, XrefRangeEnd = 491031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DiscardContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_DiscardContents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0003904C File Offset: 0x0003724C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 491037, RefRangeEnd = 491038, XrefRangeStart = 491033, XrefRangeEnd = 491037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_Create_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00039088 File Offset: 0x00037288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 491042, RefRangeEnd = 491043, XrefRangeStart = 491038, XrefRangeEnd = 491042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x000390BC File Offset: 0x000372BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491043, XrefRangeEnd = 491047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCreated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_IsCreated_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x000390F8 File Offset: 0x000372F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491047, XrefRangeEnd = 491051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSRGBReadWrite(bool srgb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref srgb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetSRGBReadWrite_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00039138 File Offset: 0x00037338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491051, XrefRangeEnd = 491055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(RenderTexture rt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00039170 File Offset: 0x00037370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491055, XrefRangeEnd = 491057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTextureDescriptor(RenderTextureDescriptor desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Private_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x000391B0 File Offset: 0x000373B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491057, XrefRangeEnd = 491059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor GetDescriptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDescriptor_Private_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x000391EC File Offset: 0x000373EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491059, XrefRangeEnd = 491061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Private_Static_RenderTexture_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0003922C File Offset: 0x0003742C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 491065, RefRangeEnd = 491068, XrefRangeStart = 491061, XrefRangeEnd = 491065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseTemporary(RenderTexture temp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(temp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_ReleaseTemporary_Public_Static_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00039264 File Offset: 0x00037464
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x000392A0 File Offset: 0x000374A0
		public unsafe int depth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491068, XrefRangeEnd = 491072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_depth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491072, XrefRangeEnd = 491076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_depth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x000392E0 File Offset: 0x000374E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491076, XrefRangeEnd = 491082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0003931C File Offset: 0x0003751C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491082, XrefRangeEnd = 491093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(RenderTextureDescriptor desc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00039364 File Offset: 0x00037564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491093, XrefRangeEnd = 491118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(RenderTexture textureToCopy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textureToCopy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x000393B0 File Offset: 0x000375B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491118, XrefRangeEnd = 491123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00039424 File Offset: 0x00037624
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 491142, RefRangeEnd = 491157, XrefRangeStart = 491123, XrefRangeEnd = 491142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00039498 File Offset: 0x00037698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 491182, RefRangeEnd = 491183, XrefRangeStart = 491157, XrefRangeEnd = 491182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00039518 File Offset: 0x00037718
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 491185, RefRangeEnd = 491186, XrefRangeStart = 491183, XrefRangeEnd = 491185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00039598 File Offset: 0x00037798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491186, XrefRangeEnd = 491188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, RenderTextureFormat format)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0003960C File Offset: 0x0003780C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491188, XrefRangeEnd = 491190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00039670 File Offset: 0x00037870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491190, XrefRangeEnd = 491192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x000396F0 File Offset: 0x000378F0
		// (set) Token: 0x06000DAB RID: 3499 RVA: 0x0003972C File Offset: 0x0003792C
		public unsafe RenderTextureDescriptor descriptor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 491194, RefRangeEnd = 491196, XrefRangeStart = 491192, XrefRangeEnd = 491194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_descriptor_Public_get_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491196, XrefRangeEnd = 491199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_descriptor_Public_set_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0003976C File Offset: 0x0003796C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 491204, RefRangeEnd = 491212, XrefRangeStart = 491199, XrefRangeEnd = 491204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateRenderTextureDesc(RenderTextureDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_ValidateRenderTextureDesc_Private_Static_Void_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x000397A0 File Offset: 0x000379A0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 491227, RefRangeEnd = 491243, XrefRangeStart = 491212, XrefRangeEnd = 491227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderTextureFormat;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetCompatibleFormat_Internal_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x000397EC File Offset: 0x000379EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491243, XrefRangeEnd = 491246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(RenderTextureDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0003982C File Offset: 0x00037A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491246, XrefRangeEnd = 491256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, bool useDynamicScale = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memorylessMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vrUsage;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDynamicScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporaryImpl_Private_Static_RenderTexture_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x000398D0 File Offset: 0x00037AD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 491267, RefRangeEnd = 491270, XrefRangeStart = 491256, XrefRangeEnd = 491267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0003993C File Offset: 0x00037B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491270, XrefRangeEnd = 491274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetColorBuffer_Injected(out RenderBuffer ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetColorBuffer_Injected_Private_Void_byref_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0003997C File Offset: 0x00037B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491274, XrefRangeEnd = 491278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDepthBuffer_Injected(out RenderBuffer ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDepthBuffer_Injected_Private_Void_byref_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x000399BC File Offset: 0x00037BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491278, XrefRangeEnd = 491282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x000399FC File Offset: 0x00037BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491282, XrefRangeEnd = 491286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDescriptor_Injected(out RenderTextureDescriptor ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00039A3C File Offset: 0x00037C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491286, XrefRangeEnd = 491290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Injected_Private_Static_RenderTexture_byref_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00009462 File Offset: 0x00007662
		public RenderTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x0000947D File Offset: 0x0000767D
		public bool sRGB
		{
			get
			{
				return RenderTexture.get_sRGBDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x0000948F File Offset: 0x0000768F
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x000094A1 File Offset: 0x000076A1
		public VRTextureUsage vrUsage
		{
			get
			{
				return RenderTexture.get_vrUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_vrUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x000094B4 File Offset: 0x000076B4
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x000094C6 File Offset: 0x000076C6
		public RenderTextureMemoryless memorylessMode
		{
			get
			{
				return RenderTexture.get_memorylessModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_memorylessModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x000094EF File Offset: 0x000076EF
		// (set) Token: 0x06000DBF RID: 3519 RVA: 0x00009501 File Offset: 0x00007701
		public UnityEngine.Experimental.Rendering.GraphicsFormat stencilFormat
		{
			get
			{
				return RenderTexture.get_stencilFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_stencilFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00009526 File Offset: 0x00007726
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x00009538 File Offset: 0x00007738
		public int antiAliasing
		{
			get
			{
				return RenderTexture.get_antiAliasingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_antiAliasingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x0000954B File Offset: 0x0000774B
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x0000955D File Offset: 0x0000775D
		public bool bindTextureMS
		{
			get
			{
				return RenderTexture.get_bindTextureMSDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RenderTexture.set_bindTextureMSDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00009570 File Offset: 0x00007770
		public bool GetIsPowerOfTwo()
		{
			return RenderTexture.GetIsPowerOfTwoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00039A7C File Offset: 0x00037C7C
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x00009582 File Offset: 0x00007782
		public bool isPowerOfTwo
		{
			get
			{
				return this.GetIsPowerOfTwo();
			}
			set
			{
			}
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00009585 File Offset: 0x00007785
		public IntPtr GetNativeDepthBufferPtr()
		{
			return RenderTexture.GetNativeDepthBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00009597 File Offset: 0x00007797
		public void MarkRestoreExpected()
		{
			RenderTexture.MarkRestoreExpectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x000095A9 File Offset: 0x000077A9
		public void ResolveAA()
		{
			RenderTexture.ResolveAADelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x000095BB File Offset: 0x000077BB
		public void ResolveAATo(RenderTexture rt)
		{
			RenderTexture.ResolveAAToDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rt));
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x000095D3 File Offset: 0x000077D3
		public void ResolveAntiAliasedSurface()
		{
			this.ResolveAA();
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x000095DD File Offset: 0x000077DD
		public void ResolveAntiAliasedSurface(RenderTexture target)
		{
			this.ResolveAATo(target);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x000095E8 File Offset: 0x000077E8
		public void SetGlobalShaderProperty(string propertyName)
		{
			RenderTexture.SetGlobalShaderPropertyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(propertyName));
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00009600 File Offset: 0x00007800
		public void GenerateMips()
		{
			RenderTexture.GenerateMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00009612 File Offset: 0x00007812
		public void ConvertToEquirect(RenderTexture equirect, [Optional] Camera.MonoOrStereoscopicEye eye)
		{
			RenderTexture.ConvertToEquirectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(equirect), eye);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0000962B File Offset: 0x0000782B
		public static bool SupportsStencil(RenderTexture rt)
		{
			return RenderTexture.SupportsStencilDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rt));
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00039A94 File Offset: 0x00037C94
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, format, antiAliasing, memorylessMode, vrUsage, useDynamicScale);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00039AB8 File Offset: 0x00037CB8
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, format, antiAliasing, memorylessMode, vrUsage, false);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00039ADC File Offset: 0x00037CDC
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, format, antiAliasing, memorylessMode, VRTextureUsage.None, false);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00039B00 File Offset: 0x00037D00
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, format, antiAliasing, RenderTextureMemoryless.None, VRTextureUsage.None, false);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00039B20 File Offset: 0x00037D20
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, format, 1, RenderTextureMemoryless.None, VRTextureUsage.None, false);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00039B40 File Offset: 0x00037D40
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(format, readWrite), antiAliasing, memorylessMode, vrUsage, useDynamicScale);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00039B6C File Offset: 0x00037D6C
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, RenderTexture.GetCompatibleFormat(format, readWrite), antiAliasing, memorylessMode, vrUsage, false);
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00039B98 File Offset: 0x00037D98
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, RenderTexture.GetCompatibleFormat(format, readWrite), antiAliasing, memorylessMode, VRTextureUsage.None, false);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00039BC0 File Offset: 0x00037DC0
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, RenderTexture.GetCompatibleFormat(format, readWrite), antiAliasing, RenderTextureMemoryless.None, VRTextureUsage.None, false);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00039BE8 File Offset: 0x00037DE8
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, RenderTexture.GetCompatibleFormat(format, readWrite), 1, RenderTextureMemoryless.None, VRTextureUsage.None, false);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00039C10 File Offset: 0x00037E10
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer)
		{
			return RenderTexture.GetTemporaryImpl(width, height, depthBuffer, RenderTexture.GetCompatibleFormat(RenderTextureFormat.Default, RenderTextureReadWrite.Default), 1, RenderTextureMemoryless.None, VRTextureUsage.None, false);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00039C38 File Offset: 0x00037E38
		public static RenderTexture GetTemporary(int width, int height)
		{
			return RenderTexture.GetTemporaryImpl(width, height, 0, RenderTexture.GetCompatibleFormat(RenderTextureFormat.Default, RenderTextureReadWrite.Default), 1, RenderTextureMemoryless.None, VRTextureUsage.None, false);
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x00039C60 File Offset: 0x00037E60
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x0000963D File Offset: 0x0000783D
		public bool isCubemap
		{
			get
			{
				return this.dimension == UnityEngine.Rendering.TextureDimension.Cube;
			}
			set
			{
				this.dimension = (value ? UnityEngine.Rendering.TextureDimension.Cube : UnityEngine.Rendering.TextureDimension.Tex2D);
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00039C7C File Offset: 0x00037E7C
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x0000964E File Offset: 0x0000784E
		public bool isVolume
		{
			get
			{
				return this.dimension == UnityEngine.Rendering.TextureDimension.Tex3D;
			}
			set
			{
				this.dimension = (value ? UnityEngine.Rendering.TextureDimension.Tex3D : UnityEngine.Rendering.TextureDimension.Tex2D);
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00039C98 File Offset: 0x00037E98
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x0000965F File Offset: 0x0000785F
		public static bool enabled
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00039CAC File Offset: 0x00037EAC
		public Vector2 GetTexelOffset()
		{
			return Vector2.zero;
		}

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_Virtual_get_Int32_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_Virtual_set_Void_Int32_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_Virtual_get_Int32_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_Virtual_set_Void_Int32_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_get_dimension_Public_Virtual_get_TextureDimension_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_set_dimension_Public_Virtual_set_Void_TextureDimension_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_get_format_Public_get_RenderTextureFormat_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_get_enableRandomWrite_Public_get_Boolean_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_GetActive_Private_Static_RenderTexture_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Private_Static_Void_RenderTexture_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Static_get_RenderTexture_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Public_Static_set_Void_RenderTexture_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_GetColorBuffer_Private_RenderBuffer_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthBuffer_Private_RenderBuffer_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_get_colorBuffer_Public_get_RenderBuffer_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_get_depthBuffer_Public_get_RenderBuffer_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_DiscardContents_Public_Void_Boolean_Boolean_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_DiscardContents_Public_Void_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Boolean_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_IsCreated_Public_Boolean_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_SetSRGBReadWrite_Internal_Void_Boolean_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RenderTexture_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTextureDescriptor_Private_Void_RenderTextureDescriptor_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptor_Private_RenderTextureDescriptor_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Internal_Private_Static_RenderTexture_RenderTextureDescriptor_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseTemporary_Public_Static_Void_RenderTexture_0;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_get_depth_Public_get_Int32_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_set_depth_Public_set_Void_Int32_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTextureDescriptor_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_Int32_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_Int32_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_get_descriptor_Public_get_RenderTextureDescriptor_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_set_descriptor_Public_set_Void_RenderTextureDescriptor_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_ValidateRenderTextureDesc_Private_Static_Void_RenderTextureDescriptor_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_GetCompatibleFormat_Internal_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_RenderTextureDescriptor_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryImpl_Private_Static_RenderTexture_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_GetColorBuffer_Injected_Private_Void_byref_RenderBuffer_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthBuffer_Injected_Private_Void_byref_RenderBuffer_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTextureDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Internal_Injected_Private_Static_RenderTexture_byref_RenderTextureDescriptor_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly RenderTexture.get_useMipMapDelegate get_useMipMapDelegateField;

		// Token: 0x04000A20 RID: 2592
		private static readonly RenderTexture.get_sRGBDelegate get_sRGBDelegateField;

		// Token: 0x04000A21 RID: 2593
		private static readonly RenderTexture.get_vrUsageDelegate get_vrUsageDelegateField;

		// Token: 0x04000A22 RID: 2594
		private static readonly RenderTexture.set_vrUsageDelegate set_vrUsageDelegateField;

		// Token: 0x04000A23 RID: 2595
		private static readonly RenderTexture.get_memorylessModeDelegate get_memorylessModeDelegateField;

		// Token: 0x04000A24 RID: 2596
		private static readonly RenderTexture.set_memorylessModeDelegate set_memorylessModeDelegateField;

		// Token: 0x04000A25 RID: 2597
		private static readonly RenderTexture.get_stencilFormatDelegate get_stencilFormatDelegateField;

		// Token: 0x04000A26 RID: 2598
		private static readonly RenderTexture.set_stencilFormatDelegate set_stencilFormatDelegateField;

		// Token: 0x04000A27 RID: 2599
		private static readonly RenderTexture.get_autoGenerateMipsDelegate get_autoGenerateMipsDelegateField;

		// Token: 0x04000A28 RID: 2600
		private static readonly RenderTexture.get_antiAliasingDelegate get_antiAliasingDelegateField;

		// Token: 0x04000A29 RID: 2601
		private static readonly RenderTexture.set_antiAliasingDelegate set_antiAliasingDelegateField;

		// Token: 0x04000A2A RID: 2602
		private static readonly RenderTexture.get_bindTextureMSDelegate get_bindTextureMSDelegateField;

		// Token: 0x04000A2B RID: 2603
		private static readonly RenderTexture.set_bindTextureMSDelegate set_bindTextureMSDelegateField;

		// Token: 0x04000A2C RID: 2604
		private static readonly RenderTexture.GetIsPowerOfTwoDelegate GetIsPowerOfTwoDelegateField;

		// Token: 0x04000A2D RID: 2605
		private static readonly RenderTexture.GetNativeDepthBufferPtrDelegate GetNativeDepthBufferPtrDelegateField;

		// Token: 0x04000A2E RID: 2606
		private static readonly RenderTexture.MarkRestoreExpectedDelegate MarkRestoreExpectedDelegateField;

		// Token: 0x04000A2F RID: 2607
		private static readonly RenderTexture.ResolveAADelegate ResolveAADelegateField;

		// Token: 0x04000A30 RID: 2608
		private static readonly RenderTexture.ResolveAAToDelegate ResolveAAToDelegateField;

		// Token: 0x04000A31 RID: 2609
		private static readonly RenderTexture.SetGlobalShaderPropertyDelegate SetGlobalShaderPropertyDelegateField;

		// Token: 0x04000A32 RID: 2610
		private static readonly RenderTexture.GenerateMipsDelegate GenerateMipsDelegateField;

		// Token: 0x04000A33 RID: 2611
		private static readonly RenderTexture.ConvertToEquirectDelegate ConvertToEquirectDelegateField;

		// Token: 0x04000A34 RID: 2612
		private static readonly RenderTexture.SupportsStencilDelegate SupportsStencilDelegateField;

		// Token: 0x02000725 RID: 1829
		// (Invoke) Token: 0x06002C67 RID: 11367
		private delegate bool get_useMipMapDelegate(IntPtr @this);

		// Token: 0x02000726 RID: 1830
		// (Invoke) Token: 0x06002C69 RID: 11369
		private delegate bool get_sRGBDelegate(IntPtr @this);

		// Token: 0x02000727 RID: 1831
		// (Invoke) Token: 0x06002C6B RID: 11371
		private delegate VRTextureUsage get_vrUsageDelegate(IntPtr @this);

		// Token: 0x02000728 RID: 1832
		// (Invoke) Token: 0x06002C6D RID: 11373
		private delegate void set_vrUsageDelegate(IntPtr @this, VRTextureUsage value);

		// Token: 0x02000729 RID: 1833
		// (Invoke) Token: 0x06002C6F RID: 11375
		private delegate RenderTextureMemoryless get_memorylessModeDelegate(IntPtr @this);

		// Token: 0x0200072A RID: 1834
		// (Invoke) Token: 0x06002C71 RID: 11377
		private delegate void set_memorylessModeDelegate(IntPtr @this, RenderTextureMemoryless value);

		// Token: 0x0200072B RID: 1835
		// (Invoke) Token: 0x06002C73 RID: 11379
		private delegate UnityEngine.Experimental.Rendering.GraphicsFormat get_stencilFormatDelegate(IntPtr @this);

		// Token: 0x0200072C RID: 1836
		// (Invoke) Token: 0x06002C75 RID: 11381
		private delegate void set_stencilFormatDelegate(IntPtr @this, UnityEngine.Experimental.Rendering.GraphicsFormat value);

		// Token: 0x0200072D RID: 1837
		// (Invoke) Token: 0x06002C77 RID: 11383
		private delegate bool get_autoGenerateMipsDelegate(IntPtr @this);

		// Token: 0x0200072E RID: 1838
		// (Invoke) Token: 0x06002C79 RID: 11385
		private delegate int get_antiAliasingDelegate(IntPtr @this);

		// Token: 0x0200072F RID: 1839
		// (Invoke) Token: 0x06002C7B RID: 11387
		private delegate void set_antiAliasingDelegate(IntPtr @this, int value);

		// Token: 0x02000730 RID: 1840
		// (Invoke) Token: 0x06002C7D RID: 11389
		private delegate bool get_bindTextureMSDelegate(IntPtr @this);

		// Token: 0x02000731 RID: 1841
		// (Invoke) Token: 0x06002C7F RID: 11391
		private delegate void set_bindTextureMSDelegate(IntPtr @this, bool value);

		// Token: 0x02000732 RID: 1842
		// (Invoke) Token: 0x06002C81 RID: 11393
		private delegate bool GetIsPowerOfTwoDelegate(IntPtr @this);

		// Token: 0x02000733 RID: 1843
		// (Invoke) Token: 0x06002C83 RID: 11395
		private delegate IntPtr GetNativeDepthBufferPtrDelegate(IntPtr @this);

		// Token: 0x02000734 RID: 1844
		// (Invoke) Token: 0x06002C85 RID: 11397
		private delegate void MarkRestoreExpectedDelegate(IntPtr @this);

		// Token: 0x02000735 RID: 1845
		// (Invoke) Token: 0x06002C87 RID: 11399
		private delegate void ResolveAADelegate(IntPtr @this);

		// Token: 0x02000736 RID: 1846
		// (Invoke) Token: 0x06002C89 RID: 11401
		private delegate void ResolveAAToDelegate(IntPtr @this, IntPtr rt);

		// Token: 0x02000737 RID: 1847
		// (Invoke) Token: 0x06002C8B RID: 11403
		private delegate void SetGlobalShaderPropertyDelegate(IntPtr @this, IntPtr propertyName);

		// Token: 0x02000738 RID: 1848
		// (Invoke) Token: 0x06002C8D RID: 11405
		private delegate void GenerateMipsDelegate(IntPtr @this);

		// Token: 0x02000739 RID: 1849
		// (Invoke) Token: 0x06002C8F RID: 11407
		private delegate void ConvertToEquirectDelegate(IntPtr @this, IntPtr equirect, Camera.MonoOrStereoscopicEye eye);

		// Token: 0x0200073A RID: 1850
		// (Invoke) Token: 0x06002C91 RID: 11409
		private delegate bool SupportsStencilDelegate(IntPtr rt);
	}
}
