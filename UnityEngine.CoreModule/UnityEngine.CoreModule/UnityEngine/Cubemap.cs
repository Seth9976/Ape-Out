using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x02000092 RID: 146
	public sealed class Cubemap : Texture
	{
		// Token: 0x06000CD1 RID: 3281 RVA: 0x00035910 File Offset: 0x00033B10
		// Note: this type is marked as 'beforefieldinit'.
		static Cubemap()
		{
			Il2CppClassPointerStore<Cubemap>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Cubemap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cubemap>.NativeClassPtr);
			Cubemap.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664179);
			Cubemap.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664180);
			Cubemap.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664181);
			Cubemap.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664182);
			Cubemap.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664183);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664184);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664185);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664186);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664187);
			Cubemap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664188);
			Cubemap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664189);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664190);
			Cubemap.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664191);
			Cubemap.get_formatDelegateField = IL2CPP.ResolveICall<Cubemap.get_formatDelegate>("UnityEngine.Cubemap::get_format");
			Cubemap.ApplyImplDelegateField = IL2CPP.ResolveICall<Cubemap.ApplyImplDelegate>("UnityEngine.Cubemap::ApplyImpl");
			Cubemap.UpdateExternalTextureDelegateField = IL2CPP.ResolveICall<Cubemap.UpdateExternalTextureDelegate>("UnityEngine.Cubemap::UpdateExternalTexture");
			Cubemap.SmoothEdgesDelegateField = IL2CPP.ResolveICall<Cubemap.SmoothEdgesDelegate>("UnityEngine.Cubemap::SmoothEdges");
			Cubemap.GetPixelsDelegateField = IL2CPP.ResolveICall<Cubemap.GetPixelsDelegate>("UnityEngine.Cubemap::GetPixels");
			Cubemap.SetPixelsDelegateField = IL2CPP.ResolveICall<Cubemap.SetPixelsDelegate>("UnityEngine.Cubemap::SetPixels");
			Cubemap.SetPixelDataImplArrayDelegateField = IL2CPP.ResolveICall<Cubemap.SetPixelDataImplArrayDelegate>("UnityEngine.Cubemap::SetPixelDataImplArray");
			Cubemap.SetPixelDataImplDelegateField = IL2CPP.ResolveICall<Cubemap.SetPixelDataImplDelegate>("UnityEngine.Cubemap::SetPixelDataImpl");
			Cubemap.GetWritableImageDataDelegateField = IL2CPP.ResolveICall<Cubemap.GetWritableImageDataDelegate>("UnityEngine.Cubemap::GetWritableImageData");
			Cubemap.get_isPreProcessedDelegateField = IL2CPP.ResolveICall<Cubemap.get_isPreProcessedDelegate>("UnityEngine.Cubemap::get_isPreProcessed");
			Cubemap.get_streamingMipmapsDelegateField = IL2CPP.ResolveICall<Cubemap.get_streamingMipmapsDelegate>("UnityEngine.Cubemap::get_streamingMipmaps");
			Cubemap.get_streamingMipmapsPriorityDelegateField = IL2CPP.ResolveICall<Cubemap.get_streamingMipmapsPriorityDelegate>("UnityEngine.Cubemap::get_streamingMipmapsPriority");
			Cubemap.get_requestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.get_requestedMipmapLevelDelegate>("UnityEngine.Cubemap::get_requestedMipmapLevel");
			Cubemap.set_requestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.set_requestedMipmapLevelDelegate>("UnityEngine.Cubemap::set_requestedMipmapLevel");
			Cubemap.get_loadAllMipsDelegateField = IL2CPP.ResolveICall<Cubemap.get_loadAllMipsDelegate>("UnityEngine.Cubemap::get_loadAllMips");
			Cubemap.set_loadAllMipsDelegateField = IL2CPP.ResolveICall<Cubemap.set_loadAllMipsDelegate>("UnityEngine.Cubemap::set_loadAllMips");
			Cubemap.get_desiredMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.get_desiredMipmapLevelDelegate>("UnityEngine.Cubemap::get_desiredMipmapLevel");
			Cubemap.get_loadingMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.get_loadingMipmapLevelDelegate>("UnityEngine.Cubemap::get_loadingMipmapLevel");
			Cubemap.get_loadedMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.get_loadedMipmapLevelDelegate>("UnityEngine.Cubemap::get_loadedMipmapLevel");
			Cubemap.ClearRequestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.ClearRequestedMipmapLevelDelegate>("UnityEngine.Cubemap::ClearRequestedMipmapLevel");
			Cubemap.IsRequestedMipmapLevelLoadedDelegateField = IL2CPP.ResolveICall<Cubemap.IsRequestedMipmapLevelLoadedDelegate>("UnityEngine.Cubemap::IsRequestedMipmapLevelLoaded");
			Cubemap.SetPixelImpl_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.SetPixelImpl_InjectedDelegate>("UnityEngine.Cubemap::SetPixelImpl_Injected");
			Cubemap.GetPixelImpl_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.GetPixelImpl_InjectedDelegate>("UnityEngine.Cubemap::GetPixelImpl_Injected");
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00035BA0 File Offset: 0x00033DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490542, XrefRangeEnd = 490546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00035C28 File Offset: 0x00033E28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 490548, RefRangeEnd = 490552, XrefRangeStart = 490546, XrefRangeEnd = 490548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x00035CA4 File Offset: 0x00033EA4
		public unsafe override bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490552, XrefRangeEnd = 490556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00035CE0 File Offset: 0x00033EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490556, XrefRangeEnd = 490559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(TextureFormat format, int width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00035D38 File Offset: 0x00033F38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 490564, RefRangeEnd = 490567, XrefRangeStart = 490559, XrefRangeEnd = 490564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00035D90 File Offset: 0x00033F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490567, XrefRangeEnd = 490581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00035DF4 File Offset: 0x00033FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490581, XrefRangeEnd = 490593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00035E58 File Offset: 0x00034058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490593, XrefRangeEnd = 490595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, TextureFormat format, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00035EBC File Offset: 0x000340BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490595, XrefRangeEnd = 490605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00035F30 File Offset: 0x00034130
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 490618, RefRangeEnd = 490621, XrefRangeStart = 490605, XrefRangeEnd = 490618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00035FA4 File Offset: 0x000341A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490621, XrefRangeEnd = 490623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00036018 File Offset: 0x00034218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490623, XrefRangeEnd = 490625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, TextureFormat textureFormat, bool mipChain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0003607C File Offset: 0x0003427C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 490625, RefRangeEnd = 490627, XrefRangeStart = 490625, XrefRangeEnd = 490625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00008F95 File Offset: 0x00007195
		public Cubemap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x00008F9E File Offset: 0x0000719E
		public TextureFormat format
		{
			get
			{
				return Cubemap.get_formatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00008FB0 File Offset: 0x000071B0
		public void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
			Cubemap.ApplyImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00008FC4 File Offset: 0x000071C4
		public void UpdateExternalTexture(IntPtr nativeTexture)
		{
			Cubemap.UpdateExternalTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nativeTexture);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00008FD7 File Offset: 0x000071D7
		public void SetPixelImpl(int image, int mip, int x, int y, Color color)
		{
			this.SetPixelImpl_Injected(image, mip, x, y, ref color);
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000360B0 File Offset: 0x000342B0
		public Color GetPixelImpl(int image, int mip, int x, int y)
		{
			Color color;
			this.GetPixelImpl_Injected(image, mip, x, y, out color);
			return color;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00008FE6 File Offset: 0x000071E6
		public void SmoothEdges(int smoothRegionWidthInPixels)
		{
			Cubemap.SmoothEdgesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), smoothRegionWidthInPixels);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00008FF9 File Offset: 0x000071F9
		public void SmoothEdges()
		{
			this.SmoothEdges(1);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x000360CC File Offset: 0x000342CC
		public Il2CppStructArray<Color> GetPixels(CubemapFace face, int miplevel)
		{
			IntPtr intPtr = Cubemap.GetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), face, miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x000360FC File Offset: 0x000342FC
		public Il2CppStructArray<Color> GetPixels(CubemapFace face)
		{
			return this.GetPixels(face, 0);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00009004 File Offset: 0x00007204
		public void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face, int miplevel)
		{
			Cubemap.SetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), face, miplevel);
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x0000901E File Offset: 0x0000721E
		public bool SetPixelDataImplArray(Array data, int mipLevel, int face, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Cubemap.SetPixelDataImplArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), mipLevel, face, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0000903E File Offset: 0x0000723E
		public bool SetPixelDataImpl(IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Cubemap.SetPixelDataImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, mipLevel, face, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00009059 File Offset: 0x00007259
		public void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face)
		{
			this.SetPixels(colors, face, 0);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00009066 File Offset: 0x00007266
		public IntPtr GetWritableImageData(int frame)
		{
			return Cubemap.GetWritableImageDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), frame);
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x00009079 File Offset: 0x00007279
		public bool isPreProcessed
		{
			get
			{
				return Cubemap.get_isPreProcessedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x0000908B File Offset: 0x0000728B
		public bool streamingMipmaps
		{
			get
			{
				return Cubemap.get_streamingMipmapsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x0000909D File Offset: 0x0000729D
		public int streamingMipmapsPriority
		{
			get
			{
				return Cubemap.get_streamingMipmapsPriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x000090AF File Offset: 0x000072AF
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x000090C1 File Offset: 0x000072C1
		public int requestedMipmapLevel
		{
			get
			{
				return Cubemap.get_requestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cubemap.set_requestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x000090D4 File Offset: 0x000072D4
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x000090E6 File Offset: 0x000072E6
		public bool loadAllMips
		{
			get
			{
				return Cubemap.get_loadAllMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cubemap.set_loadAllMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x000090F9 File Offset: 0x000072F9
		public int desiredMipmapLevel
		{
			get
			{
				return Cubemap.get_desiredMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0000910B File Offset: 0x0000730B
		public int loadingMipmapLevel
		{
			get
			{
				return Cubemap.get_loadingMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x0000911D File Offset: 0x0000731D
		public int loadedMipmapLevel
		{
			get
			{
				return Cubemap.get_loadedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0000912F File Offset: 0x0000732F
		public void ClearRequestedMipmapLevel()
		{
			Cubemap.ClearRequestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00009141 File Offset: 0x00007341
		public bool IsRequestedMipmapLevelLoaded()
		{
			return Cubemap.IsRequestedMipmapLevelLoadedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00036118 File Offset: 0x00034318
		public static Cubemap CreateExternalTexture(int width, TextureFormat format, bool mipmap, IntPtr nativeTex)
		{
			bool flag = nativeTex == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("nativeTex can not be null");
			}
			return new Cubemap(width, format, mipmap, nativeTex);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00036150 File Offset: 0x00034350
		public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, CubemapFace face, [Optional] int sourceDataStartIndex)
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
			this.SetPixelDataImplArray(data, mipLevel, (int)face, Marshal.SizeOf(data[0]), data.Length, sourceDataStartIndex);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x000361CC File Offset: 0x000343CC
		public void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, CubemapFace face, [Optional] int sourceDataStartIndex) where T : struct
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
			this.SetPixelDataImpl((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), mipLevel, (int)face, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), data.Length, sourceDataStartIndex);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0003624C File Offset: 0x0003444C
		public unsafe Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel, CubemapFace face) where T : struct
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
			ulong pixelDataOffset = base.GetPixelDataOffset(base.mipmapCount, (int)face);
			ulong pixelDataOffset2 = base.GetPixelDataOffset(mipLevel, (int)face);
			ulong pixelDataSize = base.GetPixelDataSize(mipLevel, (int)face);
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			ulong num2 = pixelDataSize / (ulong)((long)num);
			bool flag3 = num2 > 2147483647UL;
			if (flag3)
			{
				throw base.CreateNativeArrayLengthOverflowException();
			}
			IntPtr intPtr;
			intPtr..ctor((long)this.GetWritableImageData(0) + (long)(pixelDataOffset * (ulong)((long)face) + pixelDataOffset2));
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)intPtr, (int)num2, Unity.Collections.Allocator.None);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00009153 File Offset: 0x00007353
		public void SetPixel(CubemapFace face, int x, int y, Color color)
		{
			this.SetPixel(face, x, y, color, 0);
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00036320 File Offset: 0x00034520
		public void SetPixel(CubemapFace face, int x, int y, Color color, int mip)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			this.SetPixelImpl((int)face, mip, x, y, color);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00036354 File Offset: 0x00034554
		public Color GetPixel(CubemapFace face, int x, int y)
		{
			return this.GetPixel(face, x, y, 0);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00036370 File Offset: 0x00034570
		public Color GetPixel(CubemapFace face, int x, int y, int mip)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelImpl((int)face, mip, x, y);
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x000363A4 File Offset: 0x000345A4
		public void Apply(bool updateMipmaps, bool makeNoLongerReadable)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			this.ApplyImpl(updateMipmaps, makeNoLongerReadable);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00009163 File Offset: 0x00007363
		public void Apply(bool updateMipmaps)
		{
			this.Apply(updateMipmaps, false);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0000916F File Offset: 0x0000736F
		public void Apply()
		{
			this.Apply(true, false);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0000917B File Offset: 0x0000737B
		public void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color)
		{
			Cubemap.SetPixelImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), image, mip, x, y, ref color);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00009194 File Offset: 0x00007394
		public void GetPixelImpl_Injected(int image, int mip, int x, int y, out Color ret)
		{
			Cubemap.GetPixelImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), image, mip, x, y, out ret);
		}

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_0;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_0;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_0;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Int32_IntPtr_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Boolean_IntPtr_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;

		// Token: 0x04000985 RID: 2437
		private static readonly Cubemap.get_formatDelegate get_formatDelegateField;

		// Token: 0x04000986 RID: 2438
		private static readonly Cubemap.ApplyImplDelegate ApplyImplDelegateField;

		// Token: 0x04000987 RID: 2439
		private static readonly Cubemap.UpdateExternalTextureDelegate UpdateExternalTextureDelegateField;

		// Token: 0x04000988 RID: 2440
		private static readonly Cubemap.SmoothEdgesDelegate SmoothEdgesDelegateField;

		// Token: 0x04000989 RID: 2441
		private static readonly Cubemap.GetPixelsDelegate GetPixelsDelegateField;

		// Token: 0x0400098A RID: 2442
		private static readonly Cubemap.SetPixelsDelegate SetPixelsDelegateField;

		// Token: 0x0400098B RID: 2443
		private static readonly Cubemap.SetPixelDataImplArrayDelegate SetPixelDataImplArrayDelegateField;

		// Token: 0x0400098C RID: 2444
		private static readonly Cubemap.SetPixelDataImplDelegate SetPixelDataImplDelegateField;

		// Token: 0x0400098D RID: 2445
		private static readonly Cubemap.GetWritableImageDataDelegate GetWritableImageDataDelegateField;

		// Token: 0x0400098E RID: 2446
		private static readonly Cubemap.get_isPreProcessedDelegate get_isPreProcessedDelegateField;

		// Token: 0x0400098F RID: 2447
		private static readonly Cubemap.get_streamingMipmapsDelegate get_streamingMipmapsDelegateField;

		// Token: 0x04000990 RID: 2448
		private static readonly Cubemap.get_streamingMipmapsPriorityDelegate get_streamingMipmapsPriorityDelegateField;

		// Token: 0x04000991 RID: 2449
		private static readonly Cubemap.get_requestedMipmapLevelDelegate get_requestedMipmapLevelDelegateField;

		// Token: 0x04000992 RID: 2450
		private static readonly Cubemap.set_requestedMipmapLevelDelegate set_requestedMipmapLevelDelegateField;

		// Token: 0x04000993 RID: 2451
		private static readonly Cubemap.get_loadAllMipsDelegate get_loadAllMipsDelegateField;

		// Token: 0x04000994 RID: 2452
		private static readonly Cubemap.set_loadAllMipsDelegate set_loadAllMipsDelegateField;

		// Token: 0x04000995 RID: 2453
		private static readonly Cubemap.get_desiredMipmapLevelDelegate get_desiredMipmapLevelDelegateField;

		// Token: 0x04000996 RID: 2454
		private static readonly Cubemap.get_loadingMipmapLevelDelegate get_loadingMipmapLevelDelegateField;

		// Token: 0x04000997 RID: 2455
		private static readonly Cubemap.get_loadedMipmapLevelDelegate get_loadedMipmapLevelDelegateField;

		// Token: 0x04000998 RID: 2456
		private static readonly Cubemap.ClearRequestedMipmapLevelDelegate ClearRequestedMipmapLevelDelegateField;

		// Token: 0x04000999 RID: 2457
		private static readonly Cubemap.IsRequestedMipmapLevelLoadedDelegate IsRequestedMipmapLevelLoadedDelegateField;

		// Token: 0x0400099A RID: 2458
		private static readonly Cubemap.SetPixelImpl_InjectedDelegate SetPixelImpl_InjectedDelegateField;

		// Token: 0x0400099B RID: 2459
		private static readonly Cubemap.GetPixelImpl_InjectedDelegate GetPixelImpl_InjectedDelegateField;

		// Token: 0x020006EF RID: 1775
		// (Invoke) Token: 0x06002BFB RID: 11259
		private delegate TextureFormat get_formatDelegate(IntPtr @this);

		// Token: 0x020006F0 RID: 1776
		// (Invoke) Token: 0x06002BFD RID: 11261
		private delegate void ApplyImplDelegate(IntPtr @this, bool updateMipmaps, bool makeNoLongerReadable);

		// Token: 0x020006F1 RID: 1777
		// (Invoke) Token: 0x06002BFF RID: 11263
		private delegate void UpdateExternalTextureDelegate(IntPtr @this, IntPtr nativeTexture);

		// Token: 0x020006F2 RID: 1778
		// (Invoke) Token: 0x06002C01 RID: 11265
		private delegate void SmoothEdgesDelegate(IntPtr @this, int smoothRegionWidthInPixels);

		// Token: 0x020006F3 RID: 1779
		// (Invoke) Token: 0x06002C03 RID: 11267
		private delegate IntPtr GetPixelsDelegate(IntPtr @this, CubemapFace face, int miplevel);

		// Token: 0x020006F4 RID: 1780
		// (Invoke) Token: 0x06002C05 RID: 11269
		private delegate void SetPixelsDelegate(IntPtr @this, IntPtr colors, CubemapFace face, int miplevel);

		// Token: 0x020006F5 RID: 1781
		// (Invoke) Token: 0x06002C07 RID: 11271
		private delegate bool SetPixelDataImplArrayDelegate(IntPtr @this, IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x020006F6 RID: 1782
		// (Invoke) Token: 0x06002C09 RID: 11273
		private delegate bool SetPixelDataImplDelegate(IntPtr @this, IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x020006F7 RID: 1783
		// (Invoke) Token: 0x06002C0B RID: 11275
		private delegate IntPtr GetWritableImageDataDelegate(IntPtr @this, int frame);

		// Token: 0x020006F8 RID: 1784
		// (Invoke) Token: 0x06002C0D RID: 11277
		private delegate bool get_isPreProcessedDelegate(IntPtr @this);

		// Token: 0x020006F9 RID: 1785
		// (Invoke) Token: 0x06002C0F RID: 11279
		private delegate bool get_streamingMipmapsDelegate(IntPtr @this);

		// Token: 0x020006FA RID: 1786
		// (Invoke) Token: 0x06002C11 RID: 11281
		private delegate int get_streamingMipmapsPriorityDelegate(IntPtr @this);

		// Token: 0x020006FB RID: 1787
		// (Invoke) Token: 0x06002C13 RID: 11283
		private delegate int get_requestedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020006FC RID: 1788
		// (Invoke) Token: 0x06002C15 RID: 11285
		private delegate void set_requestedMipmapLevelDelegate(IntPtr @this, int value);

		// Token: 0x020006FD RID: 1789
		// (Invoke) Token: 0x06002C17 RID: 11287
		private delegate bool get_loadAllMipsDelegate(IntPtr @this);

		// Token: 0x020006FE RID: 1790
		// (Invoke) Token: 0x06002C19 RID: 11289
		private delegate void set_loadAllMipsDelegate(IntPtr @this, bool value);

		// Token: 0x020006FF RID: 1791
		// (Invoke) Token: 0x06002C1B RID: 11291
		private delegate int get_desiredMipmapLevelDelegate(IntPtr @this);

		// Token: 0x02000700 RID: 1792
		// (Invoke) Token: 0x06002C1D RID: 11293
		private delegate int get_loadingMipmapLevelDelegate(IntPtr @this);

		// Token: 0x02000701 RID: 1793
		// (Invoke) Token: 0x06002C1F RID: 11295
		private delegate int get_loadedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x02000702 RID: 1794
		// (Invoke) Token: 0x06002C21 RID: 11297
		private delegate void ClearRequestedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x02000703 RID: 1795
		// (Invoke) Token: 0x06002C23 RID: 11299
		private delegate bool IsRequestedMipmapLevelLoadedDelegate(IntPtr @this);

		// Token: 0x02000704 RID: 1796
		// (Invoke) Token: 0x06002C25 RID: 11301
		private delegate void SetPixelImpl_InjectedDelegate(IntPtr @this, int image, int mip, int x, int y, IntPtr color);

		// Token: 0x02000705 RID: 1797
		// (Invoke) Token: 0x06002C27 RID: 11303
		private delegate void GetPixelImpl_InjectedDelegate(IntPtr @this, int image, int mip, int x, int y, [Out] IntPtr ret);
	}
}
