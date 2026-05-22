using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200005E RID: 94
	public sealed class Screen : Object
	{
		// Token: 0x060005A2 RID: 1442 RVA: 0x00023F28 File Offset: 0x00022128
		// Note: this type is marked as 'beforefieldinit'.
		static Screen()
		{
			Il2CppClassPointerStore<Screen>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Screen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Screen>.NativeClassPtr);
			Screen.NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663779);
			Screen.NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663780);
			Screen.NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663781);
			Screen.NativeMethodInfoPtr_RequestOrientation_Private_Static_Void_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663782);
			Screen.NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663783);
			Screen.NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663784);
			Screen.NativeMethodInfoPtr_set_orientation_Public_Static_set_Void_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663785);
			Screen.NativeMethodInfoPtr_get_currentResolution_Public_Static_get_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663786);
			Screen.NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663787);
			Screen.NativeMethodInfoPtr_set_fullScreen_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663788);
			Screen.NativeMethodInfoPtr_get_fullScreenMode_Public_Static_get_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663789);
			Screen.NativeMethodInfoPtr_set_fullScreenMode_Public_Static_set_Void_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663790);
			Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663791);
			Screen.NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663792);
			Screen.NativeMethodInfoPtr_get_currentResolution_Injected_Private_Static_Void_byref_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663793);
			Screen.get_sleepTimeoutDelegateField = IL2CPP.ResolveICall<Screen.get_sleepTimeoutDelegate>("UnityEngine.Screen::get_sleepTimeout");
			Screen.set_sleepTimeoutDelegateField = IL2CPP.ResolveICall<Screen.set_sleepTimeoutDelegate>("UnityEngine.Screen::set_sleepTimeout");
			Screen.IsOrientationEnabledDelegateField = IL2CPP.ResolveICall<Screen.IsOrientationEnabledDelegate>("UnityEngine.Screen::IsOrientationEnabled");
			Screen.SetOrientationEnabledDelegateField = IL2CPP.ResolveICall<Screen.SetOrientationEnabledDelegate>("UnityEngine.Screen::SetOrientationEnabled");
			Screen.get_cutoutsDelegateField = IL2CPP.ResolveICall<Screen.get_cutoutsDelegate>("UnityEngine.Screen::get_cutouts");
			Screen.get_brightnessDelegateField = IL2CPP.ResolveICall<Screen.get_brightnessDelegate>("UnityEngine.Screen::get_brightness");
			Screen.set_brightnessDelegateField = IL2CPP.ResolveICall<Screen.set_brightnessDelegate>("UnityEngine.Screen::set_brightness");
			Screen.get_safeArea_InjectedDelegateField = IL2CPP.ResolveICall<Screen.get_safeArea_InjectedDelegate>("UnityEngine.Screen::get_safeArea_Injected");
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x000240FC File Offset: 0x000222FC
		public unsafe static int width
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 487884, RefRangeEnd = 487896, XrefRangeStart = 487880, XrefRangeEnd = 487884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0002412C File Offset: 0x0002232C
		public unsafe static int height
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 487900, RefRangeEnd = 487910, XrefRangeStart = 487896, XrefRangeEnd = 487900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0002415C File Offset: 0x0002235C
		public unsafe static float dpi
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 487914, RefRangeEnd = 487915, XrefRangeStart = 487910, XrefRangeEnd = 487914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0002418C File Offset: 0x0002238C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487915, XrefRangeEnd = 487919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequestOrientation(ScreenOrientation orient)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref orient;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_RequestOrientation_Private_Static_Void_ScreenOrientation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000241C0 File Offset: 0x000223C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487919, XrefRangeEnd = 487923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenOrientation GetScreenOrientation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x000241F0 File Offset: 0x000223F0
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x00024220 File Offset: 0x00022420
		public unsafe static ScreenOrientation orientation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 487933, RefRangeEnd = 487934, XrefRangeStart = 487923, XrefRangeEnd = 487933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_set_orientation_Public_Static_set_Void_ScreenOrientation_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x00024254 File Offset: 0x00022454
		public unsafe static Resolution currentResolution
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487934, XrefRangeEnd = 487936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_currentResolution_Public_Static_get_Resolution_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00024284 File Offset: 0x00022484
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x000242B4 File Offset: 0x000224B4
		public unsafe static bool fullScreen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 317889, RefRangeEnd = 317890, XrefRangeStart = 317889, XrefRangeEnd = 317890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487936, XrefRangeEnd = 487940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_set_fullScreen_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x000242E8 File Offset: 0x000224E8
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x00024318 File Offset: 0x00022518
		public unsafe static FullScreenMode fullScreenMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_fullScreenMode_Public_Static_get_FullScreenMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487940, XrefRangeEnd = 487944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_set_fullScreenMode_Public_Static_set_Void_FullScreenMode_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0002434C File Offset: 0x0002254C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 487948, RefRangeEnd = 487949, XrefRangeStart = 487944, XrefRangeEnd = 487948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullscreenMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preferredRefreshRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x000243A8 File Offset: 0x000225A8
		public unsafe static Il2CppStructArray<Resolution> resolutions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487949, XrefRangeEnd = 487953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Resolution>>(intPtr3) : null;
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000243DC File Offset: 0x000225DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487953, XrefRangeEnd = 487957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_currentResolution_Injected(out Resolution ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_currentResolution_Injected_Private_Static_Void_byref_Resolution_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00004DCC File Offset: 0x00002FCC
		public Screen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00004DD5 File Offset: 0x00002FD5
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x00004DE1 File Offset: 0x00002FE1
		public static int sleepTimeout
		{
			get
			{
				return Screen.get_sleepTimeoutDelegateField();
			}
			set
			{
				Screen.set_sleepTimeoutDelegateField(value);
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00004DEE File Offset: 0x00002FEE
		public static bool IsOrientationEnabled(EnabledOrientation orient)
		{
			return Screen.IsOrientationEnabledDelegateField(orient);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00004DFB File Offset: 0x00002FFB
		public static void SetOrientationEnabled(EnabledOrientation orient, bool enabled)
		{
			Screen.SetOrientationEnabledDelegateField(orient, enabled);
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00024410 File Offset: 0x00022610
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00004E09 File Offset: 0x00003009
		public static bool autorotateToPortrait
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToPortrait);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToPortrait, value);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00024428 File Offset: 0x00022628
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00004E14 File Offset: 0x00003014
		public static bool autorotateToPortraitUpsideDown
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToPortraitUpsideDown);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToPortraitUpsideDown, value);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x00024440 File Offset: 0x00022640
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00004E1F File Offset: 0x0000301F
		public static bool autorotateToLandscapeLeft
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeLeft);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeLeft, value);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x00024458 File Offset: 0x00022658
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x00004E2A File Offset: 0x0000302A
		public static bool autorotateToLandscapeRight
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeRight);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeRight, value);
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x00024470 File Offset: 0x00022670
		public static Rect safeArea
		{
			get
			{
				Rect rect;
				Screen.get_safeArea_Injected(out rect);
				return rect;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00024488 File Offset: 0x00022688
		public static Il2CppStructArray<Rect> cutouts
		{
			get
			{
				IntPtr intPtr = Screen.get_cutoutsDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00004E35 File Offset: 0x00003035
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode)
		{
			Screen.SetResolution(width, height, fullscreenMode, 0);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00004E42 File Offset: 0x00003042
		public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate)
		{
			Screen.SetResolution(width, height, fullscreen ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed, preferredRefreshRate);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00004E55 File Offset: 0x00003055
		public static void SetResolution(int width, int height, bool fullscreen)
		{
			Screen.SetResolution(width, height, fullscreen, 0);
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00004E62 File Offset: 0x00003062
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x00004E6E File Offset: 0x0000306E
		public static float brightness
		{
			get
			{
				return Screen.get_brightnessDelegateField();
			}
			set
			{
				Screen.set_brightnessDelegateField(value);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x000244B0 File Offset: 0x000226B0
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x000244CC File Offset: 0x000226CC
		public static bool lockCursor
		{
			get
			{
				return CursorLockMode.Locked == Cursor.lockState;
			}
			set
			{
				if (value)
				{
					Cursor.visible = false;
					Cursor.lockState = CursorLockMode.Locked;
				}
				else
				{
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
				}
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00004E7B File Offset: 0x0000307B
		public static void get_safeArea_Injected(out Rect ret)
		{
			Screen.get_safeArea_InjectedDelegateField(out ret);
		}

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_RequestOrientation_Private_Static_Void_ScreenOrientation_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_set_orientation_Public_Static_set_Void_ScreenOrientation_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_get_currentResolution_Public_Static_get_Resolution_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_set_fullScreen_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_get_fullScreenMode_Public_Static_get_FullScreenMode_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_set_fullScreenMode_Public_Static_set_Void_FullScreenMode_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_Int32_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_get_currentResolution_Injected_Private_Static_Void_byref_Resolution_0;

		// Token: 0x0400043E RID: 1086
		private static readonly Screen.get_sleepTimeoutDelegate get_sleepTimeoutDelegateField;

		// Token: 0x0400043F RID: 1087
		private static readonly Screen.set_sleepTimeoutDelegate set_sleepTimeoutDelegateField;

		// Token: 0x04000440 RID: 1088
		private static readonly Screen.IsOrientationEnabledDelegate IsOrientationEnabledDelegateField;

		// Token: 0x04000441 RID: 1089
		private static readonly Screen.SetOrientationEnabledDelegate SetOrientationEnabledDelegateField;

		// Token: 0x04000442 RID: 1090
		private static readonly Screen.get_cutoutsDelegate get_cutoutsDelegateField;

		// Token: 0x04000443 RID: 1091
		private static readonly Screen.get_brightnessDelegate get_brightnessDelegateField;

		// Token: 0x04000444 RID: 1092
		private static readonly Screen.set_brightnessDelegate set_brightnessDelegateField;

		// Token: 0x04000445 RID: 1093
		private static readonly Screen.get_safeArea_InjectedDelegate get_safeArea_InjectedDelegateField;

		// Token: 0x02000438 RID: 1080
		// (Invoke) Token: 0x060026A6 RID: 9894
		private delegate int get_sleepTimeoutDelegate();

		// Token: 0x02000439 RID: 1081
		// (Invoke) Token: 0x060026A8 RID: 9896
		private delegate void set_sleepTimeoutDelegate(int value);

		// Token: 0x0200043A RID: 1082
		// (Invoke) Token: 0x060026AA RID: 9898
		private delegate bool IsOrientationEnabledDelegate(EnabledOrientation orient);

		// Token: 0x0200043B RID: 1083
		// (Invoke) Token: 0x060026AC RID: 9900
		private delegate void SetOrientationEnabledDelegate(EnabledOrientation orient, bool enabled);

		// Token: 0x0200043C RID: 1084
		// (Invoke) Token: 0x060026AE RID: 9902
		private delegate IntPtr get_cutoutsDelegate();

		// Token: 0x0200043D RID: 1085
		// (Invoke) Token: 0x060026B0 RID: 9904
		private delegate float get_brightnessDelegate();

		// Token: 0x0200043E RID: 1086
		// (Invoke) Token: 0x060026B2 RID: 9906
		private delegate void set_brightnessDelegate(float value);

		// Token: 0x0200043F RID: 1087
		// (Invoke) Token: 0x060026B4 RID: 9908
		private delegate void get_safeArea_InjectedDelegate([Out] IntPtr ret);
	}
}
