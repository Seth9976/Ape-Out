using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public sealed class Canvas : Behaviour
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00003DBC File Offset: 0x00001FBC
		// Note: this type is marked as 'beforefieldinit'.
		static Canvas()
		{
			Il2CppClassPointerStore<Canvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "Canvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Canvas>.NativeClassPtr);
			Canvas.NativeFieldInfoPtr_preWillRenderCanvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "preWillRenderCanvases");
			Canvas.NativeFieldInfoPtr_willRenderCanvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "willRenderCanvases");
			Canvas.NativeMethodInfoPtr_add_preWillRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663355);
			Canvas.NativeMethodInfoPtr_remove_preWillRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663356);
			Canvas.NativeMethodInfoPtr_add_willRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663357);
			Canvas.NativeMethodInfoPtr_remove_willRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663358);
			Canvas.NativeMethodInfoPtr_get_renderMode_Public_get_RenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663359);
			Canvas.NativeMethodInfoPtr_set_renderMode_Public_set_Void_RenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663360);
			Canvas.NativeMethodInfoPtr_get_isRootCanvas_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663361);
			Canvas.NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663362);
			Canvas.NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663363);
			Canvas.NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663364);
			Canvas.NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663365);
			Canvas.NativeMethodInfoPtr_get_pixelPerfect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663366);
			Canvas.NativeMethodInfoPtr_get_renderOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663367);
			Canvas.NativeMethodInfoPtr_get_overrideSorting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663368);
			Canvas.NativeMethodInfoPtr_set_overrideSorting_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663369);
			Canvas.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663370);
			Canvas.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663371);
			Canvas.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663372);
			Canvas.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663373);
			Canvas.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663374);
			Canvas.NativeMethodInfoPtr_get_additionalShaderChannels_Public_get_AdditionalCanvasShaderChannels_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663375);
			Canvas.NativeMethodInfoPtr_set_additionalShaderChannels_Public_set_Void_AdditionalCanvasShaderChannels_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663376);
			Canvas.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663377);
			Canvas.NativeMethodInfoPtr_get_rootCanvas_Public_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663378);
			Canvas.NativeMethodInfoPtr_get_renderingDisplaySize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663379);
			Canvas.NativeMethodInfoPtr_get_worldCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663380);
			Canvas.NativeMethodInfoPtr_GetDefaultCanvasMaterial_Public_Static_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663381);
			Canvas.NativeMethodInfoPtr_GetETC1SupportedCanvasMaterial_Public_Static_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663382);
			Canvas.NativeMethodInfoPtr_ForceUpdateCanvases_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663383);
			Canvas.NativeMethodInfoPtr_SendPreWillRenderCanvases_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663384);
			Canvas.NativeMethodInfoPtr_SendWillRenderCanvases_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663385);
			Canvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663386);
			Canvas.NativeMethodInfoPtr_get_renderingDisplaySize_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663387);
			Canvas.get_overridePixelPerfectDelegateField = IL2CPP.ResolveICall<Canvas.get_overridePixelPerfectDelegate>("UnityEngine.Canvas::get_overridePixelPerfect");
			Canvas.set_overridePixelPerfectDelegateField = IL2CPP.ResolveICall<Canvas.set_overridePixelPerfectDelegate>("UnityEngine.Canvas::set_overridePixelPerfect");
			Canvas.set_pixelPerfectDelegateField = IL2CPP.ResolveICall<Canvas.set_pixelPerfectDelegate>("UnityEngine.Canvas::set_pixelPerfect");
			Canvas.get_planeDistanceDelegateField = IL2CPP.ResolveICall<Canvas.get_planeDistanceDelegate>("UnityEngine.Canvas::get_planeDistance");
			Canvas.set_planeDistanceDelegateField = IL2CPP.ResolveICall<Canvas.set_planeDistanceDelegate>("UnityEngine.Canvas::set_planeDistance");
			Canvas.set_targetDisplayDelegateField = IL2CPP.ResolveICall<Canvas.set_targetDisplayDelegate>("UnityEngine.Canvas::set_targetDisplay");
			Canvas.get_cachedSortingLayerValueDelegateField = IL2CPP.ResolveICall<Canvas.get_cachedSortingLayerValueDelegate>("UnityEngine.Canvas::get_cachedSortingLayerValue");
			Canvas.get_sortingLayerNameDelegateField = IL2CPP.ResolveICall<Canvas.get_sortingLayerNameDelegate>("UnityEngine.Canvas::get_sortingLayerName");
			Canvas.set_worldCameraDelegateField = IL2CPP.ResolveICall<Canvas.set_worldCameraDelegate>("UnityEngine.Canvas::set_worldCamera");
			Canvas.get_normalizedSortingGridSizeDelegateField = IL2CPP.ResolveICall<Canvas.get_normalizedSortingGridSizeDelegate>("UnityEngine.Canvas::get_normalizedSortingGridSize");
			Canvas.set_normalizedSortingGridSizeDelegateField = IL2CPP.ResolveICall<Canvas.set_normalizedSortingGridSizeDelegate>("UnityEngine.Canvas::set_normalizedSortingGridSize");
			Canvas.get_sortingGridNormalizedSizeDelegateField = IL2CPP.ResolveICall<Canvas.get_sortingGridNormalizedSizeDelegate>("UnityEngine.Canvas::get_sortingGridNormalizedSize");
			Canvas.set_sortingGridNormalizedSizeDelegateField = IL2CPP.ResolveICall<Canvas.set_sortingGridNormalizedSizeDelegate>("UnityEngine.Canvas::set_sortingGridNormalizedSize");
			Canvas.GetDefaultCanvasTextMaterialDelegateField = IL2CPP.ResolveICall<Canvas.GetDefaultCanvasTextMaterialDelegate>("UnityEngine.Canvas::GetDefaultCanvasTextMaterial");
			Canvas.UpdateCanvasRectTransformDelegateField = IL2CPP.ResolveICall<Canvas.UpdateCanvasRectTransformDelegate>("UnityEngine.Canvas::UpdateCanvasRectTransform");
			Canvas.get_pixelRect_InjectedDelegateField = IL2CPP.ResolveICall<Canvas.get_pixelRect_InjectedDelegate>("UnityEngine.Canvas::get_pixelRect_Injected");
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004198 File Offset: 0x00002398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533928, XrefRangeEnd = 533934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_preWillRenderCanvases(Canvas.WillRenderCanvases value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_add_preWillRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000041D0 File Offset: 0x000023D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533934, XrefRangeEnd = 533940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_preWillRenderCanvases(Canvas.WillRenderCanvases value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_remove_preWillRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004208 File Offset: 0x00002408
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 533946, RefRangeEnd = 533949, XrefRangeStart = 533940, XrefRangeEnd = 533946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_willRenderCanvases(Canvas.WillRenderCanvases value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_add_willRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004240 File Offset: 0x00002440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533949, XrefRangeEnd = 533955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_willRenderCanvases(Canvas.WillRenderCanvases value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_remove_willRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00004278 File Offset: 0x00002478
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000042B4 File Offset: 0x000024B4
		public unsafe RenderMode renderMode
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 533959, RefRangeEnd = 533963, XrefRangeStart = 533955, XrefRangeEnd = 533959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_renderMode_Public_get_RenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533963, XrefRangeEnd = 533967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_renderMode_Public_set_Void_RenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000042F4 File Offset: 0x000024F4
		public unsafe bool isRootCanvas
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533967, XrefRangeEnd = 533971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_isRootCanvas_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00004330 File Offset: 0x00002530
		// (set) Token: 0x06000065 RID: 101 RVA: 0x0000436C File Offset: 0x0000256C
		public unsafe float scaleFactor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 533975, RefRangeEnd = 533977, XrefRangeStart = 533971, XrefRangeEnd = 533975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533977, XrefRangeEnd = 533981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000043AC File Offset: 0x000025AC
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000043E8 File Offset: 0x000025E8
		public unsafe float referencePixelsPerUnit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533981, XrefRangeEnd = 533985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533985, XrefRangeEnd = 533989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00004428 File Offset: 0x00002628
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000021F6 File Offset: 0x000003F6
		public unsafe bool pixelPerfect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 533993, RefRangeEnd = 533995, XrefRangeStart = 533989, XrefRangeEnd = 533993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_pixelPerfect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Canvas.set_pixelPerfectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00004464 File Offset: 0x00002664
		public unsafe int renderOrder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533995, XrefRangeEnd = 533999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_renderOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000044A0 File Offset: 0x000026A0
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000044DC File Offset: 0x000026DC
		public unsafe bool overrideSorting
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 534003, RefRangeEnd = 534007, XrefRangeStart = 533999, XrefRangeEnd = 534003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_overrideSorting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 534011, RefRangeEnd = 534013, XrefRangeStart = 534007, XrefRangeEnd = 534011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_overrideSorting_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000451C File Offset: 0x0000271C
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00004558 File Offset: 0x00002758
		public unsafe int sortingOrder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 534017, RefRangeEnd = 534018, XrefRangeStart = 534013, XrefRangeEnd = 534017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 534022, RefRangeEnd = 534024, XrefRangeStart = 534018, XrefRangeEnd = 534022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00004598 File Offset: 0x00002798
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0000222E File Offset: 0x0000042E
		public unsafe int targetDisplay
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 534028, RefRangeEnd = 534029, XrefRangeStart = 534024, XrefRangeEnd = 534028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Canvas.set_targetDisplayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000045D4 File Offset: 0x000027D4
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00004610 File Offset: 0x00002810
		public unsafe int sortingLayerID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 534033, RefRangeEnd = 534036, XrefRangeStart = 534029, XrefRangeEnd = 534033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 534040, RefRangeEnd = 534042, XrefRangeStart = 534036, XrefRangeEnd = 534040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00004650 File Offset: 0x00002850
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000468C File Offset: 0x0000288C
		public unsafe AdditionalCanvasShaderChannels additionalShaderChannels
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534042, XrefRangeEnd = 534046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_additionalShaderChannels_Public_get_AdditionalCanvasShaderChannels_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534046, XrefRangeEnd = 534050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_additionalShaderChannels_Public_set_Void_AdditionalCanvasShaderChannels_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00004990 File Offset: 0x00002B90
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000046CC File Offset: 0x000028CC
		public unsafe string sortingLayerName
		{
			get
			{
				IntPtr intPtr = Canvas.get_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534050, XrefRangeEnd = 534054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00004710 File Offset: 0x00002910
		public unsafe Canvas rootCanvas
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 534058, RefRangeEnd = 534059, XrefRangeStart = 534054, XrefRangeEnd = 534058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_rootCanvas_Public_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00004750 File Offset: 0x00002950
		public unsafe Vector2 renderingDisplaySize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534059, XrefRangeEnd = 534061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_renderingDisplaySize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000478C File Offset: 0x0000298C
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002253 File Offset: 0x00000453
		public unsafe Camera worldCamera
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 534065, RefRangeEnd = 534068, XrefRangeStart = 534061, XrefRangeEnd = 534065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_worldCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
			set
			{
				Canvas.set_worldCameraDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000047CC File Offset: 0x000029CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534068, XrefRangeEnd = 534072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetDefaultCanvasMaterial()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_GetDefaultCanvasMaterial_Public_Static_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004800 File Offset: 0x00002A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534072, XrefRangeEnd = 534076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetETC1SupportedCanvasMaterial()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_GetETC1SupportedCanvasMaterial_Public_Static_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004834 File Offset: 0x00002A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534076, XrefRangeEnd = 534082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceUpdateCanvases()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_ForceUpdateCanvases_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000485C File Offset: 0x00002A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534082, XrefRangeEnd = 534085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendPreWillRenderCanvases()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_SendPreWillRenderCanvases_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004884 File Offset: 0x00002A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534085, XrefRangeEnd = 534088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendWillRenderCanvases()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_SendWillRenderCanvases_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000048AC File Offset: 0x00002AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canvas()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Canvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000048E8 File Offset: 0x00002AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534088, XrefRangeEnd = 534092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_renderingDisplaySize_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_renderingDisplaySize_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000021A4 File Offset: 0x000003A4
		public Canvas(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00004928 File Offset: 0x00002B28
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000021AD File Offset: 0x000003AD
		public unsafe static Canvas.WillRenderCanvases preWillRenderCanvases
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Canvas.NativeFieldInfoPtr_preWillRenderCanvases, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas.WillRenderCanvases>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Canvas.NativeFieldInfoPtr_preWillRenderCanvases, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00004950 File Offset: 0x00002B50
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000021BF File Offset: 0x000003BF
		public unsafe static Canvas.WillRenderCanvases willRenderCanvases
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Canvas.NativeFieldInfoPtr_willRenderCanvases, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas.WillRenderCanvases>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Canvas.NativeFieldInfoPtr_willRenderCanvases, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00004978 File Offset: 0x00002B78
		public Rect pixelRect
		{
			get
			{
				Rect rect;
				this.get_pixelRect_Injected(out rect);
				return rect;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000021D1 File Offset: 0x000003D1
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000021E3 File Offset: 0x000003E3
		public bool overridePixelPerfect
		{
			get
			{
				return Canvas.get_overridePixelPerfectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Canvas.set_overridePixelPerfectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002209 File Offset: 0x00000409
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000221B File Offset: 0x0000041B
		public float planeDistance
		{
			get
			{
				return Canvas.get_planeDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Canvas.set_planeDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002241 File Offset: 0x00000441
		public int cachedSortingLayerValue
		{
			get
			{
				return Canvas.get_cachedSortingLayerValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000226B File Offset: 0x0000046B
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0000227D File Offset: 0x0000047D
		public float normalizedSortingGridSize
		{
			get
			{
				return Canvas.get_normalizedSortingGridSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Canvas.set_normalizedSortingGridSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00002290 File Offset: 0x00000490
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000022A2 File Offset: 0x000004A2
		public int sortingGridNormalizedSize
		{
			get
			{
				return Canvas.get_sortingGridNormalizedSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Canvas.set_sortingGridNormalizedSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000049B4 File Offset: 0x00002BB4
		public static Material GetDefaultCanvasTextMaterial()
		{
			IntPtr intPtr = Canvas.GetDefaultCanvasTextMaterialDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000022B5 File Offset: 0x000004B5
		public void UpdateCanvasRectTransform(bool alignWithCamera)
		{
			Canvas.UpdateCanvasRectTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), alignWithCamera);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000022C8 File Offset: 0x000004C8
		public void get_pixelRect_Injected(out Rect ret)
		{
			Canvas.get_pixelRect_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_preWillRenderCanvases;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_willRenderCanvases;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_add_preWillRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_remove_preWillRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_add_willRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_remove_willRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_get_renderMode_Public_get_RenderMode_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_set_renderMode_Public_set_Void_RenderMode_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_get_isRootCanvas_Public_get_Boolean_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelPerfect_Public_get_Boolean_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_get_renderOrder_Public_get_Int32_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideSorting_Public_get_Boolean_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideSorting_Public_set_Void_Boolean_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_get_additionalShaderChannels_Public_get_AdditionalCanvasShaderChannels_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_set_additionalShaderChannels_Public_set_Void_AdditionalCanvasShaderChannels_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_get_rootCanvas_Public_get_Canvas_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingDisplaySize_Public_get_Vector2_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_worldCamera_Public_get_Camera_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultCanvasMaterial_Public_Static_Material_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_GetETC1SupportedCanvasMaterial_Public_Static_Material_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdateCanvases_Public_Static_Void_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_SendPreWillRenderCanvases_Private_Static_Void_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_SendWillRenderCanvases_Private_Static_Void_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingDisplaySize_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000073 RID: 115
		private static readonly Canvas.get_overridePixelPerfectDelegate get_overridePixelPerfectDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly Canvas.set_overridePixelPerfectDelegate set_overridePixelPerfectDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly Canvas.set_pixelPerfectDelegate set_pixelPerfectDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly Canvas.get_planeDistanceDelegate get_planeDistanceDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly Canvas.set_planeDistanceDelegate set_planeDistanceDelegateField;

		// Token: 0x04000078 RID: 120
		private static readonly Canvas.set_targetDisplayDelegate set_targetDisplayDelegateField;

		// Token: 0x04000079 RID: 121
		private static readonly Canvas.get_cachedSortingLayerValueDelegate get_cachedSortingLayerValueDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly Canvas.get_sortingLayerNameDelegate get_sortingLayerNameDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly Canvas.set_worldCameraDelegate set_worldCameraDelegateField;

		// Token: 0x0400007C RID: 124
		private static readonly Canvas.get_normalizedSortingGridSizeDelegate get_normalizedSortingGridSizeDelegateField;

		// Token: 0x0400007D RID: 125
		private static readonly Canvas.set_normalizedSortingGridSizeDelegate set_normalizedSortingGridSizeDelegateField;

		// Token: 0x0400007E RID: 126
		private static readonly Canvas.get_sortingGridNormalizedSizeDelegate get_sortingGridNormalizedSizeDelegateField;

		// Token: 0x0400007F RID: 127
		private static readonly Canvas.set_sortingGridNormalizedSizeDelegate set_sortingGridNormalizedSizeDelegateField;

		// Token: 0x04000080 RID: 128
		private static readonly Canvas.GetDefaultCanvasTextMaterialDelegate GetDefaultCanvasTextMaterialDelegateField;

		// Token: 0x04000081 RID: 129
		private static readonly Canvas.UpdateCanvasRectTransformDelegate UpdateCanvasRectTransformDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly Canvas.get_pixelRect_InjectedDelegate get_pixelRect_InjectedDelegateField;

		// Token: 0x02000013 RID: 19
		public sealed class WillRenderCanvases : MulticastDelegate
		{
			// Token: 0x060000AB RID: 171 RVA: 0x00004AF8 File Offset: 0x00002CF8
			// Note: this type is marked as 'beforefieldinit'.
			static WillRenderCanvases()
			{
				Il2CppClassPointerStore<Canvas.WillRenderCanvases>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "WillRenderCanvases");
				Canvas.WillRenderCanvases.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas.WillRenderCanvases>.NativeClassPtr, 100663388);
				Canvas.WillRenderCanvases.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas.WillRenderCanvases>.NativeClassPtr, 100663389);
				Canvas.WillRenderCanvases.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas.WillRenderCanvases>.NativeClassPtr, 100663390);
				Canvas.WillRenderCanvases.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas.WillRenderCanvases>.NativeClassPtr, 100663391);
			}

			// Token: 0x060000AC RID: 172 RVA: 0x00004B6C File Offset: 0x00002D6C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WillRenderCanvases(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Canvas.WillRenderCanvases>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.WillRenderCanvases.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000AD RID: 173 RVA: 0x00004BC8 File Offset: 0x00002DC8
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.WillRenderCanvases.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000AE RID: 174 RVA: 0x00004BFC File Offset: 0x00002DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.WillRenderCanvases.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060000AF RID: 175 RVA: 0x00004C60 File Offset: 0x00002E60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.WillRenderCanvases.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000B0 RID: 176 RVA: 0x000022E4 File Offset: 0x000004E4
			public WillRenderCanvases(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000B1 RID: 177 RVA: 0x000022ED File Offset: 0x000004ED
			public static implicit operator Canvas.WillRenderCanvases(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Canvas.WillRenderCanvases>(A_0);
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x000022F5 File Offset: 0x000004F5
			public static Canvas.WillRenderCanvases operator +(Canvas.WillRenderCanvases A_0, Canvas.WillRenderCanvases A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Canvas.WillRenderCanvases>();
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x00002303 File Offset: 0x00000503
			public static Canvas.WillRenderCanvases operator -(Canvas.WillRenderCanvases A_0, Canvas.WillRenderCanvases A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Canvas.WillRenderCanvases>();
				}
				return delegate2;
			}

			// Token: 0x04000086 RID: 134
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000087 RID: 135
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04000088 RID: 136
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04000089 RID: 137
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x060000B5 RID: 181
		private delegate bool get_overridePixelPerfectDelegate(IntPtr @this);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000B7 RID: 183
		private delegate void set_overridePixelPerfectDelegate(IntPtr @this, bool value);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x060000B9 RID: 185
		private delegate void set_pixelPerfectDelegate(IntPtr @this, bool value);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000BB RID: 187
		private delegate float get_planeDistanceDelegate(IntPtr @this);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000BD RID: 189
		private delegate void set_planeDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000BF RID: 191
		private delegate void set_targetDisplayDelegate(IntPtr @this, int value);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060000C1 RID: 193
		private delegate int get_cachedSortingLayerValueDelegate(IntPtr @this);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060000C3 RID: 195
		private delegate IntPtr get_sortingLayerNameDelegate(IntPtr @this);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060000C5 RID: 197
		private delegate void set_worldCameraDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060000C7 RID: 199
		private delegate float get_normalizedSortingGridSizeDelegate(IntPtr @this);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x060000C9 RID: 201
		private delegate void set_normalizedSortingGridSizeDelegate(IntPtr @this, float value);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060000CB RID: 203
		private delegate int get_sortingGridNormalizedSizeDelegate(IntPtr @this);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x060000CD RID: 205
		private delegate void set_sortingGridNormalizedSizeDelegate(IntPtr @this, int value);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x060000CF RID: 207
		private delegate IntPtr GetDefaultCanvasTextMaterialDelegate();

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x060000D1 RID: 209
		private delegate void UpdateCanvasRectTransformDelegate(IntPtr @this, bool alignWithCamera);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x060000D3 RID: 211
		private delegate void get_pixelRect_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
