using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200005C RID: 92
	public class Display : Object
	{
		// Token: 0x06000575 RID: 1397 RVA: 0x0002378C File Offset: 0x0002198C
		// Note: this type is marked as 'beforefieldinit'.
		static Display()
		{
			Il2CppClassPointerStore<Display>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Display");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Display>.NativeClassPtr);
			Display.NativeFieldInfoPtr_nativeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "nativeDisplay");
			Display.NativeFieldInfoPtr_displays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "displays");
			Display.NativeFieldInfoPtr__mainDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "_mainDisplay");
			Display.NativeFieldInfoPtr_m_ActiveEditorGameViewTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "m_ActiveEditorGameViewTarget");
			Display.NativeFieldInfoPtr_onDisplaysUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "onDisplaysUpdated");
			Display.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663757);
			Display.NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663759);
			Display.NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663760);
			Display.NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663761);
			Display.NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663762);
			Display.NativeMethodInfoPtr_get_colorBuffer_Public_get_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663763);
			Display.NativeMethodInfoPtr_SetRenderingResolution_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663764);
			Display.NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663765);
			Display.NativeMethodInfoPtr_get_main_Public_Static_get_Display_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663766);
			Display.NativeMethodInfoPtr_RecreateDisplayList_Private_Static_Void_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663767);
			Display.NativeMethodInfoPtr_FireDisplaysUpdated_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663768);
			Display.NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663769);
			Display.NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663770);
			Display.NativeMethodInfoPtr_GetRenderingBuffersImpl_Private_Static_Void_IntPtr_byref_RenderBuffer_byref_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663771);
			Display.NativeMethodInfoPtr_SetRenderingResolutionImpl_Private_Static_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663772);
			Display.NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663773);
			Display.ActivateDisplayImplDelegateField = IL2CPP.ResolveICall<Display.ActivateDisplayImplDelegate>("UnityEngine.Display::ActivateDisplayImpl");
			Display.SetParamsImplDelegateField = IL2CPP.ResolveICall<Display.SetParamsImplDelegate>("UnityEngine.Display::SetParamsImpl");
			Display.GetActiveImplDelegateField = IL2CPP.ResolveICall<Display.GetActiveImplDelegate>("UnityEngine.Display::GetActiveImpl");
			Display.RequiresBlitToBackbufferImplDelegateField = IL2CPP.ResolveICall<Display.RequiresBlitToBackbufferImplDelegate>("UnityEngine.Display::RequiresBlitToBackbufferImpl");
			Display.RequiresSrgbBlitToBackbufferImplDelegateField = IL2CPP.ResolveICall<Display.RequiresSrgbBlitToBackbufferImplDelegate>("UnityEngine.Display::RequiresSrgbBlitToBackbufferImpl");
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x000239AC File Offset: 0x00021BAC
		[CallerCount(0)]
		public unsafe Display()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Display>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x000239E8 File Offset: 0x00021BE8
		public unsafe int renderingWidth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 487767, RefRangeEnd = 487769, XrefRangeStart = 487762, XrefRangeEnd = 487767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x00023A24 File Offset: 0x00021C24
		public unsafe int renderingHeight
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 487774, RefRangeEnd = 487777, XrefRangeStart = 487769, XrefRangeEnd = 487774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00023A60 File Offset: 0x00021C60
		public unsafe int systemWidth
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 487782, RefRangeEnd = 487786, XrefRangeStart = 487777, XrefRangeEnd = 487782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x00023A9C File Offset: 0x00021C9C
		public unsafe int systemHeight
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 487791, RefRangeEnd = 487795, XrefRangeStart = 487786, XrefRangeEnd = 487791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00023AD8 File Offset: 0x00021CD8
		public unsafe RenderBuffer colorBuffer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487795, XrefRangeEnd = 487800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_colorBuffer_Public_get_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00023B14 File Offset: 0x00021D14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 487807, RefRangeEnd = 487809, XrefRangeStart = 487800, XrefRangeEnd = 487807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderingResolution(int w, int h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref w;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_SetRenderingResolution_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00023B60 File Offset: 0x00021D60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 487814, RefRangeEnd = 487816, XrefRangeStart = 487809, XrefRangeEnd = 487814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputMouseCoordinates;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00023BA0 File Offset: 0x00021DA0
		public unsafe static Display main
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 487820, RefRangeEnd = 487823, XrefRangeStart = 487816, XrefRangeEnd = 487820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_main_Public_Static_get_Display_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Display>(intPtr3) : null;
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00023BD4 File Offset: 0x00021DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487823, XrefRangeEnd = 487841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecreateDisplayList(Il2CppStructArray<IntPtr> nativeDisplay)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nativeDisplay);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RecreateDisplayList_Private_Static_Void_Il2CppStructArray_1_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00023C0C File Offset: 0x00021E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487841, XrefRangeEnd = 487848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireDisplaysUpdated()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_FireDisplaysUpdated_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00023C34 File Offset: 0x00021E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487848, XrefRangeEnd = 487852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeDisplay;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00023C84 File Offset: 0x00021E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487852, XrefRangeEnd = 487856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeDisplay;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00023CD4 File Offset: 0x00021ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487856, XrefRangeEnd = 487860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeDisplay;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_GetRenderingBuffersImpl_Private_Static_Void_IntPtr_byref_RenderBuffer_byref_RenderBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00023D24 File Offset: 0x00021F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487860, XrefRangeEnd = 487864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRenderingResolutionImpl(IntPtr nativeDisplay, int w, int h)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeDisplay;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_SetRenderingResolutionImpl_Private_Static_Void_IntPtr_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00023D74 File Offset: 0x00021F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487864, XrefRangeEnd = 487880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rx;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ry;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00004CB2 File Offset: 0x00002EB2
		public Display(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00023DDC File Offset: 0x00021FDC
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00004CBB File Offset: 0x00002EBB
		public unsafe IntPtr nativeDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Display.NativeFieldInfoPtr_nativeDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Display.NativeFieldInfoPtr_nativeDisplay)) = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00023E04 File Offset: 0x00022004
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00004CD6 File Offset: 0x00002ED6
		public unsafe static Il2CppReferenceArray<Display> displays
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr_displays, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Display>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr_displays, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00023E2C File Offset: 0x0002202C
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00004CE8 File Offset: 0x00002EE8
		public unsafe static Display _mainDisplay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr__mainDisplay, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Display>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr__mainDisplay, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00023E54 File Offset: 0x00022054
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00004CFA File Offset: 0x00002EFA
		public unsafe static int m_ActiveEditorGameViewTarget
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr_m_ActiveEditorGameViewTarget, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr_m_ActiveEditorGameViewTarget, (void*)(&value));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00023E70 File Offset: 0x00022070
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00004D08 File Offset: 0x00002F08
		public unsafe static Display.DisplaysUpdatedDelegate onDisplaysUpdated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr_onDisplaysUpdated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Display.DisplaysUpdatedDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr_onDisplaysUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00023E98 File Offset: 0x00022098
		public RenderBuffer depthBuffer
		{
			get
			{
				RenderBuffer renderBuffer;
				RenderBuffer renderBuffer2;
				Display.GetRenderingBuffersImpl(this.nativeDisplay, out renderBuffer, out renderBuffer2);
				return renderBuffer2;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00023EBC File Offset: 0x000220BC
		public bool active
		{
			get
			{
				return Display.GetActiveImpl(this.nativeDisplay);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00004D1A File Offset: 0x00002F1A
		public bool requiresBlitToBackbuffer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00023EDC File Offset: 0x000220DC
		public bool requiresSrgbBlitToBackbuffer
		{
			get
			{
				return Display.RequiresSrgbBlitToBackbufferImpl(this.nativeDisplay);
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00004D27 File Offset: 0x00002F27
		public void Activate()
		{
			Display.ActivateDisplayImpl(this.nativeDisplay, 0, 0, 60);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00004D3A File Offset: 0x00002F3A
		public void Activate(int width, int height, int refreshRate)
		{
			Display.ActivateDisplayImpl(this.nativeDisplay, width, height, refreshRate);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00004D4C File Offset: 0x00002F4C
		public void SetParams(int width, int height, int x, int y)
		{
			Display.SetParamsImpl(this.nativeDisplay, width, height, x, y);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00023EFC File Offset: 0x000220FC
		public static bool MultiDisplayLicense()
		{
			return true;
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00023F10 File Offset: 0x00022110
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00004D60 File Offset: 0x00002F60
		public static int activeEditorGameViewTarget
		{
			get
			{
				return Display.m_ActiveEditorGameViewTarget;
			}
			set
			{
				Display.m_ActiveEditorGameViewTarget = value;
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00004D69 File Offset: 0x00002F69
		public static void add_onDisplaysUpdated(Display.DisplaysUpdatedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00004D76 File Offset: 0x00002F76
		public static void remove_onDisplaysUpdated(Display.DisplaysUpdatedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00004D83 File Offset: 0x00002F83
		public static void ActivateDisplayImpl(IntPtr nativeDisplay, int width, int height, int refreshRate)
		{
			Display.ActivateDisplayImplDelegateField(nativeDisplay, width, height, refreshRate);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00004D93 File Offset: 0x00002F93
		public static void SetParamsImpl(IntPtr nativeDisplay, int width, int height, int x, int y)
		{
			Display.SetParamsImplDelegateField(nativeDisplay, width, height, x, y);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00004DA5 File Offset: 0x00002FA5
		public static bool GetActiveImpl(IntPtr nativeDisplay)
		{
			return Display.GetActiveImplDelegateField(nativeDisplay);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00004DB2 File Offset: 0x00002FB2
		public static bool RequiresBlitToBackbufferImpl(IntPtr nativeDisplay)
		{
			return Display.RequiresBlitToBackbufferImplDelegateField(nativeDisplay);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00004DBF File Offset: 0x00002FBF
		public static bool RequiresSrgbBlitToBackbufferImpl(IntPtr nativeDisplay)
		{
			return Display.RequiresSrgbBlitToBackbufferImplDelegateField(nativeDisplay);
		}

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr_nativeDisplay;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeFieldInfoPtr_displays;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeFieldInfoPtr__mainDisplay;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveEditorGameViewTarget;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeFieldInfoPtr_onDisplaysUpdated;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_get_colorBuffer_Public_get_RenderBuffer_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderingResolution_Public_Void_Int32_Int32_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_get_main_Public_Static_get_Display_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_RecreateDisplayList_Private_Static_Void_Il2CppStructArray_1_IntPtr_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_FireDisplaysUpdated_Private_Static_Void_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderingBuffersImpl_Private_Static_Void_IntPtr_byref_RenderBuffer_byref_RenderBuffer_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderingResolutionImpl_Private_Static_Void_IntPtr_Int32_Int32_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04000425 RID: 1061
		private static readonly Display.ActivateDisplayImplDelegate ActivateDisplayImplDelegateField;

		// Token: 0x04000426 RID: 1062
		private static readonly Display.SetParamsImplDelegate SetParamsImplDelegateField;

		// Token: 0x04000427 RID: 1063
		private static readonly Display.GetActiveImplDelegate GetActiveImplDelegateField;

		// Token: 0x04000428 RID: 1064
		private static readonly Display.RequiresBlitToBackbufferImplDelegate RequiresBlitToBackbufferImplDelegateField;

		// Token: 0x04000429 RID: 1065
		private static readonly Display.RequiresSrgbBlitToBackbufferImplDelegate RequiresSrgbBlitToBackbufferImplDelegateField;

		// Token: 0x02000432 RID: 1074
		public sealed class DisplaysUpdatedDelegate : MulticastDelegate
		{
			// Token: 0x06002692 RID: 9874 RVA: 0x0007B138 File Offset: 0x00079338
			// Note: this type is marked as 'beforefieldinit'.
			static DisplaysUpdatedDelegate()
			{
				Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Display>.NativeClassPtr, "DisplaysUpdatedDelegate");
				Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr, 100663775);
				Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr, 100663776);
				Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr, 100663777);
				Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr, 100663778);
			}

			// Token: 0x06002693 RID: 9875 RVA: 0x0007B1AC File Offset: 0x000793AC
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisplaysUpdatedDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002694 RID: 9876 RVA: 0x0007B208 File Offset: 0x00079408
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002695 RID: 9877 RVA: 0x0007B23C File Offset: 0x0007943C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002696 RID: 9878 RVA: 0x0007B2A0 File Offset: 0x000794A0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002697 RID: 9879 RVA: 0x000136F5 File Offset: 0x000118F5
			public DisplaysUpdatedDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002698 RID: 9880 RVA: 0x000136FE File Offset: 0x000118FE
			public static implicit operator Display.DisplaysUpdatedDelegate(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Display.DisplaysUpdatedDelegate>(A_0);
			}

			// Token: 0x06002699 RID: 9881 RVA: 0x00013706 File Offset: 0x00011906
			public static Display.DisplaysUpdatedDelegate operator +(Display.DisplaysUpdatedDelegate A_0, Display.DisplaysUpdatedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Display.DisplaysUpdatedDelegate>();
			}

			// Token: 0x0600269A RID: 9882 RVA: 0x00013714 File Offset: 0x00011914
			public static Display.DisplaysUpdatedDelegate operator -(Display.DisplaysUpdatedDelegate A_0, Display.DisplaysUpdatedDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Display.DisplaysUpdatedDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04001ECD RID: 7885
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001ECE RID: 7886
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04001ECF RID: 7887
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04001ED0 RID: 7888
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000433 RID: 1075
		// (Invoke) Token: 0x0600269C RID: 9884
		private delegate void ActivateDisplayImplDelegate(IntPtr nativeDisplay, int width, int height, int refreshRate);

		// Token: 0x02000434 RID: 1076
		// (Invoke) Token: 0x0600269E RID: 9886
		private delegate void SetParamsImplDelegate(IntPtr nativeDisplay, int width, int height, int x, int y);

		// Token: 0x02000435 RID: 1077
		// (Invoke) Token: 0x060026A0 RID: 9888
		private delegate bool GetActiveImplDelegate(IntPtr nativeDisplay);

		// Token: 0x02000436 RID: 1078
		// (Invoke) Token: 0x060026A2 RID: 9890
		private delegate bool RequiresBlitToBackbufferImplDelegate(IntPtr nativeDisplay);

		// Token: 0x02000437 RID: 1079
		// (Invoke) Token: 0x060026A4 RID: 9892
		private delegate bool RequiresSrgbBlitToBackbufferImplDelegate(IntPtr nativeDisplay);
	}
}
