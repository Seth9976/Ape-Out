using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.XR
{
	// Token: 0x02000002 RID: 2
	public static class XRSettings : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002230 File Offset: 0x00000430
		// Note: this type is marked as 'beforefieldinit'.
		static XRSettings()
		{
			Il2CppClassPointerStore<XRSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VRModule.dll", "UnityEngine.XR", "XRSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRSettings>.NativeClassPtr);
			XRSettings.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663297);
			XRSettings.NativeMethodInfoPtr_get_eyeTextureWidth_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663298);
			XRSettings.NativeMethodInfoPtr_get_eyeTextureHeight_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663299);
			XRSettings.NativeMethodInfoPtr_get_eyeTextureDesc_Public_Static_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663300);
			XRSettings.NativeMethodInfoPtr_get_renderViewportScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663301);
			XRSettings.NativeMethodInfoPtr_get_renderViewportScaleInternal_Internal_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663302);
			XRSettings.NativeMethodInfoPtr_get_stereoRenderingMode_Public_Static_get_StereoRenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663303);
			XRSettings.NativeMethodInfoPtr_get_eyeTextureDesc_Injected_Private_Static_Void_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663304);
			XRSettings.set_enabledDelegateField = IL2CPP.ResolveICall<XRSettings.set_enabledDelegate>("UnityEngine.XR.XRSettings::set_enabled");
			XRSettings.get_gameViewRenderModeDelegateField = IL2CPP.ResolveICall<XRSettings.get_gameViewRenderModeDelegate>("UnityEngine.XR.XRSettings::get_gameViewRenderMode");
			XRSettings.set_gameViewRenderModeDelegateField = IL2CPP.ResolveICall<XRSettings.set_gameViewRenderModeDelegate>("UnityEngine.XR.XRSettings::set_gameViewRenderMode");
			XRSettings.get_isDeviceActiveDelegateField = IL2CPP.ResolveICall<XRSettings.get_isDeviceActiveDelegate>("UnityEngine.XR.XRSettings::get_isDeviceActive");
			XRSettings.get_showDeviceViewDelegateField = IL2CPP.ResolveICall<XRSettings.get_showDeviceViewDelegate>("UnityEngine.XR.XRSettings::get_showDeviceView");
			XRSettings.set_showDeviceViewDelegateField = IL2CPP.ResolveICall<XRSettings.set_showDeviceViewDelegate>("UnityEngine.XR.XRSettings::set_showDeviceView");
			XRSettings.get_eyeTextureResolutionScaleDelegateField = IL2CPP.ResolveICall<XRSettings.get_eyeTextureResolutionScaleDelegate>("UnityEngine.XR.XRSettings::get_eyeTextureResolutionScale");
			XRSettings.set_eyeTextureResolutionScaleDelegateField = IL2CPP.ResolveICall<XRSettings.set_eyeTextureResolutionScaleDelegate>("UnityEngine.XR.XRSettings::set_eyeTextureResolutionScale");
			XRSettings.get_deviceEyeTextureDimensionDelegateField = IL2CPP.ResolveICall<XRSettings.get_deviceEyeTextureDimensionDelegate>("UnityEngine.XR.XRSettings::get_deviceEyeTextureDimension");
			XRSettings.set_renderViewportScaleInternalDelegateField = IL2CPP.ResolveICall<XRSettings.set_renderViewportScaleInternalDelegate>("UnityEngine.XR.XRSettings::set_renderViewportScaleInternal");
			XRSettings.get_occlusionMaskScaleDelegateField = IL2CPP.ResolveICall<XRSettings.get_occlusionMaskScaleDelegate>("UnityEngine.XR.XRSettings::get_occlusionMaskScale");
			XRSettings.set_occlusionMaskScaleDelegateField = IL2CPP.ResolveICall<XRSettings.set_occlusionMaskScaleDelegate>("UnityEngine.XR.XRSettings::set_occlusionMaskScale");
			XRSettings.get_useOcclusionMeshDelegateField = IL2CPP.ResolveICall<XRSettings.get_useOcclusionMeshDelegate>("UnityEngine.XR.XRSettings::get_useOcclusionMesh");
			XRSettings.set_useOcclusionMeshDelegateField = IL2CPP.ResolveICall<XRSettings.set_useOcclusionMeshDelegate>("UnityEngine.XR.XRSettings::set_useOcclusionMesh");
			XRSettings.get_loadedDeviceNameDelegateField = IL2CPP.ResolveICall<XRSettings.get_loadedDeviceNameDelegate>("UnityEngine.XR.XRSettings::get_loadedDeviceName");
			XRSettings.LoadDeviceByNameDelegateField = IL2CPP.ResolveICall<XRSettings.LoadDeviceByNameDelegate>("UnityEngine.XR.XRSettings::LoadDeviceByName");
			XRSettings.get_supportedDevicesDelegateField = IL2CPP.ResolveICall<XRSettings.get_supportedDevicesDelegate>("UnityEngine.XR.XRSettings::get_supportedDevices");
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002400 File Offset: 0x00000600
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static bool enabled
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 449545, RefRangeEnd = 449547, XrefRangeStart = 449545, XrefRangeEnd = 449547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				XRSettings.set_enabledDelegateField(value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002430 File Offset: 0x00000630
		public unsafe static int eyeTextureWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535021, XrefRangeEnd = 535025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_eyeTextureWidth_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002460 File Offset: 0x00000660
		public unsafe static int eyeTextureHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535025, XrefRangeEnd = 535029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_eyeTextureHeight_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002490 File Offset: 0x00000690
		public unsafe static RenderTextureDescriptor eyeTextureDesc
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535029, XrefRangeEnd = 535031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_eyeTextureDesc_Public_Static_get_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000024C0 File Offset: 0x000006C0
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002584 File Offset: 0x00000784
		public unsafe static float renderViewportScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535031, XrefRangeEnd = 535035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_renderViewportScale_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = value < 0f || value > 1f;
				if (flag)
				{
					throw new ArgumentOutOfRangeException("value", "Render viewport scale should be between 0 and 1.");
				}
				XRSettings.renderViewportScaleInternal = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000024F0 File Offset: 0x000006F0
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000020C9 File Offset: 0x000002C9
		public unsafe static float renderViewportScaleInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_renderViewportScaleInternal_Internal_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				XRSettings.set_renderViewportScaleInternalDelegateField(value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002520 File Offset: 0x00000720
		public unsafe static XRSettings.StereoRenderingMode stereoRenderingMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535035, XrefRangeEnd = 535039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_stereoRenderingMode_Public_Static_get_StereoRenderingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002550 File Offset: 0x00000750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535039, XrefRangeEnd = 535043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSettings.NativeMethodInfoPtr_get_eyeTextureDesc_Injected_Private_Static_Void_byref_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		public XRSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002072 File Offset: 0x00000272
		public static GameViewRenderMode gameViewRenderMode
		{
			get
			{
				return XRSettings.get_gameViewRenderModeDelegateField();
			}
			set
			{
				XRSettings.set_gameViewRenderModeDelegateField(value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000207F File Offset: 0x0000027F
		public static bool isDeviceActive
		{
			get
			{
				return XRSettings.get_isDeviceActiveDelegateField();
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000208B File Offset: 0x0000028B
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002097 File Offset: 0x00000297
		public static bool showDeviceView
		{
			get
			{
				return XRSettings.get_showDeviceViewDelegateField();
			}
			set
			{
				XRSettings.set_showDeviceViewDelegateField(value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000020A4 File Offset: 0x000002A4
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000020B0 File Offset: 0x000002B0
		public static float eyeTextureResolutionScale
		{
			get
			{
				return XRSettings.get_eyeTextureResolutionScaleDelegateField();
			}
			set
			{
				XRSettings.set_eyeTextureResolutionScaleDelegateField(value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000020BD File Offset: 0x000002BD
		public static TextureDimension deviceEyeTextureDimension
		{
			get
			{
				return XRSettings.get_deviceEyeTextureDimensionDelegateField();
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000020D6 File Offset: 0x000002D6
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000020E2 File Offset: 0x000002E2
		public static float occlusionMaskScale
		{
			get
			{
				return XRSettings.get_occlusionMaskScaleDelegateField();
			}
			set
			{
				XRSettings.set_occlusionMaskScaleDelegateField(value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000020EF File Offset: 0x000002EF
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000020FB File Offset: 0x000002FB
		public static bool useOcclusionMesh
		{
			get
			{
				return XRSettings.get_useOcclusionMeshDelegateField();
			}
			set
			{
				XRSettings.set_useOcclusionMeshDelegateField(value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000025C0 File Offset: 0x000007C0
		public static string loadedDeviceName
		{
			get
			{
				IntPtr intPtr = XRSettings.get_loadedDeviceNameDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002108 File Offset: 0x00000308
		public static void LoadDeviceByName(string deviceName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002115 File Offset: 0x00000315
		public static void LoadDeviceByName(Il2CppStringArray prioritizedDeviceNameList)
		{
			XRSettings.LoadDeviceByNameDelegateField(IL2CPP.Il2CppObjectBaseToPtr(prioritizedDeviceNameList));
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000025E0 File Offset: 0x000007E0
		public static Il2CppStringArray supportedDevices
		{
			get
			{
				IntPtr intPtr = XRSettings.get_supportedDevicesDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_get_eyeTextureWidth_Public_Static_get_Int32_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_get_eyeTextureHeight_Public_Static_get_Int32_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_get_eyeTextureDesc_Public_Static_get_RenderTextureDescriptor_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_renderViewportScale_Public_Static_get_Single_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_get_renderViewportScaleInternal_Internal_Static_get_Single_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoRenderingMode_Public_Static_get_StereoRenderingMode_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_eyeTextureDesc_Injected_Private_Static_Void_byref_RenderTextureDescriptor_0;

		// Token: 0x04000009 RID: 9
		private static readonly XRSettings.set_enabledDelegate set_enabledDelegateField;

		// Token: 0x0400000A RID: 10
		private static readonly XRSettings.get_gameViewRenderModeDelegate get_gameViewRenderModeDelegateField;

		// Token: 0x0400000B RID: 11
		private static readonly XRSettings.set_gameViewRenderModeDelegate set_gameViewRenderModeDelegateField;

		// Token: 0x0400000C RID: 12
		private static readonly XRSettings.get_isDeviceActiveDelegate get_isDeviceActiveDelegateField;

		// Token: 0x0400000D RID: 13
		private static readonly XRSettings.get_showDeviceViewDelegate get_showDeviceViewDelegateField;

		// Token: 0x0400000E RID: 14
		private static readonly XRSettings.set_showDeviceViewDelegate set_showDeviceViewDelegateField;

		// Token: 0x0400000F RID: 15
		private static readonly XRSettings.get_eyeTextureResolutionScaleDelegate get_eyeTextureResolutionScaleDelegateField;

		// Token: 0x04000010 RID: 16
		private static readonly XRSettings.set_eyeTextureResolutionScaleDelegate set_eyeTextureResolutionScaleDelegateField;

		// Token: 0x04000011 RID: 17
		private static readonly XRSettings.get_deviceEyeTextureDimensionDelegate get_deviceEyeTextureDimensionDelegateField;

		// Token: 0x04000012 RID: 18
		private static readonly XRSettings.set_renderViewportScaleInternalDelegate set_renderViewportScaleInternalDelegateField;

		// Token: 0x04000013 RID: 19
		private static readonly XRSettings.get_occlusionMaskScaleDelegate get_occlusionMaskScaleDelegateField;

		// Token: 0x04000014 RID: 20
		private static readonly XRSettings.set_occlusionMaskScaleDelegate set_occlusionMaskScaleDelegateField;

		// Token: 0x04000015 RID: 21
		private static readonly XRSettings.get_useOcclusionMeshDelegate get_useOcclusionMeshDelegateField;

		// Token: 0x04000016 RID: 22
		private static readonly XRSettings.set_useOcclusionMeshDelegate set_useOcclusionMeshDelegateField;

		// Token: 0x04000017 RID: 23
		private static readonly XRSettings.get_loadedDeviceNameDelegate get_loadedDeviceNameDelegateField;

		// Token: 0x04000018 RID: 24
		private static readonly XRSettings.LoadDeviceByNameDelegate LoadDeviceByNameDelegateField;

		// Token: 0x04000019 RID: 25
		private static readonly XRSettings.get_supportedDevicesDelegate get_supportedDevicesDelegateField;

		// Token: 0x0200000B RID: 11
		[OriginalName("UnityEngine.VRModule.dll", "", "StereoRenderingMode")]
		public enum StereoRenderingMode
		{
			// Token: 0x04000038 RID: 56
			MultiPass,
			// Token: 0x04000039 RID: 57
			SinglePass,
			// Token: 0x0400003A RID: 58
			SinglePassInstanced,
			// Token: 0x0400003B RID: 59
			SinglePassMultiview
		}

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000035 RID: 53
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000037 RID: 55
		private delegate GameViewRenderMode get_gameViewRenderModeDelegate();

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000039 RID: 57
		private delegate void set_gameViewRenderModeDelegate(GameViewRenderMode value);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x0600003B RID: 59
		private delegate bool get_isDeviceActiveDelegate();

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x0600003D RID: 61
		private delegate bool get_showDeviceViewDelegate();

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600003F RID: 63
		private delegate void set_showDeviceViewDelegate(bool value);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x06000041 RID: 65
		private delegate float get_eyeTextureResolutionScaleDelegate();

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000043 RID: 67
		private delegate void set_eyeTextureResolutionScaleDelegate(float value);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000045 RID: 69
		private delegate TextureDimension get_deviceEyeTextureDimensionDelegate();

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000047 RID: 71
		private delegate void set_renderViewportScaleInternalDelegate(float value);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000049 RID: 73
		private delegate float get_occlusionMaskScaleDelegate();

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x0600004B RID: 75
		private delegate void set_occlusionMaskScaleDelegate(float value);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x0600004D RID: 77
		private delegate bool get_useOcclusionMeshDelegate();

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x0600004F RID: 79
		private delegate void set_useOcclusionMeshDelegate(bool value);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x06000051 RID: 81
		private delegate IntPtr get_loadedDeviceNameDelegate();

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000053 RID: 83
		private delegate void LoadDeviceByNameDelegate(IntPtr prioritizedDeviceNameList);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000055 RID: 85
		private delegate IntPtr get_supportedDevicesDelegate();
	}
}
