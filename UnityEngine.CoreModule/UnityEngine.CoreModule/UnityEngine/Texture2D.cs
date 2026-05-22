using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x02000091 RID: 145
	public sealed class Texture2D : Texture
	{
		// Token: 0x06000C69 RID: 3177 RVA: 0x00033EF0 File Offset: 0x000320F0
		// Note: this type is marked as 'beforefieldinit'.
		static Texture2D()
		{
			Il2CppClassPointerStore<Texture2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Texture2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture2D>.NativeClassPtr);
			Texture2D.NativeFieldInfoPtr_streamingMipmapsPriorityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, "streamingMipmapsPriorityMin");
			Texture2D.NativeFieldInfoPtr_streamingMipmapsPriorityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, "streamingMipmapsPriorityMax");
			Texture2D.NativeMethodInfoPtr_get_format_Public_get_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664147);
			Texture2D.NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664148);
			Texture2D.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664149);
			Texture2D.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664150);
			Texture2D.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664151);
			Texture2D.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664152);
			Texture2D.NativeMethodInfoPtr_ResizeImpl_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664153);
			Texture2D.NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664154);
			Texture2D.NativeMethodInfoPtr_GetPixelImpl_Private_Color_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664155);
			Texture2D.NativeMethodInfoPtr_GetPixelBilinearImpl_Private_Color_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664156);
			Texture2D.NativeMethodInfoPtr_ResizeWithFormatImpl_Private_Boolean_Int32_Int32_GraphicsFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664157);
			Texture2D.NativeMethodInfoPtr_ReadPixelsImpl_Private_Void_Rect_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664158);
			Texture2D.NativeMethodInfoPtr_SetPixelsImpl_Private_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664159);
			Texture2D.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664160);
			Texture2D.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_TextureFormat_Int32_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664161);
			Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664162);
			Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664163);
			Texture2D.NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664164);
			Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664165);
			Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664166);
			Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664167);
			Texture2D.NativeMethodInfoPtr_GetPixel_Public_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664168);
			Texture2D.NativeMethodInfoPtr_GetPixelBilinear_Public_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664169);
			Texture2D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664170);
			Texture2D.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664171);
			Texture2D.NativeMethodInfoPtr_Resize_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664172);
			Texture2D.NativeMethodInfoPtr_Resize_Public_Boolean_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664173);
			Texture2D.NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664174);
			Texture2D.NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664175);
			Texture2D.NativeMethodInfoPtr_GetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664176);
			Texture2D.NativeMethodInfoPtr_GetPixelBilinearImpl_Injected_Private_Void_Int32_Int32_Single_Single_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664177);
			Texture2D.NativeMethodInfoPtr_ReadPixelsImpl_Injected_Private_Void_byref_Rect_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664178);
			Texture2D.get_ignoreMipmapLimitDelegateField = IL2CPP.ResolveICall<Texture2D.get_ignoreMipmapLimitDelegate>("UnityEngine.Texture2D::get_ignoreMipmapLimit");
			Texture2D.set_ignoreMipmapLimitDelegateField = IL2CPP.ResolveICall<Texture2D.set_ignoreMipmapLimitDelegate>("UnityEngine.Texture2D::set_ignoreMipmapLimit");
			Texture2D.get_blackTextureDelegateField = IL2CPP.ResolveICall<Texture2D.get_blackTextureDelegate>("UnityEngine.Texture2D::get_blackTexture");
			Texture2D.get_redTextureDelegateField = IL2CPP.ResolveICall<Texture2D.get_redTextureDelegate>("UnityEngine.Texture2D::get_redTexture");
			Texture2D.get_grayTextureDelegateField = IL2CPP.ResolveICall<Texture2D.get_grayTextureDelegate>("UnityEngine.Texture2D::get_grayTexture");
			Texture2D.get_linearGrayTextureDelegateField = IL2CPP.ResolveICall<Texture2D.get_linearGrayTextureDelegate>("UnityEngine.Texture2D::get_linearGrayTexture");
			Texture2D.get_normalTextureDelegateField = IL2CPP.ResolveICall<Texture2D.get_normalTextureDelegate>("UnityEngine.Texture2D::get_normalTexture");
			Texture2D.CompressDelegateField = IL2CPP.ResolveICall<Texture2D.CompressDelegate>("UnityEngine.Texture2D::Compress");
			Texture2D.get_vtOnlyDelegateField = IL2CPP.ResolveICall<Texture2D.get_vtOnlyDelegate>("UnityEngine.Texture2D::get_vtOnly");
			Texture2D.LoadRawTextureDataImplDelegateField = IL2CPP.ResolveICall<Texture2D.LoadRawTextureDataImplDelegate>("UnityEngine.Texture2D::LoadRawTextureDataImpl");
			Texture2D.LoadRawTextureDataImplArrayDelegateField = IL2CPP.ResolveICall<Texture2D.LoadRawTextureDataImplArrayDelegate>("UnityEngine.Texture2D::LoadRawTextureDataImplArray");
			Texture2D.SetPixelDataImplArrayDelegateField = IL2CPP.ResolveICall<Texture2D.SetPixelDataImplArrayDelegate>("UnityEngine.Texture2D::SetPixelDataImplArray");
			Texture2D.SetPixelDataImplDelegateField = IL2CPP.ResolveICall<Texture2D.SetPixelDataImplDelegate>("UnityEngine.Texture2D::SetPixelDataImpl");
			Texture2D.GetWritableImageDataDelegateField = IL2CPP.ResolveICall<Texture2D.GetWritableImageDataDelegate>("UnityEngine.Texture2D::GetWritableImageData");
			Texture2D.GetRawImageDataSizeDelegateField = IL2CPP.ResolveICall<Texture2D.GetRawImageDataSizeDelegate>("UnityEngine.Texture2D::GetRawImageDataSize");
			Texture2D.GenerateAtlasImplDelegateField = IL2CPP.ResolveICall<Texture2D.GenerateAtlasImplDelegate>("UnityEngine.Texture2D::GenerateAtlasImpl");
			Texture2D.get_isPreProcessedDelegateField = IL2CPP.ResolveICall<Texture2D.get_isPreProcessedDelegate>("UnityEngine.Texture2D::get_isPreProcessed");
			Texture2D.get_streamingMipmapsDelegateField = IL2CPP.ResolveICall<Texture2D.get_streamingMipmapsDelegate>("UnityEngine.Texture2D::get_streamingMipmaps");
			Texture2D.get_streamingMipmapsPriorityDelegateField = IL2CPP.ResolveICall<Texture2D.get_streamingMipmapsPriorityDelegate>("UnityEngine.Texture2D::get_streamingMipmapsPriority");
			Texture2D.get_requestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_requestedMipmapLevelDelegate>("UnityEngine.Texture2D::get_requestedMipmapLevel");
			Texture2D.set_requestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.set_requestedMipmapLevelDelegate>("UnityEngine.Texture2D::set_requestedMipmapLevel");
			Texture2D.get_minimumMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_minimumMipmapLevelDelegate>("UnityEngine.Texture2D::get_minimumMipmapLevel");
			Texture2D.set_minimumMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.set_minimumMipmapLevelDelegate>("UnityEngine.Texture2D::set_minimumMipmapLevel");
			Texture2D.get_loadAllMipsDelegateField = IL2CPP.ResolveICall<Texture2D.get_loadAllMipsDelegate>("UnityEngine.Texture2D::get_loadAllMips");
			Texture2D.set_loadAllMipsDelegateField = IL2CPP.ResolveICall<Texture2D.set_loadAllMipsDelegate>("UnityEngine.Texture2D::set_loadAllMips");
			Texture2D.get_calculatedMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_calculatedMipmapLevelDelegate>("UnityEngine.Texture2D::get_calculatedMipmapLevel");
			Texture2D.get_desiredMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_desiredMipmapLevelDelegate>("UnityEngine.Texture2D::get_desiredMipmapLevel");
			Texture2D.get_loadingMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_loadingMipmapLevelDelegate>("UnityEngine.Texture2D::get_loadingMipmapLevel");
			Texture2D.get_loadedMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_loadedMipmapLevelDelegate>("UnityEngine.Texture2D::get_loadedMipmapLevel");
			Texture2D.ClearRequestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.ClearRequestedMipmapLevelDelegate>("UnityEngine.Texture2D::ClearRequestedMipmapLevel");
			Texture2D.IsRequestedMipmapLevelLoadedDelegateField = IL2CPP.ResolveICall<Texture2D.IsRequestedMipmapLevelLoadedDelegate>("UnityEngine.Texture2D::IsRequestedMipmapLevelLoaded");
			Texture2D.ClearMinimumMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.ClearMinimumMipmapLevelDelegate>("UnityEngine.Texture2D::ClearMinimumMipmapLevel");
			Texture2D.UpdateExternalTextureDelegateField = IL2CPP.ResolveICall<Texture2D.UpdateExternalTextureDelegate>("UnityEngine.Texture2D::UpdateExternalTexture");
			Texture2D.SetAllPixels32DelegateField = IL2CPP.ResolveICall<Texture2D.SetAllPixels32Delegate>("UnityEngine.Texture2D::SetAllPixels32");
			Texture2D.SetBlockOfPixels32DelegateField = IL2CPP.ResolveICall<Texture2D.SetBlockOfPixels32Delegate>("UnityEngine.Texture2D::SetBlockOfPixels32");
			Texture2D.GetRawTextureDataDelegateField = IL2CPP.ResolveICall<Texture2D.GetRawTextureDataDelegate>("UnityEngine.Texture2D::GetRawTextureData");
			Texture2D.GetPixelsDelegateField = IL2CPP.ResolveICall<Texture2D.GetPixelsDelegate>("UnityEngine.Texture2D::GetPixels");
			Texture2D.GetPixels32DelegateField = IL2CPP.ResolveICall<Texture2D.GetPixels32Delegate>("UnityEngine.Texture2D::GetPixels32");
			Texture2D.PackTexturesDelegateField = IL2CPP.ResolveICall<Texture2D.PackTexturesDelegate>("UnityEngine.Texture2D::PackTextures");
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x00034414 File Offset: 0x00032614
		public unsafe TextureFormat format
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490386, XrefRangeEnd = 490390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_get_format_Public_get_TextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x00034450 File Offset: 0x00032650
		public unsafe static Texture2D whiteTexture
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 490394, RefRangeEnd = 490396, XrefRangeStart = 490390, XrefRangeEnd = 490394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00034484 File Offset: 0x00032684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490396, XrefRangeEnd = 490400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0003451C File Offset: 0x0003271C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490400, XrefRangeEnd = 490402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x000345A8 File Offset: 0x000327A8
		public unsafe override bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490402, XrefRangeEnd = 490406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000345E4 File Offset: 0x000327E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490406, XrefRangeEnd = 490410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateMipmaps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref makeNoLongerReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00034630 File Offset: 0x00032830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490410, XrefRangeEnd = 490414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResizeImpl(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ResizeImpl_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00034688 File Offset: 0x00032888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490414, XrefRangeEnd = 490416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixelImpl(int image, int mip, int x, int y, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref image;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00034700 File Offset: 0x00032900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490416, XrefRangeEnd = 490418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetPixelImpl(int image, int mip, int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref image;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixelImpl_Private_Color_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00034774 File Offset: 0x00032974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490418, XrefRangeEnd = 490420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetPixelBilinearImpl(int image, int mip, float u, float v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref image;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixelBilinearImpl_Private_Color_Int32_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x000347E8 File Offset: 0x000329E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490420, XrefRangeEnd = 490424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResizeWithFormatImpl(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasMipMap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ResizeWithFormatImpl_Private_Boolean_Int32_Int32_GraphicsFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0003485C File Offset: 0x00032A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490424, XrefRangeEnd = 490426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destY;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recalculateMipMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ReadPixelsImpl_Private_Void_Rect_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x000348C4 File Offset: 0x00032AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490426, XrefRangeEnd = 490430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixelsImpl(int x, int y, int w, int h, Il2CppStructArray<Color> pixel, int miplevel, int frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pixel);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixelsImpl_Private_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0003495C File Offset: 0x00032B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490430, XrefRangeEnd = 490432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(TextureFormat format, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x000349C4 File Offset: 0x00032BC4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 490444, RefRangeEnd = 490454, XrefRangeStart = 490432, XrefRangeEnd = 490444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_TextureFormat_Int32_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00034A54 File Offset: 0x00032C54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 490456, RefRangeEnd = 490458, XrefRangeStart = 490454, XrefRangeEnd = 490456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00034AD4 File Offset: 0x00032CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490458, XrefRangeEnd = 490460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00034B48 File Offset: 0x00032D48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 490462, RefRangeEnd = 490465, XrefRangeStart = 490460, XrefRangeEnd = 490462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixel(int x, int y, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00034BA4 File Offset: 0x00032DA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 490472, RefRangeEnd = 490475, XrefRangeStart = 490465, XrefRangeEnd = 490472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color> colors, int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00034C30 File Offset: 0x00032E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490475, XrefRangeEnd = 490476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels(Il2CppStructArray<Color> colors, int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00034C80 File Offset: 0x00032E80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 490477, RefRangeEnd = 490479, XrefRangeStart = 490476, XrefRangeEnd = 490477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels(Il2CppStructArray<Color> colors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00034CC4 File Offset: 0x00032EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490479, XrefRangeEnd = 490481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetPixel(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixel_Public_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00034D1C File Offset: 0x00032F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490481, XrefRangeEnd = 490483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetPixelBilinear(float u, float v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref u;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixelBilinear_Public_Color_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00034D74 File Offset: 0x00032F74
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 490490, RefRangeEnd = 490500, XrefRangeStart = 490483, XrefRangeEnd = 490490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(bool updateMipmaps, bool makeNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateMipmaps;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref makeNoLongerReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00034DC0 File Offset: 0x00032FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490500, XrefRangeEnd = 490501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00034DF4 File Offset: 0x00032FF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 490508, RefRangeEnd = 490511, XrefRangeStart = 490501, XrefRangeEnd = 490508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Resize(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Resize_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00034E4C File Offset: 0x0003304C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490523, RefRangeEnd = 490524, XrefRangeStart = 490511, XrefRangeEnd = 490523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Resize(int width, int height, TextureFormat format, bool hasMipMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasMipMap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Resize_Public_Boolean_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00034EC0 File Offset: 0x000330C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490524, XrefRangeEnd = 490526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destY;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recalculateMipMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00034F28 File Offset: 0x00033128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490526, XrefRangeEnd = 490530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref image;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00034FA0 File Offset: 0x000331A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490530, XrefRangeEnd = 490534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPixelImpl_Injected(int image, int mip, int x, int y, out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref image;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00035018 File Offset: 0x00033218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490534, XrefRangeEnd = 490538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref image;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixelBilinearImpl_Injected_Private_Void_Int32_Int32_Single_Single_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00035090 File Offset: 0x00033290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490538, XrefRangeEnd = 490542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destY;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recalculateMipMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ReadPixelsImpl_Injected_Private_Void_byref_Rect_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00008CAC File Offset: 0x00006EAC
		public Texture2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x000350F8 File Offset: 0x000332F8
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x00008CB5 File Offset: 0x00006EB5
		public unsafe static int streamingMipmapsPriorityMin
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Texture2D.NativeFieldInfoPtr_streamingMipmapsPriorityMin, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Texture2D.NativeFieldInfoPtr_streamingMipmapsPriorityMin, (void*)(&value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x00035114 File Offset: 0x00033314
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x00008CC3 File Offset: 0x00006EC3
		public unsafe static int streamingMipmapsPriorityMax
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Texture2D.NativeFieldInfoPtr_streamingMipmapsPriorityMax, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Texture2D.NativeFieldInfoPtr_streamingMipmapsPriorityMax, (void*)(&value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x00008CD1 File Offset: 0x00006ED1
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x00008CE3 File Offset: 0x00006EE3
		public bool ignoreMipmapLimit
		{
			get
			{
				return Texture2D.get_ignoreMipmapLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture2D.set_ignoreMipmapLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x00035130 File Offset: 0x00033330
		public static Texture2D blackTexture
		{
			get
			{
				IntPtr intPtr = Texture2D.get_blackTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00035158 File Offset: 0x00033358
		public static Texture2D redTexture
		{
			get
			{
				IntPtr intPtr = Texture2D.get_redTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00035180 File Offset: 0x00033380
		public static Texture2D grayTexture
		{
			get
			{
				IntPtr intPtr = Texture2D.get_grayTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x000351A8 File Offset: 0x000333A8
		public static Texture2D linearGrayTexture
		{
			get
			{
				IntPtr intPtr = Texture2D.get_linearGrayTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x000351D0 File Offset: 0x000333D0
		public static Texture2D normalTexture
		{
			get
			{
				IntPtr intPtr = Texture2D.get_normalTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00008CF6 File Offset: 0x00006EF6
		public void Compress(bool highQuality)
		{
			Texture2D.CompressDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), highQuality);
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00008D09 File Offset: 0x00006F09
		public bool vtOnly
		{
			get
			{
				return Texture2D.get_vtOnlyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00008D1B File Offset: 0x00006F1B
		public bool LoadRawTextureDataImpl(IntPtr data, ulong size)
		{
			return Texture2D.LoadRawTextureDataImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, size);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00008D2F File Offset: 0x00006F2F
		public bool LoadRawTextureDataImplArray(Il2CppStructArray<byte> data)
		{
			return Texture2D.LoadRawTextureDataImplArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data));
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00008D47 File Offset: 0x00006F47
		public bool SetPixelDataImplArray(Array data, int mipLevel, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Texture2D.SetPixelDataImplArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00008D65 File Offset: 0x00006F65
		public bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Texture2D.SetPixelDataImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00008D7E File Offset: 0x00006F7E
		public IntPtr GetWritableImageData(int frame)
		{
			return Texture2D.GetWritableImageDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), frame);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00008D91 File Offset: 0x00006F91
		public ulong GetRawImageDataSize()
		{
			return Texture2D.GetRawImageDataSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00008DA3 File Offset: 0x00006FA3
		public static void GenerateAtlasImpl(Il2CppStructArray<Vector2> sizes, int padding, int atlasSize, [Out] Il2CppStructArray<Rect> rect)
		{
			Texture2D.GenerateAtlasImplDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sizes), padding, atlasSize, IL2CPP.Il2CppObjectBaseToPtr(rect));
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00008DBD File Offset: 0x00006FBD
		public bool isPreProcessed
		{
			get
			{
				return Texture2D.get_isPreProcessedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00008DCF File Offset: 0x00006FCF
		public bool streamingMipmaps
		{
			get
			{
				return Texture2D.get_streamingMipmapsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00008DE1 File Offset: 0x00006FE1
		public int streamingMipmapsPriority
		{
			get
			{
				return Texture2D.get_streamingMipmapsPriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00008DF3 File Offset: 0x00006FF3
		// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x00008E05 File Offset: 0x00007005
		public int requestedMipmapLevel
		{
			get
			{
				return Texture2D.get_requestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture2D.set_requestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00008E18 File Offset: 0x00007018
		// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x00008E2A File Offset: 0x0000702A
		public int minimumMipmapLevel
		{
			get
			{
				return Texture2D.get_minimumMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture2D.set_minimumMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00008E3D File Offset: 0x0000703D
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x00008E4F File Offset: 0x0000704F
		public bool loadAllMips
		{
			get
			{
				return Texture2D.get_loadAllMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture2D.set_loadAllMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x00008E62 File Offset: 0x00007062
		public int calculatedMipmapLevel
		{
			get
			{
				return Texture2D.get_calculatedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00008E74 File Offset: 0x00007074
		public int desiredMipmapLevel
		{
			get
			{
				return Texture2D.get_desiredMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00008E86 File Offset: 0x00007086
		public int loadingMipmapLevel
		{
			get
			{
				return Texture2D.get_loadingMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00008E98 File Offset: 0x00007098
		public int loadedMipmapLevel
		{
			get
			{
				return Texture2D.get_loadedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00008EAA File Offset: 0x000070AA
		public void ClearRequestedMipmapLevel()
		{
			Texture2D.ClearRequestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00008EBC File Offset: 0x000070BC
		public bool IsRequestedMipmapLevelLoaded()
		{
			return Texture2D.IsRequestedMipmapLevelLoadedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00008ECE File Offset: 0x000070CE
		public void ClearMinimumMipmapLevel()
		{
			Texture2D.ClearMinimumMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00008EE0 File Offset: 0x000070E0
		public void UpdateExternalTexture(IntPtr nativeTex)
		{
			Texture2D.UpdateExternalTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nativeTex);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00008EF3 File Offset: 0x000070F3
		public void SetAllPixels32(Il2CppStructArray<Color32> colors, int miplevel)
		{
			Texture2D.SetAllPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), miplevel);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00008F0C File Offset: 0x0000710C
		public void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color32> colors, int miplevel)
		{
			Texture2D.SetBlockOfPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y, blockWidth, blockHeight, IL2CPP.Il2CppObjectBaseToPtr(colors), miplevel);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x000351F8 File Offset: 0x000333F8
		public Il2CppStructArray<byte> GetRawTextureData()
		{
			IntPtr intPtr = Texture2D.GetRawTextureDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00035224 File Offset: 0x00033424
		public Il2CppStructArray<Color> GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel)
		{
			IntPtr intPtr = Texture2D.GetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y, blockWidth, blockHeight, miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00035258 File Offset: 0x00033458
		public Il2CppStructArray<Color> GetPixels(int x, int y, int blockWidth, int blockHeight)
		{
			return this.GetPixels(x, y, blockWidth, blockHeight, 0);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00035278 File Offset: 0x00033478
		public Il2CppStructArray<Color32> GetPixels32(int miplevel)
		{
			IntPtr intPtr = Texture2D.GetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x000352A8 File Offset: 0x000334A8
		public Il2CppStructArray<Color32> GetPixels32()
		{
			return this.GetPixels32(0);
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x000352C4 File Offset: 0x000334C4
		public Il2CppStructArray<Rect> PackTextures(Il2CppReferenceArray<Texture2D> textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable)
		{
			IntPtr intPtr = Texture2D.PackTexturesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(textures), padding, maximumAtlasSize, makeNoLongerReadable);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x000352FC File Offset: 0x000334FC
		public Il2CppStructArray<Rect> PackTextures(Il2CppReferenceArray<Texture2D> textures, int padding, int maximumAtlasSize)
		{
			return this.PackTextures(textures, padding, maximumAtlasSize, false);
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00035318 File Offset: 0x00033518
		public Il2CppStructArray<Rect> PackTextures(Il2CppReferenceArray<Texture2D> textures, int padding)
		{
			return this.PackTextures(textures, padding, 2048);
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00035338 File Offset: 0x00033538
		public bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height)
		{
			bool flag = base.ValidateFormat(format, UnityEngine.Experimental.Rendering.FormatUsage.Sample);
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsPVRTCFormat(format);
				bool flag4 = flag3 && (width != height || !Mathf.IsPowerOfTwo(width));
				if (flag4)
				{
					throw new UnityException(String.Format("'{0}' demands texture to be square and have power-of-two dimensions", format.ToString()));
				}
			}
			return flag;
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0003539C File Offset: 0x0003359C
		public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex)
		{
			bool flag = nativeTex == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("nativeTex can not be null");
			}
			return new Texture2D(width, height, format, mipChain ? (-1) : 1, linear, nativeTex);
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x000353DC File Offset: 0x000335DC
		public void SetPixel(int x, int y, Color color, int mipLevel)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			this.SetPixelImpl(0, mipLevel, x, y, color);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00008F2C File Offset: 0x0000712C
		public void SetPixels(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color> colors)
		{
			this.SetPixels(x, y, blockWidth, blockHeight, colors, 0);
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x0003540C File Offset: 0x0003360C
		public Color GetPixel(int x, int y, int mipLevel)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelImpl(0, mipLevel, x, y);
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00035440 File Offset: 0x00033640
		public Color GetPixelBilinear(float u, float v, int mipLevel)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelBilinearImpl(0, mipLevel, u, v);
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00035474 File Offset: 0x00033674
		public void LoadRawTextureData(IntPtr data, int size)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag2 = data == IntPtr.Zero || size == 0;
			if (flag2)
			{
				Debug.LogError("No texture data provided to LoadRawTextureData", this);
			}
			else
			{
				bool flag3 = !this.LoadRawTextureDataImpl(data, (ulong)((long)size));
				if (flag3)
				{
					throw new UnityException("LoadRawTextureData: not enough data provided (will result in overread).");
				}
			}
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x000354DC File Offset: 0x000336DC
		public void LoadRawTextureData(Il2CppStructArray<byte> data)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag2 = data == null || data.Length == 0;
			if (flag2)
			{
				Debug.LogError("No texture data provided to LoadRawTextureData", this);
			}
			else
			{
				bool flag3 = !this.LoadRawTextureDataImplArray(data);
				if (flag3)
				{
					throw new UnityException("LoadRawTextureData: not enough data provided (will result in overread).");
				}
			}
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0003553C File Offset: 0x0003373C
		public void LoadRawTextureData<T>(Unity.Collections.NativeArray<T> data) where T : struct
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag2 = !data.IsCreated || data.Length == 0;
			if (flag2)
			{
				throw new UnityException("No texture data provided to LoadRawTextureData");
			}
			bool flag3 = !this.LoadRawTextureDataImpl((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), (ulong)((long)data.Length * (long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>()));
			if (flag3)
			{
				throw new UnityException("LoadRawTextureData: not enough data provided (will result in overread).");
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x000355B8 File Offset: 0x000337B8
		public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, [Optional] int sourceDataStartIndex)
		{
			bool flag = sourceDataStartIndex < 0;
			if (flag)
			{
				throw new UnityException("SetPixelData: sourceDataStartIndex cannot be less than 0.");
			}
			bool flag2 = !this.isReadable;
			if (flag2)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag3 = data == null || data.Length == 0;
			if (flag3)
			{
				throw new UnityException("No texture data provided to SetPixelData.");
			}
			this.SetPixelDataImplArray(data, mipLevel, Marshal.SizeOf(data[0]), data.Length, sourceDataStartIndex);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00035630 File Offset: 0x00033830
		public void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, [Optional] int sourceDataStartIndex) where T : struct
		{
			bool flag = sourceDataStartIndex < 0;
			if (flag)
			{
				throw new UnityException("SetPixelData: sourceDataStartIndex cannot be less than 0.");
			}
			bool flag2 = !this.isReadable;
			if (flag2)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag3 = !data.IsCreated || data.Length == 0;
			if (flag3)
			{
				throw new UnityException("No texture data provided to SetPixelData.");
			}
			this.SetPixelDataImpl((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), mipLevel, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), data.Length, sourceDataStartIndex);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x000356AC File Offset: 0x000338AC
		public unsafe Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel) where T : struct
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag2 = this.GetWritableImageData(0).ToInt64() == 0L;
			if (flag2)
			{
				throw new UnityException(String.Concat("Texture '", base.name, "' has no data."));
			}
			ulong pixelDataOffset = base.GetPixelDataOffset(mipLevel, 0);
			ulong pixelDataSize = base.GetPixelDataSize(mipLevel, 0);
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			ulong num2 = pixelDataSize / (ulong)((long)num);
			bool flag3 = num2 > 2147483647UL;
			if (flag3)
			{
				throw base.CreateNativeArrayLengthOverflowException();
			}
			IntPtr intPtr;
			intPtr..ctor((long)this.GetWritableImageData(0) + (long)pixelDataOffset);
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)intPtr, (int)num2, Unity.Collections.Allocator.None);
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00035768 File Offset: 0x00033968
		public unsafe Unity.Collections.NativeArray<T> GetRawTextureData<T>() where T : struct
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			ulong num2 = this.GetRawImageDataSize() / (ulong)((long)num);
			bool flag2 = num2 > 2147483647UL;
			if (flag2)
			{
				throw base.CreateNativeArrayLengthOverflowException();
			}
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)this.GetWritableImageData(0), (int)num2, Unity.Collections.Allocator.None);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00008F3E File Offset: 0x0000713E
		public void Apply(bool updateMipmaps)
		{
			this.Apply(updateMipmaps, false);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x000357D0 File Offset: 0x000339D0
		public bool Resize(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.ResizeWithFormatImpl(width, height, format, hasMipMap);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00008F4A File Offset: 0x0000714A
		public void ReadPixels(Rect source, int destX, int destY)
		{
			this.ReadPixels(source, destX, destY, true);
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00035804 File Offset: 0x00033A04
		public static bool GenerateAtlas(Il2CppStructArray<Vector2> sizes, int padding, int atlasSize, List<Rect> results)
		{
			bool flag = sizes == null;
			if (flag)
			{
				throw new ArgumentException("sizes array can not be null");
			}
			bool flag2 = results == null;
			if (flag2)
			{
				throw new ArgumentException("results list cannot be null");
			}
			bool flag3 = padding < 0;
			if (flag3)
			{
				throw new ArgumentException("padding can not be negative");
			}
			bool flag4 = atlasSize <= 0;
			if (flag4)
			{
				throw new ArgumentException("atlas size must be positive");
			}
			results.Clear();
			bool flag5 = sizes.Length == 0;
			bool flag6;
			if (flag5)
			{
				flag6 = true;
			}
			else
			{
				NoAllocHelpers.EnsureListElemCount<Rect>(results, sizes.Length);
				Texture2D.GenerateAtlasImpl(sizes, padding, atlasSize, NoAllocHelpers.ExtractArrayFromListT<Rect>(results));
				flag6 = results.Count != 0;
			}
			return flag6;
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00008F58 File Offset: 0x00007158
		public void SetPixels32(Il2CppStructArray<Color32> colors, int miplevel)
		{
			this.SetAllPixels32(colors, miplevel);
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00008F64 File Offset: 0x00007164
		public void SetPixels32(Il2CppStructArray<Color32> colors)
		{
			this.SetPixels32(colors, 0);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00008F70 File Offset: 0x00007170
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color32> colors, int miplevel)
		{
			this.SetBlockOfPixels32(x, y, blockWidth, blockHeight, colors, miplevel);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00008F83 File Offset: 0x00007183
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color32> colors)
		{
			this.SetPixels32(x, y, blockWidth, blockHeight, colors, 0);
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x000358A8 File Offset: 0x00033AA8
		public Il2CppStructArray<Color> GetPixels(int miplevel)
		{
			int num = this.width >> miplevel;
			bool flag = num < 1;
			if (flag)
			{
				num = 1;
			}
			int num2 = this.height >> miplevel;
			bool flag2 = num2 < 1;
			if (flag2)
			{
				num2 = 1;
			}
			return this.GetPixels(0, 0, num, num2, miplevel);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x000358F4 File Offset: 0x00033AF4
		public Il2CppStructArray<Color> GetPixels()
		{
			return this.GetPixels(0);
		}

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeFieldInfoPtr_streamingMipmapsPriorityMin;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeFieldInfoPtr_streamingMipmapsPriorityMax;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_get_format_Public_get_TextureFormat_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_ResizeImpl_Private_Boolean_Int32_Int32_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelImpl_Private_Color_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelBilinearImpl_Private_Color_Int32_Int32_Single_Single_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr_ResizeWithFormatImpl_Private_Boolean_Int32_Int32_GraphicsFormat_Boolean_0;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr_ReadPixelsImpl_Private_Void_Rect_Int32_Int32_Boolean_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelsImpl_Private_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_Int32_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_TextureFormat_Int32_Boolean_IntPtr_0;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Color_0;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_0;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_0;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeMethodInfoPtr_GetPixel_Public_Color_Int32_Int32_0;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelBilinear_Public_Color_Single_Single_0;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Boolean_Int32_Int32_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Boolean_Int32_Int32_TextureFormat_Boolean_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_Boolean_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelBilinearImpl_Injected_Private_Void_Int32_Int32_Single_Single_byref_Color_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_ReadPixelsImpl_Injected_Private_Void_byref_Rect_Int32_Int32_Boolean_0;

		// Token: 0x04000951 RID: 2385
		private static readonly Texture2D.get_ignoreMipmapLimitDelegate get_ignoreMipmapLimitDelegateField;

		// Token: 0x04000952 RID: 2386
		private static readonly Texture2D.set_ignoreMipmapLimitDelegate set_ignoreMipmapLimitDelegateField;

		// Token: 0x04000953 RID: 2387
		private static readonly Texture2D.get_blackTextureDelegate get_blackTextureDelegateField;

		// Token: 0x04000954 RID: 2388
		private static readonly Texture2D.get_redTextureDelegate get_redTextureDelegateField;

		// Token: 0x04000955 RID: 2389
		private static readonly Texture2D.get_grayTextureDelegate get_grayTextureDelegateField;

		// Token: 0x04000956 RID: 2390
		private static readonly Texture2D.get_linearGrayTextureDelegate get_linearGrayTextureDelegateField;

		// Token: 0x04000957 RID: 2391
		private static readonly Texture2D.get_normalTextureDelegate get_normalTextureDelegateField;

		// Token: 0x04000958 RID: 2392
		private static readonly Texture2D.CompressDelegate CompressDelegateField;

		// Token: 0x04000959 RID: 2393
		private static readonly Texture2D.get_vtOnlyDelegate get_vtOnlyDelegateField;

		// Token: 0x0400095A RID: 2394
		private static readonly Texture2D.LoadRawTextureDataImplDelegate LoadRawTextureDataImplDelegateField;

		// Token: 0x0400095B RID: 2395
		private static readonly Texture2D.LoadRawTextureDataImplArrayDelegate LoadRawTextureDataImplArrayDelegateField;

		// Token: 0x0400095C RID: 2396
		private static readonly Texture2D.SetPixelDataImplArrayDelegate SetPixelDataImplArrayDelegateField;

		// Token: 0x0400095D RID: 2397
		private static readonly Texture2D.SetPixelDataImplDelegate SetPixelDataImplDelegateField;

		// Token: 0x0400095E RID: 2398
		private static readonly Texture2D.GetWritableImageDataDelegate GetWritableImageDataDelegateField;

		// Token: 0x0400095F RID: 2399
		private static readonly Texture2D.GetRawImageDataSizeDelegate GetRawImageDataSizeDelegateField;

		// Token: 0x04000960 RID: 2400
		private static readonly Texture2D.GenerateAtlasImplDelegate GenerateAtlasImplDelegateField;

		// Token: 0x04000961 RID: 2401
		private static readonly Texture2D.get_isPreProcessedDelegate get_isPreProcessedDelegateField;

		// Token: 0x04000962 RID: 2402
		private static readonly Texture2D.get_streamingMipmapsDelegate get_streamingMipmapsDelegateField;

		// Token: 0x04000963 RID: 2403
		private static readonly Texture2D.get_streamingMipmapsPriorityDelegate get_streamingMipmapsPriorityDelegateField;

		// Token: 0x04000964 RID: 2404
		private static readonly Texture2D.get_requestedMipmapLevelDelegate get_requestedMipmapLevelDelegateField;

		// Token: 0x04000965 RID: 2405
		private static readonly Texture2D.set_requestedMipmapLevelDelegate set_requestedMipmapLevelDelegateField;

		// Token: 0x04000966 RID: 2406
		private static readonly Texture2D.get_minimumMipmapLevelDelegate get_minimumMipmapLevelDelegateField;

		// Token: 0x04000967 RID: 2407
		private static readonly Texture2D.set_minimumMipmapLevelDelegate set_minimumMipmapLevelDelegateField;

		// Token: 0x04000968 RID: 2408
		private static readonly Texture2D.get_loadAllMipsDelegate get_loadAllMipsDelegateField;

		// Token: 0x04000969 RID: 2409
		private static readonly Texture2D.set_loadAllMipsDelegate set_loadAllMipsDelegateField;

		// Token: 0x0400096A RID: 2410
		private static readonly Texture2D.get_calculatedMipmapLevelDelegate get_calculatedMipmapLevelDelegateField;

		// Token: 0x0400096B RID: 2411
		private static readonly Texture2D.get_desiredMipmapLevelDelegate get_desiredMipmapLevelDelegateField;

		// Token: 0x0400096C RID: 2412
		private static readonly Texture2D.get_loadingMipmapLevelDelegate get_loadingMipmapLevelDelegateField;

		// Token: 0x0400096D RID: 2413
		private static readonly Texture2D.get_loadedMipmapLevelDelegate get_loadedMipmapLevelDelegateField;

		// Token: 0x0400096E RID: 2414
		private static readonly Texture2D.ClearRequestedMipmapLevelDelegate ClearRequestedMipmapLevelDelegateField;

		// Token: 0x0400096F RID: 2415
		private static readonly Texture2D.IsRequestedMipmapLevelLoadedDelegate IsRequestedMipmapLevelLoadedDelegateField;

		// Token: 0x04000970 RID: 2416
		private static readonly Texture2D.ClearMinimumMipmapLevelDelegate ClearMinimumMipmapLevelDelegateField;

		// Token: 0x04000971 RID: 2417
		private static readonly Texture2D.UpdateExternalTextureDelegate UpdateExternalTextureDelegateField;

		// Token: 0x04000972 RID: 2418
		private static readonly Texture2D.SetAllPixels32Delegate SetAllPixels32DelegateField;

		// Token: 0x04000973 RID: 2419
		private static readonly Texture2D.SetBlockOfPixels32Delegate SetBlockOfPixels32DelegateField;

		// Token: 0x04000974 RID: 2420
		private static readonly Texture2D.GetRawTextureDataDelegate GetRawTextureDataDelegateField;

		// Token: 0x04000975 RID: 2421
		private static readonly Texture2D.GetPixelsDelegate GetPixelsDelegateField;

		// Token: 0x04000976 RID: 2422
		private static readonly Texture2D.GetPixels32Delegate GetPixels32DelegateField;

		// Token: 0x04000977 RID: 2423
		private static readonly Texture2D.PackTexturesDelegate PackTexturesDelegateField;

		// Token: 0x020006C7 RID: 1735
		public enum EXRFlags
		{
			// Token: 0x04001EF3 RID: 7923
			None,
			// Token: 0x04001EF4 RID: 7924
			OutputAsFloat,
			// Token: 0x04001EF5 RID: 7925
			CompressZIP,
			// Token: 0x04001EF6 RID: 7926
			CompressRLE = 4,
			// Token: 0x04001EF7 RID: 7927
			CompressPIZ = 8
		}

		// Token: 0x020006C8 RID: 1736
		// (Invoke) Token: 0x06002BAD RID: 11181
		private delegate bool get_ignoreMipmapLimitDelegate(IntPtr @this);

		// Token: 0x020006C9 RID: 1737
		// (Invoke) Token: 0x06002BAF RID: 11183
		private delegate void set_ignoreMipmapLimitDelegate(IntPtr @this, bool value);

		// Token: 0x020006CA RID: 1738
		// (Invoke) Token: 0x06002BB1 RID: 11185
		private delegate IntPtr get_blackTextureDelegate();

		// Token: 0x020006CB RID: 1739
		// (Invoke) Token: 0x06002BB3 RID: 11187
		private delegate IntPtr get_redTextureDelegate();

		// Token: 0x020006CC RID: 1740
		// (Invoke) Token: 0x06002BB5 RID: 11189
		private delegate IntPtr get_grayTextureDelegate();

		// Token: 0x020006CD RID: 1741
		// (Invoke) Token: 0x06002BB7 RID: 11191
		private delegate IntPtr get_linearGrayTextureDelegate();

		// Token: 0x020006CE RID: 1742
		// (Invoke) Token: 0x06002BB9 RID: 11193
		private delegate IntPtr get_normalTextureDelegate();

		// Token: 0x020006CF RID: 1743
		// (Invoke) Token: 0x06002BBB RID: 11195
		private delegate void CompressDelegate(IntPtr @this, bool highQuality);

		// Token: 0x020006D0 RID: 1744
		// (Invoke) Token: 0x06002BBD RID: 11197
		private delegate bool get_vtOnlyDelegate(IntPtr @this);

		// Token: 0x020006D1 RID: 1745
		// (Invoke) Token: 0x06002BBF RID: 11199
		private delegate bool LoadRawTextureDataImplDelegate(IntPtr @this, IntPtr data, ulong size);

		// Token: 0x020006D2 RID: 1746
		// (Invoke) Token: 0x06002BC1 RID: 11201
		private delegate bool LoadRawTextureDataImplArrayDelegate(IntPtr @this, IntPtr data);

		// Token: 0x020006D3 RID: 1747
		// (Invoke) Token: 0x06002BC3 RID: 11203
		private delegate bool SetPixelDataImplArrayDelegate(IntPtr @this, IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x020006D4 RID: 1748
		// (Invoke) Token: 0x06002BC5 RID: 11205
		private delegate bool SetPixelDataImplDelegate(IntPtr @this, IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x020006D5 RID: 1749
		// (Invoke) Token: 0x06002BC7 RID: 11207
		private delegate IntPtr GetWritableImageDataDelegate(IntPtr @this, int frame);

		// Token: 0x020006D6 RID: 1750
		// (Invoke) Token: 0x06002BC9 RID: 11209
		private delegate ulong GetRawImageDataSizeDelegate(IntPtr @this);

		// Token: 0x020006D7 RID: 1751
		// (Invoke) Token: 0x06002BCB RID: 11211
		private delegate void GenerateAtlasImplDelegate(IntPtr sizes, int padding, int atlasSize, [Out] IntPtr rect);

		// Token: 0x020006D8 RID: 1752
		// (Invoke) Token: 0x06002BCD RID: 11213
		private delegate bool get_isPreProcessedDelegate(IntPtr @this);

		// Token: 0x020006D9 RID: 1753
		// (Invoke) Token: 0x06002BCF RID: 11215
		private delegate bool get_streamingMipmapsDelegate(IntPtr @this);

		// Token: 0x020006DA RID: 1754
		// (Invoke) Token: 0x06002BD1 RID: 11217
		private delegate int get_streamingMipmapsPriorityDelegate(IntPtr @this);

		// Token: 0x020006DB RID: 1755
		// (Invoke) Token: 0x06002BD3 RID: 11219
		private delegate int get_requestedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006DC RID: 1756
		// (Invoke) Token: 0x06002BD5 RID: 11221
		private delegate void set_requestedMipmapLevelDelegate(IntPtr @this, int value);

		// Token: 0x020006DD RID: 1757
		// (Invoke) Token: 0x06002BD7 RID: 11223
		private delegate int get_minimumMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006DE RID: 1758
		// (Invoke) Token: 0x06002BD9 RID: 11225
		private delegate void set_minimumMipmapLevelDelegate(IntPtr @this, int value);

		// Token: 0x020006DF RID: 1759
		// (Invoke) Token: 0x06002BDB RID: 11227
		private delegate bool get_loadAllMipsDelegate(IntPtr @this);

		// Token: 0x020006E0 RID: 1760
		// (Invoke) Token: 0x06002BDD RID: 11229
		private delegate void set_loadAllMipsDelegate(IntPtr @this, bool value);

		// Token: 0x020006E1 RID: 1761
		// (Invoke) Token: 0x06002BDF RID: 11231
		private delegate int get_calculatedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006E2 RID: 1762
		// (Invoke) Token: 0x06002BE1 RID: 11233
		private delegate int get_desiredMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006E3 RID: 1763
		// (Invoke) Token: 0x06002BE3 RID: 11235
		private delegate int get_loadingMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006E4 RID: 1764
		// (Invoke) Token: 0x06002BE5 RID: 11237
		private delegate int get_loadedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006E5 RID: 1765
		// (Invoke) Token: 0x06002BE7 RID: 11239
		private delegate void ClearRequestedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006E6 RID: 1766
		// (Invoke) Token: 0x06002BE9 RID: 11241
		private delegate bool IsRequestedMipmapLevelLoadedDelegate(IntPtr @this);

		// Token: 0x020006E7 RID: 1767
		// (Invoke) Token: 0x06002BEB RID: 11243
		private delegate void ClearMinimumMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006E8 RID: 1768
		// (Invoke) Token: 0x06002BED RID: 11245
		private delegate void UpdateExternalTextureDelegate(IntPtr @this, IntPtr nativeTex);

		// Token: 0x020006E9 RID: 1769
		// (Invoke) Token: 0x06002BEF RID: 11247
		private delegate void SetAllPixels32Delegate(IntPtr @this, IntPtr colors, int miplevel);

		// Token: 0x020006EA RID: 1770
		// (Invoke) Token: 0x06002BF1 RID: 11249
		private delegate void SetBlockOfPixels32Delegate(IntPtr @this, int x, int y, int blockWidth, int blockHeight, IntPtr colors, int miplevel);

		// Token: 0x020006EB RID: 1771
		// (Invoke) Token: 0x06002BF3 RID: 11251
		private delegate IntPtr GetRawTextureDataDelegate(IntPtr @this);

		// Token: 0x020006EC RID: 1772
		// (Invoke) Token: 0x06002BF5 RID: 11253
		private delegate IntPtr GetPixelsDelegate(IntPtr @this, int x, int y, int blockWidth, int blockHeight, int miplevel);

		// Token: 0x020006ED RID: 1773
		// (Invoke) Token: 0x06002BF7 RID: 11255
		private delegate IntPtr GetPixels32Delegate(IntPtr @this, int miplevel);

		// Token: 0x020006EE RID: 1774
		// (Invoke) Token: 0x06002BF9 RID: 11257
		private delegate IntPtr PackTexturesDelegate(IntPtr @this, IntPtr textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable);
	}
}
