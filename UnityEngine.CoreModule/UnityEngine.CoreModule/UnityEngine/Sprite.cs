using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000108 RID: 264
	public sealed class Sprite : Object
	{
		// Token: 0x06001684 RID: 5764 RVA: 0x00057CC4 File Offset: 0x00055EC4
		// Note: this type is marked as 'beforefieldinit'.
		static Sprite()
		{
			Il2CppClassPointerStore<Sprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Sprite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sprite>.NativeClassPtr);
			Sprite.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665298);
			Sprite.NativeMethodInfoPtr_GetPackingMode_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665299);
			Sprite.NativeMethodInfoPtr_GetPacked_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665300);
			Sprite.NativeMethodInfoPtr_GetTextureRect_Internal_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665301);
			Sprite.NativeMethodInfoPtr_GetInnerUVs_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665302);
			Sprite.NativeMethodInfoPtr_GetOuterUVs_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665303);
			Sprite.NativeMethodInfoPtr_GetPadding_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665304);
			Sprite.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665305);
			Sprite.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665306);
			Sprite.NativeMethodInfoPtr_get_border_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665307);
			Sprite.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665308);
			Sprite.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665309);
			Sprite.NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665310);
			Sprite.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665311);
			Sprite.NativeMethodInfoPtr_get_packed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665312);
			Sprite.NativeMethodInfoPtr_get_packingMode_Public_get_SpritePackingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665313);
			Sprite.NativeMethodInfoPtr_get_textureRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665314);
			Sprite.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665315);
			Sprite.NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665316);
			Sprite.NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665317);
			Sprite.NativeMethodInfoPtr_GetTextureRect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665318);
			Sprite.NativeMethodInfoPtr_GetInnerUVs_Injected_Private_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665319);
			Sprite.NativeMethodInfoPtr_GetOuterUVs_Injected_Private_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665320);
			Sprite.NativeMethodInfoPtr_GetPadding_Injected_Private_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665321);
			Sprite.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665322);
			Sprite.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665323);
			Sprite.NativeMethodInfoPtr_get_border_Injected_Private_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665324);
			Sprite.NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100665325);
			Sprite.GetPackingRotationDelegateField = IL2CPP.ResolveICall<Sprite.GetPackingRotationDelegate>("UnityEngine.Sprite::GetPackingRotation");
			Sprite.GetSecondaryTextureDelegateField = IL2CPP.ResolveICall<Sprite.GetSecondaryTextureDelegate>("UnityEngine.Sprite::GetSecondaryTexture");
			Sprite.get_spriteAtlasTextureScaleDelegateField = IL2CPP.ResolveICall<Sprite.get_spriteAtlasTextureScaleDelegate>("UnityEngine.Sprite::get_spriteAtlasTextureScale");
			Sprite.GetPhysicsShapeCountDelegateField = IL2CPP.ResolveICall<Sprite.GetPhysicsShapeCountDelegate>("UnityEngine.Sprite::GetPhysicsShapeCount");
			Sprite.Internal_GetPhysicsShapePointCountDelegateField = IL2CPP.ResolveICall<Sprite.Internal_GetPhysicsShapePointCountDelegate>("UnityEngine.Sprite::Internal_GetPhysicsShapePointCount");
			Sprite.GetPhysicsShapeImplDelegateField = IL2CPP.ResolveICall<Sprite.GetPhysicsShapeImplDelegate>("UnityEngine.Sprite::GetPhysicsShapeImpl");
			Sprite.OverridePhysicsShapeCountDelegateField = IL2CPP.ResolveICall<Sprite.OverridePhysicsShapeCountDelegate>("UnityEngine.Sprite::OverridePhysicsShapeCount");
			Sprite.OverridePhysicsShapeDelegateField = IL2CPP.ResolveICall<Sprite.OverridePhysicsShapeDelegate>("UnityEngine.Sprite::OverridePhysicsShape");
			Sprite.OverrideGeometryDelegateField = IL2CPP.ResolveICall<Sprite.OverrideGeometryDelegate>("UnityEngine.Sprite::OverrideGeometry");
			Sprite.GetTextureRectOffset_InjectedDelegateField = IL2CPP.ResolveICall<Sprite.GetTextureRectOffset_InjectedDelegate>("UnityEngine.Sprite::GetTextureRectOffset_Injected");
			Sprite.CreateSpriteWithoutTextureScripting_InjectedDelegateField = IL2CPP.ResolveICall<Sprite.CreateSpriteWithoutTextureScripting_InjectedDelegate>("UnityEngine.Sprite::CreateSpriteWithoutTextureScripting_Injected");
			Sprite.CreateSprite_InjectedDelegateField = IL2CPP.ResolveICall<Sprite.CreateSprite_InjectedDelegate>("UnityEngine.Sprite::CreateSprite_Injected");
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00057FD8 File Offset: 0x000561D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500097, XrefRangeEnd = 500100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sprite>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00058014 File Offset: 0x00056214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500100, XrefRangeEnd = 500104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPackingMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPackingMode_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00058050 File Offset: 0x00056250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500104, XrefRangeEnd = 500108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPacked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPacked_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x0005808C File Offset: 0x0005628C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500108, XrefRangeEnd = 500110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetTextureRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetTextureRect_Internal_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x000580C8 File Offset: 0x000562C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500110, XrefRangeEnd = 500112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetInnerUVs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetInnerUVs_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00058104 File Offset: 0x00056304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500112, XrefRangeEnd = 500114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetOuterUVs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetOuterUVs_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00058140 File Offset: 0x00056340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500114, XrefRangeEnd = 500116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetPadding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPadding_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x0005817C File Offset: 0x0005637C
		public unsafe Bounds bounds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500116, XrefRangeEnd = 500118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600168D RID: 5773 RVA: 0x000581B8 File Offset: 0x000563B8
		public unsafe Rect rect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500118, XrefRangeEnd = 500120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x000581F4 File Offset: 0x000563F4
		public unsafe Vector4 border
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500120, XrefRangeEnd = 500122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_border_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x00058230 File Offset: 0x00056430
		public unsafe Texture2D texture
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 500126, RefRangeEnd = 500132, XrefRangeStart = 500122, XrefRangeEnd = 500126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x00058270 File Offset: 0x00056470
		public unsafe float pixelsPerUnit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500132, XrefRangeEnd = 500136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x000582AC File Offset: 0x000564AC
		public unsafe Texture2D associatedAlphaSplitTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500136, XrefRangeEnd = 500140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x000582EC File Offset: 0x000564EC
		public unsafe Vector2 pivot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500140, XrefRangeEnd = 500142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x00058328 File Offset: 0x00056528
		public unsafe bool packed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 500144, RefRangeEnd = 500145, XrefRangeStart = 500142, XrefRangeEnd = 500144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_packed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x00058364 File Offset: 0x00056564
		public unsafe SpritePackingMode packingMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_packingMode_Public_get_SpritePackingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x000583A0 File Offset: 0x000565A0
		public unsafe Rect textureRect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 500149, RefRangeEnd = 500151, XrefRangeStart = 500145, XrefRangeEnd = 500149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_textureRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x000583DC File Offset: 0x000565DC
		public unsafe Il2CppStructArray<Vector2> vertices
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500151, XrefRangeEnd = 500155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x0005841C File Offset: 0x0005661C
		public unsafe Il2CppStructArray<ushort> triangles
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500155, XrefRangeEnd = 500159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr3) : null;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x0005845C File Offset: 0x0005665C
		public unsafe Il2CppStructArray<Vector2> uv
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500159, XrefRangeEnd = 500163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x0005849C File Offset: 0x0005669C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500163, XrefRangeEnd = 500167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTextureRect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetTextureRect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x000584DC File Offset: 0x000566DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500167, XrefRangeEnd = 500171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetInnerUVs_Injected(out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetInnerUVs_Injected_Private_Void_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x0005851C File Offset: 0x0005671C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500171, XrefRangeEnd = 500175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetOuterUVs_Injected(out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetOuterUVs_Injected_Private_Void_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x0005855C File Offset: 0x0005675C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500175, XrefRangeEnd = 500179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPadding_Injected(out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPadding_Injected_Private_Void_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x0005859C File Offset: 0x0005679C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500179, XrefRangeEnd = 500183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x000585DC File Offset: 0x000567DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500183, XrefRangeEnd = 500187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x0005861C File Offset: 0x0005681C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500187, XrefRangeEnd = 500191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_border_Injected(out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_border_Injected_Private_Void_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x0005865C File Offset: 0x0005685C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500191, XrefRangeEnd = 500195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_pivot_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x0000C1EA File Offset: 0x0000A3EA
		public Sprite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x0000C1F3 File Offset: 0x0000A3F3
		public int GetPackingRotation()
		{
			return Sprite.GetPackingRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0005869C File Offset: 0x0005689C
		public Vector2 GetTextureRectOffset()
		{
			Vector2 vector;
			this.GetTextureRectOffset_Injected(out vector);
			return vector;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x0000C205 File Offset: 0x0000A405
		public static Sprite CreateSpriteWithoutTextureScripting(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture)
		{
			return Sprite.CreateSpriteWithoutTextureScripting_Injected(ref rect, ref pivot, pixelsToUnits, texture);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x0000C212 File Offset: 0x0000A412
		public static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape)
		{
			return Sprite.CreateSprite_Injected(texture, ref rect, ref pivot, pixelsPerUnit, extrude, meshType, ref border, generateFallbackPhysicsShape);
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x000586B4 File Offset: 0x000568B4
		public Texture2D GetSecondaryTexture(int index)
		{
			IntPtr intPtr = Sprite.GetSecondaryTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x0000C227 File Offset: 0x0000A427
		public float spriteAtlasTextureScale
		{
			get
			{
				return Sprite.get_spriteAtlasTextureScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x000586E4 File Offset: 0x000568E4
		public SpritePackingRotation packingRotation
		{
			get
			{
				return (SpritePackingRotation)this.GetPackingRotation();
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x000586FC File Offset: 0x000568FC
		public Vector2 textureRectOffset
		{
			get
			{
				bool flag = this.packed && this.packingMode != SpritePackingMode.Rectangle;
				Vector2 vector;
				if (flag)
				{
					vector = Vector2.zero;
				}
				else
				{
					vector = this.GetTextureRectOffset();
				}
				return vector;
			}
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x0000C239 File Offset: 0x0000A439
		public int GetPhysicsShapeCount()
		{
			return Sprite.GetPhysicsShapeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00058738 File Offset: 0x00056938
		public int GetPhysicsShapePointCount(int shapeIdx)
		{
			int physicsShapeCount = this.GetPhysicsShapeCount();
			bool flag = shapeIdx < 0 || shapeIdx >= physicsShapeCount;
			if (flag)
			{
				throw new IndexOutOfRangeException(String.Format("Index({0}) is out of bounds(0 - {1})", shapeIdx, physicsShapeCount - 1));
			}
			return this.Internal_GetPhysicsShapePointCount(shapeIdx);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x0000C24B File Offset: 0x0000A44B
		public int Internal_GetPhysicsShapePointCount(int shapeIdx)
		{
			return Sprite.Internal_GetPhysicsShapePointCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIdx);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00058788 File Offset: 0x00056988
		public int GetPhysicsShape(int shapeIdx, List<Vector2> physicsShape)
		{
			int physicsShapeCount = this.GetPhysicsShapeCount();
			bool flag = shapeIdx < 0 || shapeIdx >= physicsShapeCount;
			if (flag)
			{
				throw new IndexOutOfRangeException(String.Format("Index({0}) is out of bounds(0 - {1})", shapeIdx, physicsShapeCount - 1));
			}
			Sprite.GetPhysicsShapeImpl(this, shapeIdx, physicsShape);
			return physicsShape.Count;
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x0000C25E File Offset: 0x0000A45E
		public static void GetPhysicsShapeImpl(Sprite sprite, int shapeIdx, List<Vector2> physicsShape)
		{
			Sprite.GetPhysicsShapeImplDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), shapeIdx, IL2CPP.Il2CppObjectBaseToPtr(physicsShape));
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x000587E0 File Offset: 0x000569E0
		public void OverridePhysicsShape(IList<Il2CppStructArray<Vector2>> physicsShapes)
		{
			for (int i = 0; i < physicsShapes.Count; i++)
			{
				Il2CppStructArray<Vector2> il2CppStructArray = physicsShapes[i];
				bool flag = il2CppStructArray == null;
				if (flag)
				{
					throw new ArgumentNullException(String.Format("Physics Shape at {0} is null.", i));
				}
				bool flag2 = il2CppStructArray.Length < 3;
				if (flag2)
				{
					throw new ArgumentException(String.Format("Physics Shape at {0} has less than 3 vertices ({1}).", i, il2CppStructArray.Length));
				}
			}
			Sprite.OverridePhysicsShapeCount(this, physicsShapes.Count);
			for (int j = 0; j < physicsShapes.Count; j++)
			{
				Sprite.OverridePhysicsShape(this, physicsShapes[j], j);
			}
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0000C277 File Offset: 0x0000A477
		public static void OverridePhysicsShapeCount(Sprite sprite, int physicsShapeCount)
		{
			Sprite.OverridePhysicsShapeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), physicsShapeCount);
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x0000C28A File Offset: 0x0000A48A
		public static void OverridePhysicsShape(Sprite sprite, Il2CppStructArray<Vector2> physicsShape, int idx)
		{
			Sprite.OverridePhysicsShapeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), IL2CPP.Il2CppObjectBaseToPtr(physicsShape), idx);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0000C2A3 File Offset: 0x0000A4A3
		public void OverrideGeometry(Il2CppStructArray<Vector2> vertices, Il2CppStructArray<ushort> triangles)
		{
			Sprite.OverrideGeometryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(vertices), IL2CPP.Il2CppObjectBaseToPtr(triangles));
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00058898 File Offset: 0x00056A98
		public static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture)
		{
			return Sprite.CreateSpriteWithoutTextureScripting(rect, pivot, pixelsToUnits, texture);
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x000588B4 File Offset: 0x00056AB4
		public static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits)
		{
			return Sprite.CreateSpriteWithoutTextureScripting(rect, pivot, pixelsToUnits, null);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x0000C2C1 File Offset: 0x0000A4C1
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x000588D0 File Offset: 0x00056AD0
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border)
		{
			return Sprite.Create(texture, rect, pivot, pixelsPerUnit, extrude, meshType, border, false);
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x000588F4 File Offset: 0x00056AF4
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType)
		{
			return Sprite.Create(texture, rect, pivot, pixelsPerUnit, extrude, meshType, Vector4.zero);
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00058918 File Offset: 0x00056B18
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude)
		{
			return Sprite.Create(texture, rect, pivot, pixelsPerUnit, extrude, SpriteMeshType.Tight);
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00058938 File Offset: 0x00056B38
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit)
		{
			return Sprite.Create(texture, rect, pivot, pixelsPerUnit, 0U);
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00058954 File Offset: 0x00056B54
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot)
		{
			return Sprite.Create(texture, rect, pivot, 100f);
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0000C2CE File Offset: 0x0000A4CE
		public void GetTextureRectOffset_Injected(out Vector2 ret)
		{
			Sprite.GetTextureRectOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00058974 File Offset: 0x00056B74
		public static Sprite CreateSpriteWithoutTextureScripting_Injected(ref Rect rect, ref Vector2 pivot, float pixelsToUnits, Texture2D texture)
		{
			IntPtr intPtr = Sprite.CreateSpriteWithoutTextureScripting_InjectedDelegateField(ref rect, ref pivot, pixelsToUnits, IL2CPP.Il2CppObjectBaseToPtr(texture));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x000589A4 File Offset: 0x00056BA4
		public static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape)
		{
			IntPtr intPtr = Sprite.CreateSprite_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(texture), ref rect, ref pivot, pixelsPerUnit, extrude, meshType, ref border, generateFallbackPhysicsShape);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeMethodInfoPtr_GetPackingMode_Internal_Int32_0;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeMethodInfoPtr_GetPacked_Internal_Int32_0;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureRect_Internal_Rect_0;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeMethodInfoPtr_GetInnerUVs_Internal_Vector4_0;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeMethodInfoPtr_GetOuterUVs_Internal_Vector4_0;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Internal_Vector4_0;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeMethodInfoPtr_get_border_Public_get_Vector4_0;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Public_get_Texture2D_0;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeMethodInfoPtr_get_packed_Public_get_Boolean_0;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeMethodInfoPtr_get_packingMode_Public_get_SpritePackingMode_0;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeMethodInfoPtr_get_textureRect_Public_get_Rect_0;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_UInt16_0;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureRect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeMethodInfoPtr_GetInnerUVs_Injected_Private_Void_byref_Vector4_0;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeMethodInfoPtr_GetOuterUVs_Injected_Private_Void_byref_Vector4_0;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Injected_Private_Void_byref_Vector4_0;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeMethodInfoPtr_get_border_Injected_Private_Void_byref_Vector4_0;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040011D3 RID: 4563
		private static readonly Sprite.GetPackingRotationDelegate GetPackingRotationDelegateField;

		// Token: 0x040011D4 RID: 4564
		private static readonly Sprite.GetSecondaryTextureDelegate GetSecondaryTextureDelegateField;

		// Token: 0x040011D5 RID: 4565
		private static readonly Sprite.get_spriteAtlasTextureScaleDelegate get_spriteAtlasTextureScaleDelegateField;

		// Token: 0x040011D6 RID: 4566
		private static readonly Sprite.GetPhysicsShapeCountDelegate GetPhysicsShapeCountDelegateField;

		// Token: 0x040011D7 RID: 4567
		private static readonly Sprite.Internal_GetPhysicsShapePointCountDelegate Internal_GetPhysicsShapePointCountDelegateField;

		// Token: 0x040011D8 RID: 4568
		private static readonly Sprite.GetPhysicsShapeImplDelegate GetPhysicsShapeImplDelegateField;

		// Token: 0x040011D9 RID: 4569
		private static readonly Sprite.OverridePhysicsShapeCountDelegate OverridePhysicsShapeCountDelegateField;

		// Token: 0x040011DA RID: 4570
		private static readonly Sprite.OverridePhysicsShapeDelegate OverridePhysicsShapeDelegateField;

		// Token: 0x040011DB RID: 4571
		private static readonly Sprite.OverrideGeometryDelegate OverrideGeometryDelegateField;

		// Token: 0x040011DC RID: 4572
		private static readonly Sprite.GetTextureRectOffset_InjectedDelegate GetTextureRectOffset_InjectedDelegateField;

		// Token: 0x040011DD RID: 4573
		private static readonly Sprite.CreateSpriteWithoutTextureScripting_InjectedDelegate CreateSpriteWithoutTextureScripting_InjectedDelegateField;

		// Token: 0x040011DE RID: 4574
		private static readonly Sprite.CreateSprite_InjectedDelegate CreateSprite_InjectedDelegateField;

		// Token: 0x0200087D RID: 2173
		// (Invoke) Token: 0x06002F03 RID: 12035
		private delegate int GetPackingRotationDelegate(IntPtr @this);

		// Token: 0x0200087E RID: 2174
		// (Invoke) Token: 0x06002F05 RID: 12037
		private delegate IntPtr GetSecondaryTextureDelegate(IntPtr @this, int index);

		// Token: 0x0200087F RID: 2175
		// (Invoke) Token: 0x06002F07 RID: 12039
		private delegate float get_spriteAtlasTextureScaleDelegate(IntPtr @this);

		// Token: 0x02000880 RID: 2176
		// (Invoke) Token: 0x06002F09 RID: 12041
		private delegate int GetPhysicsShapeCountDelegate(IntPtr @this);

		// Token: 0x02000881 RID: 2177
		// (Invoke) Token: 0x06002F0B RID: 12043
		private delegate int Internal_GetPhysicsShapePointCountDelegate(IntPtr @this, int shapeIdx);

		// Token: 0x02000882 RID: 2178
		// (Invoke) Token: 0x06002F0D RID: 12045
		private delegate void GetPhysicsShapeImplDelegate(IntPtr sprite, int shapeIdx, IntPtr physicsShape);

		// Token: 0x02000883 RID: 2179
		// (Invoke) Token: 0x06002F0F RID: 12047
		private delegate void OverridePhysicsShapeCountDelegate(IntPtr sprite, int physicsShapeCount);

		// Token: 0x02000884 RID: 2180
		// (Invoke) Token: 0x06002F11 RID: 12049
		private delegate void OverridePhysicsShapeDelegate(IntPtr sprite, IntPtr physicsShape, int idx);

		// Token: 0x02000885 RID: 2181
		// (Invoke) Token: 0x06002F13 RID: 12051
		private delegate void OverrideGeometryDelegate(IntPtr @this, IntPtr vertices, IntPtr triangles);

		// Token: 0x02000886 RID: 2182
		// (Invoke) Token: 0x06002F15 RID: 12053
		private delegate void GetTextureRectOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000887 RID: 2183
		// (Invoke) Token: 0x06002F17 RID: 12055
		private delegate IntPtr CreateSpriteWithoutTextureScripting_InjectedDelegate(IntPtr rect, IntPtr pivot, float pixelsToUnits, IntPtr texture);

		// Token: 0x02000888 RID: 2184
		// (Invoke) Token: 0x06002F19 RID: 12057
		private delegate IntPtr CreateSprite_InjectedDelegate(IntPtr texture, IntPtr rect, IntPtr pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, IntPtr border, bool generateFallbackPhysicsShape);
	}
}
