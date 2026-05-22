using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200004D RID: 77
	public sealed class ReflectionProbe : Behaviour
	{
		// Token: 0x060003B9 RID: 953 RVA: 0x0001E848 File Offset: 0x0001CA48
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionProbe()
		{
			Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ReflectionProbe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr);
			ReflectionProbe.NativeFieldInfoPtr_reflectionProbeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, "reflectionProbeChanged");
			ReflectionProbe.NativeFieldInfoPtr_defaultReflectionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, "defaultReflectionSet");
			ReflectionProbe.NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100663592);
			ReflectionProbe.NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100663593);
			ReflectionProbe.get_typeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_typeDelegate>("UnityEngine.ReflectionProbe::get_type");
			ReflectionProbe.set_typeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_typeDelegate>("UnityEngine.ReflectionProbe::set_type");
			ReflectionProbe.get_nearClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_nearClipPlaneDelegate>("UnityEngine.ReflectionProbe::get_nearClipPlane");
			ReflectionProbe.set_nearClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_nearClipPlaneDelegate>("UnityEngine.ReflectionProbe::set_nearClipPlane");
			ReflectionProbe.get_farClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_farClipPlaneDelegate>("UnityEngine.ReflectionProbe::get_farClipPlane");
			ReflectionProbe.set_farClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_farClipPlaneDelegate>("UnityEngine.ReflectionProbe::set_farClipPlane");
			ReflectionProbe.get_intensityDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_intensityDelegate>("UnityEngine.ReflectionProbe::get_intensity");
			ReflectionProbe.set_intensityDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_intensityDelegate>("UnityEngine.ReflectionProbe::set_intensity");
			ReflectionProbe.get_hdrDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_hdrDelegate>("UnityEngine.ReflectionProbe::get_hdr");
			ReflectionProbe.set_hdrDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_hdrDelegate>("UnityEngine.ReflectionProbe::set_hdr");
			ReflectionProbe.get_renderDynamicObjectsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_renderDynamicObjectsDelegate>("UnityEngine.ReflectionProbe::get_renderDynamicObjects");
			ReflectionProbe.set_renderDynamicObjectsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_renderDynamicObjectsDelegate>("UnityEngine.ReflectionProbe::set_renderDynamicObjects");
			ReflectionProbe.get_shadowDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_shadowDistanceDelegate>("UnityEngine.ReflectionProbe::get_shadowDistance");
			ReflectionProbe.set_shadowDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_shadowDistanceDelegate>("UnityEngine.ReflectionProbe::set_shadowDistance");
			ReflectionProbe.get_resolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_resolutionDelegate>("UnityEngine.ReflectionProbe::get_resolution");
			ReflectionProbe.set_resolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_resolutionDelegate>("UnityEngine.ReflectionProbe::set_resolution");
			ReflectionProbe.get_cullingMaskDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_cullingMaskDelegate>("UnityEngine.ReflectionProbe::get_cullingMask");
			ReflectionProbe.set_cullingMaskDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_cullingMaskDelegate>("UnityEngine.ReflectionProbe::set_cullingMask");
			ReflectionProbe.get_clearFlagsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_clearFlagsDelegate>("UnityEngine.ReflectionProbe::get_clearFlags");
			ReflectionProbe.set_clearFlagsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_clearFlagsDelegate>("UnityEngine.ReflectionProbe::set_clearFlags");
			ReflectionProbe.get_blendDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_blendDistanceDelegate>("UnityEngine.ReflectionProbe::get_blendDistance");
			ReflectionProbe.set_blendDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_blendDistanceDelegate>("UnityEngine.ReflectionProbe::set_blendDistance");
			ReflectionProbe.get_boxProjectionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_boxProjectionDelegate>("UnityEngine.ReflectionProbe::get_boxProjection");
			ReflectionProbe.set_boxProjectionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_boxProjectionDelegate>("UnityEngine.ReflectionProbe::set_boxProjection");
			ReflectionProbe.get_modeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_modeDelegate>("UnityEngine.ReflectionProbe::get_mode");
			ReflectionProbe.set_modeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_modeDelegate>("UnityEngine.ReflectionProbe::set_mode");
			ReflectionProbe.get_importanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_importanceDelegate>("UnityEngine.ReflectionProbe::get_importance");
			ReflectionProbe.set_importanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_importanceDelegate>("UnityEngine.ReflectionProbe::set_importance");
			ReflectionProbe.get_refreshModeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_refreshModeDelegate>("UnityEngine.ReflectionProbe::get_refreshMode");
			ReflectionProbe.set_refreshModeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_refreshModeDelegate>("UnityEngine.ReflectionProbe::set_refreshMode");
			ReflectionProbe.get_timeSlicingModeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_timeSlicingModeDelegate>("UnityEngine.ReflectionProbe::get_timeSlicingMode");
			ReflectionProbe.set_timeSlicingModeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_timeSlicingModeDelegate>("UnityEngine.ReflectionProbe::set_timeSlicingMode");
			ReflectionProbe.get_bakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_bakedTextureDelegate>("UnityEngine.ReflectionProbe::get_bakedTexture");
			ReflectionProbe.set_bakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_bakedTextureDelegate>("UnityEngine.ReflectionProbe::set_bakedTexture");
			ReflectionProbe.get_customBakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_customBakedTextureDelegate>("UnityEngine.ReflectionProbe::get_customBakedTexture");
			ReflectionProbe.set_customBakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_customBakedTextureDelegate>("UnityEngine.ReflectionProbe::set_customBakedTexture");
			ReflectionProbe.get_realtimeTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_realtimeTextureDelegate>("UnityEngine.ReflectionProbe::get_realtimeTexture");
			ReflectionProbe.set_realtimeTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_realtimeTextureDelegate>("UnityEngine.ReflectionProbe::set_realtimeTexture");
			ReflectionProbe.get_textureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_textureDelegate>("UnityEngine.ReflectionProbe::get_texture");
			ReflectionProbe.ResetDelegateField = IL2CPP.ResolveICall<ReflectionProbe.ResetDelegate>("UnityEngine.ReflectionProbe::Reset");
			ReflectionProbe.IsFinishedRenderingDelegateField = IL2CPP.ResolveICall<ReflectionProbe.IsFinishedRenderingDelegate>("UnityEngine.ReflectionProbe::IsFinishedRendering");
			ReflectionProbe.ScheduleRenderDelegateField = IL2CPP.ResolveICall<ReflectionProbe.ScheduleRenderDelegate>("UnityEngine.ReflectionProbe::ScheduleRender");
			ReflectionProbe.BlendCubemapDelegateField = IL2CPP.ResolveICall<ReflectionProbe.BlendCubemapDelegate>("UnityEngine.ReflectionProbe::BlendCubemap");
			ReflectionProbe.get_minBakedCubemapResolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_minBakedCubemapResolutionDelegate>("UnityEngine.ReflectionProbe::get_minBakedCubemapResolution");
			ReflectionProbe.get_maxBakedCubemapResolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_maxBakedCubemapResolutionDelegate>("UnityEngine.ReflectionProbe::get_maxBakedCubemapResolution");
			ReflectionProbe.get_defaultTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_defaultTextureDelegate>("UnityEngine.ReflectionProbe::get_defaultTexture");
			ReflectionProbe.get_size_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_size_InjectedDelegate>("UnityEngine.ReflectionProbe::get_size_Injected");
			ReflectionProbe.set_size_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_size_InjectedDelegate>("UnityEngine.ReflectionProbe::set_size_Injected");
			ReflectionProbe.get_center_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_center_InjectedDelegate>("UnityEngine.ReflectionProbe::get_center_Injected");
			ReflectionProbe.set_center_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_center_InjectedDelegate>("UnityEngine.ReflectionProbe::set_center_Injected");
			ReflectionProbe.get_bounds_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_bounds_InjectedDelegate>("UnityEngine.ReflectionProbe::get_bounds_Injected");
			ReflectionProbe.get_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_backgroundColor_InjectedDelegate>("UnityEngine.ReflectionProbe::get_backgroundColor_Injected");
			ReflectionProbe.set_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_backgroundColor_InjectedDelegate>("UnityEngine.ReflectionProbe::set_backgroundColor_Injected");
			ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegate>("UnityEngine.ReflectionProbe::get_textureHDRDecodeValues_Injected");
			ReflectionProbe.get_defaultTextureHDRDecodeValues_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_defaultTextureHDRDecodeValues_InjectedDelegate>("UnityEngine.ReflectionProbe::get_defaultTextureHDRDecodeValues_Injected");
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0001EC04 File Offset: 0x0001CE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486730, XrefRangeEnd = 486735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(probe);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref probeEvent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0001EC48 File Offset: 0x0001CE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486735, XrefRangeEnd = 486740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallSetDefaultReflection(Cubemap defaultReflectionCubemap)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaultReflectionCubemap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Cubemap_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000405F File Offset: 0x0000225F
		public ReflectionProbe(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0001EC80 File Offset: 0x0001CE80
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00004068 File Offset: 0x00002268
		public unsafe static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbe.NativeFieldInfoPtr_reflectionProbeChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbe.NativeFieldInfoPtr_reflectionProbeChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0001ECA8 File Offset: 0x0001CEA8
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x0000407A File Offset: 0x0000227A
		public unsafe static Action<Cubemap> defaultReflectionSet
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbe.NativeFieldInfoPtr_defaultReflectionSet, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Cubemap>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbe.NativeFieldInfoPtr_defaultReflectionSet, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000408C File Offset: 0x0000228C
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x0000409E File Offset: 0x0000229E
		public UnityEngine.Rendering.ReflectionProbeType type
		{
			get
			{
				return ReflectionProbe.get_typeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_typeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0001ECD0 File Offset: 0x0001CED0
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x000040B1 File Offset: 0x000022B1
		public Vector3 size
		{
			get
			{
				Vector3 vector;
				this.get_size_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0001ECE8 File Offset: 0x0001CEE8
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x000040BB File Offset: 0x000022BB
		public Vector3 center
		{
			get
			{
				Vector3 vector;
				this.get_center_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x000040C5 File Offset: 0x000022C5
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x000040D7 File Offset: 0x000022D7
		public float nearClipPlane
		{
			get
			{
				return ReflectionProbe.get_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x000040EA File Offset: 0x000022EA
		// (set) Token: 0x060003CA RID: 970 RVA: 0x000040FC File Offset: 0x000022FC
		public float farClipPlane
		{
			get
			{
				return ReflectionProbe.get_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0000410F File Offset: 0x0000230F
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00004121 File Offset: 0x00002321
		public float intensity
		{
			get
			{
				return ReflectionProbe.get_intensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_intensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0001ED00 File Offset: 0x0001CF00
		public Bounds bounds
		{
			get
			{
				Bounds bounds;
				this.get_bounds_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00004134 File Offset: 0x00002334
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00004146 File Offset: 0x00002346
		public bool hdr
		{
			get
			{
				return ReflectionProbe.get_hdrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_hdrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00004159 File Offset: 0x00002359
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x0000416B File Offset: 0x0000236B
		public bool renderDynamicObjects
		{
			get
			{
				return ReflectionProbe.get_renderDynamicObjectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_renderDynamicObjectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0000417E File Offset: 0x0000237E
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00004190 File Offset: 0x00002390
		public float shadowDistance
		{
			get
			{
				return ReflectionProbe.get_shadowDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_shadowDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x000041A3 File Offset: 0x000023A3
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x000041B5 File Offset: 0x000023B5
		public int resolution
		{
			get
			{
				return ReflectionProbe.get_resolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_resolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x000041C8 File Offset: 0x000023C8
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x000041DA File Offset: 0x000023DA
		public int cullingMask
		{
			get
			{
				return ReflectionProbe.get_cullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_cullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x000041ED File Offset: 0x000023ED
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x000041FF File Offset: 0x000023FF
		public UnityEngine.Rendering.ReflectionProbeClearFlags clearFlags
		{
			get
			{
				return ReflectionProbe.get_clearFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_clearFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0001ED18 File Offset: 0x0001CF18
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00004212 File Offset: 0x00002412
		public Color backgroundColor
		{
			get
			{
				Color color;
				this.get_backgroundColor_Injected(out color);
				return color;
			}
			set
			{
				this.set_backgroundColor_Injected(ref value);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0000421C File Offset: 0x0000241C
		// (set) Token: 0x060003DD RID: 989 RVA: 0x0000422E File Offset: 0x0000242E
		public float blendDistance
		{
			get
			{
				return ReflectionProbe.get_blendDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_blendDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00004241 File Offset: 0x00002441
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00004253 File Offset: 0x00002453
		public bool boxProjection
		{
			get
			{
				return ReflectionProbe.get_boxProjectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_boxProjectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00004266 File Offset: 0x00002466
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x00004278 File Offset: 0x00002478
		public UnityEngine.Rendering.ReflectionProbeMode mode
		{
			get
			{
				return ReflectionProbe.get_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0000428B File Offset: 0x0000248B
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x0000429D File Offset: 0x0000249D
		public int importance
		{
			get
			{
				return ReflectionProbe.get_importanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_importanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x000042B0 File Offset: 0x000024B0
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x000042C2 File Offset: 0x000024C2
		public UnityEngine.Rendering.ReflectionProbeRefreshMode refreshMode
		{
			get
			{
				return ReflectionProbe.get_refreshModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_refreshModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x000042D5 File Offset: 0x000024D5
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x000042E7 File Offset: 0x000024E7
		public UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode
		{
			get
			{
				return ReflectionProbe.get_timeSlicingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_timeSlicingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0001ED30 File Offset: 0x0001CF30
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x000042FA File Offset: 0x000024FA
		public Texture bakedTexture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_bakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				ReflectionProbe.set_bakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0001ED5C File Offset: 0x0001CF5C
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00004312 File Offset: 0x00002512
		public Texture customBakedTexture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_customBakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				ReflectionProbe.set_customBakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0001ED88 File Offset: 0x0001CF88
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0000432A File Offset: 0x0000252A
		public RenderTexture realtimeTexture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_realtimeTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				ReflectionProbe.set_realtimeTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0001EDB4 File Offset: 0x0001CFB4
		public Texture texture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_textureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
		public Vector4 textureHDRDecodeValues
		{
			get
			{
				Vector4 vector;
				this.get_textureHDRDecodeValues_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00004342 File Offset: 0x00002542
		public void Reset()
		{
			ReflectionProbe.ResetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0001EDF8 File Offset: 0x0001CFF8
		public int RenderProbe()
		{
			return this.RenderProbe(null);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0001EE14 File Offset: 0x0001D014
		public int RenderProbe(RenderTexture targetTexture)
		{
			return this.ScheduleRender(this.timeSlicingMode, targetTexture);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00004354 File Offset: 0x00002554
		public bool IsFinishedRendering(int renderId)
		{
			return ReflectionProbe.IsFinishedRenderingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), renderId);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00004367 File Offset: 0x00002567
		public int ScheduleRender(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture)
		{
			return ReflectionProbe.ScheduleRenderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeSlicingMode, IL2CPP.Il2CppObjectBaseToPtr(targetTexture));
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00004380 File Offset: 0x00002580
		public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target)
		{
			return ReflectionProbe.BlendCubemapDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), blend, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0000439F File Offset: 0x0000259F
		public static int minBakedCubemapResolution
		{
			get
			{
				return ReflectionProbe.get_minBakedCubemapResolutionDelegateField();
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x000043AB File Offset: 0x000025AB
		public static int maxBakedCubemapResolution
		{
			get
			{
				return ReflectionProbe.get_maxBakedCubemapResolutionDelegateField();
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0001EE34 File Offset: 0x0001D034
		public static Vector4 defaultTextureHDRDecodeValues
		{
			get
			{
				Vector4 vector;
				ReflectionProbe.get_defaultTextureHDRDecodeValues_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0001EE4C File Offset: 0x0001D04C
		public static Texture defaultTexture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_defaultTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000043B7 File Offset: 0x000025B7
		public static void add_defaultReflectionSet(Action<Cubemap> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000043C4 File Offset: 0x000025C4
		public static void remove_defaultReflectionSet(Action<Cubemap> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000043D1 File Offset: 0x000025D1
		public void get_size_Injected(out Vector3 ret)
		{
			ReflectionProbe.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000043E4 File Offset: 0x000025E4
		public void set_size_Injected(ref Vector3 value)
		{
			ReflectionProbe.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000043F7 File Offset: 0x000025F7
		public void get_center_Injected(out Vector3 ret)
		{
			ReflectionProbe.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000440A File Offset: 0x0000260A
		public void set_center_Injected(ref Vector3 value)
		{
			ReflectionProbe.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000441D File Offset: 0x0000261D
		public void get_bounds_Injected(out Bounds ret)
		{
			ReflectionProbe.get_bounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00004430 File Offset: 0x00002630
		public void get_backgroundColor_Injected(out Color ret)
		{
			ReflectionProbe.get_backgroundColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00004443 File Offset: 0x00002643
		public void set_backgroundColor_Injected(ref Color value)
		{
			ReflectionProbe.set_backgroundColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00004456 File Offset: 0x00002656
		public void get_textureHDRDecodeValues_Injected(out Vector4 ret)
		{
			ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00004469 File Offset: 0x00002669
		public static void get_defaultTextureHDRDecodeValues_Injected(out Vector4 ret)
		{
			ReflectionProbe.get_defaultTextureHDRDecodeValues_InjectedDelegateField(out ret);
		}

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeFieldInfoPtr_reflectionProbeChanged;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeFieldInfoPtr_defaultReflectionSet;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Cubemap_0;

		// Token: 0x040002F8 RID: 760
		private static readonly ReflectionProbe.get_typeDelegate get_typeDelegateField;

		// Token: 0x040002F9 RID: 761
		private static readonly ReflectionProbe.set_typeDelegate set_typeDelegateField;

		// Token: 0x040002FA RID: 762
		private static readonly ReflectionProbe.get_nearClipPlaneDelegate get_nearClipPlaneDelegateField;

		// Token: 0x040002FB RID: 763
		private static readonly ReflectionProbe.set_nearClipPlaneDelegate set_nearClipPlaneDelegateField;

		// Token: 0x040002FC RID: 764
		private static readonly ReflectionProbe.get_farClipPlaneDelegate get_farClipPlaneDelegateField;

		// Token: 0x040002FD RID: 765
		private static readonly ReflectionProbe.set_farClipPlaneDelegate set_farClipPlaneDelegateField;

		// Token: 0x040002FE RID: 766
		private static readonly ReflectionProbe.get_intensityDelegate get_intensityDelegateField;

		// Token: 0x040002FF RID: 767
		private static readonly ReflectionProbe.set_intensityDelegate set_intensityDelegateField;

		// Token: 0x04000300 RID: 768
		private static readonly ReflectionProbe.get_hdrDelegate get_hdrDelegateField;

		// Token: 0x04000301 RID: 769
		private static readonly ReflectionProbe.set_hdrDelegate set_hdrDelegateField;

		// Token: 0x04000302 RID: 770
		private static readonly ReflectionProbe.get_renderDynamicObjectsDelegate get_renderDynamicObjectsDelegateField;

		// Token: 0x04000303 RID: 771
		private static readonly ReflectionProbe.set_renderDynamicObjectsDelegate set_renderDynamicObjectsDelegateField;

		// Token: 0x04000304 RID: 772
		private static readonly ReflectionProbe.get_shadowDistanceDelegate get_shadowDistanceDelegateField;

		// Token: 0x04000305 RID: 773
		private static readonly ReflectionProbe.set_shadowDistanceDelegate set_shadowDistanceDelegateField;

		// Token: 0x04000306 RID: 774
		private static readonly ReflectionProbe.get_resolutionDelegate get_resolutionDelegateField;

		// Token: 0x04000307 RID: 775
		private static readonly ReflectionProbe.set_resolutionDelegate set_resolutionDelegateField;

		// Token: 0x04000308 RID: 776
		private static readonly ReflectionProbe.get_cullingMaskDelegate get_cullingMaskDelegateField;

		// Token: 0x04000309 RID: 777
		private static readonly ReflectionProbe.set_cullingMaskDelegate set_cullingMaskDelegateField;

		// Token: 0x0400030A RID: 778
		private static readonly ReflectionProbe.get_clearFlagsDelegate get_clearFlagsDelegateField;

		// Token: 0x0400030B RID: 779
		private static readonly ReflectionProbe.set_clearFlagsDelegate set_clearFlagsDelegateField;

		// Token: 0x0400030C RID: 780
		private static readonly ReflectionProbe.get_blendDistanceDelegate get_blendDistanceDelegateField;

		// Token: 0x0400030D RID: 781
		private static readonly ReflectionProbe.set_blendDistanceDelegate set_blendDistanceDelegateField;

		// Token: 0x0400030E RID: 782
		private static readonly ReflectionProbe.get_boxProjectionDelegate get_boxProjectionDelegateField;

		// Token: 0x0400030F RID: 783
		private static readonly ReflectionProbe.set_boxProjectionDelegate set_boxProjectionDelegateField;

		// Token: 0x04000310 RID: 784
		private static readonly ReflectionProbe.get_modeDelegate get_modeDelegateField;

		// Token: 0x04000311 RID: 785
		private static readonly ReflectionProbe.set_modeDelegate set_modeDelegateField;

		// Token: 0x04000312 RID: 786
		private static readonly ReflectionProbe.get_importanceDelegate get_importanceDelegateField;

		// Token: 0x04000313 RID: 787
		private static readonly ReflectionProbe.set_importanceDelegate set_importanceDelegateField;

		// Token: 0x04000314 RID: 788
		private static readonly ReflectionProbe.get_refreshModeDelegate get_refreshModeDelegateField;

		// Token: 0x04000315 RID: 789
		private static readonly ReflectionProbe.set_refreshModeDelegate set_refreshModeDelegateField;

		// Token: 0x04000316 RID: 790
		private static readonly ReflectionProbe.get_timeSlicingModeDelegate get_timeSlicingModeDelegateField;

		// Token: 0x04000317 RID: 791
		private static readonly ReflectionProbe.set_timeSlicingModeDelegate set_timeSlicingModeDelegateField;

		// Token: 0x04000318 RID: 792
		private static readonly ReflectionProbe.get_bakedTextureDelegate get_bakedTextureDelegateField;

		// Token: 0x04000319 RID: 793
		private static readonly ReflectionProbe.set_bakedTextureDelegate set_bakedTextureDelegateField;

		// Token: 0x0400031A RID: 794
		private static readonly ReflectionProbe.get_customBakedTextureDelegate get_customBakedTextureDelegateField;

		// Token: 0x0400031B RID: 795
		private static readonly ReflectionProbe.set_customBakedTextureDelegate set_customBakedTextureDelegateField;

		// Token: 0x0400031C RID: 796
		private static readonly ReflectionProbe.get_realtimeTextureDelegate get_realtimeTextureDelegateField;

		// Token: 0x0400031D RID: 797
		private static readonly ReflectionProbe.set_realtimeTextureDelegate set_realtimeTextureDelegateField;

		// Token: 0x0400031E RID: 798
		private static readonly ReflectionProbe.get_textureDelegate get_textureDelegateField;

		// Token: 0x0400031F RID: 799
		private static readonly ReflectionProbe.ResetDelegate ResetDelegateField;

		// Token: 0x04000320 RID: 800
		private static readonly ReflectionProbe.IsFinishedRenderingDelegate IsFinishedRenderingDelegateField;

		// Token: 0x04000321 RID: 801
		private static readonly ReflectionProbe.ScheduleRenderDelegate ScheduleRenderDelegateField;

		// Token: 0x04000322 RID: 802
		private static readonly ReflectionProbe.BlendCubemapDelegate BlendCubemapDelegateField;

		// Token: 0x04000323 RID: 803
		private static readonly ReflectionProbe.get_minBakedCubemapResolutionDelegate get_minBakedCubemapResolutionDelegateField;

		// Token: 0x04000324 RID: 804
		private static readonly ReflectionProbe.get_maxBakedCubemapResolutionDelegate get_maxBakedCubemapResolutionDelegateField;

		// Token: 0x04000325 RID: 805
		private static readonly ReflectionProbe.get_defaultTextureDelegate get_defaultTextureDelegateField;

		// Token: 0x04000326 RID: 806
		private static readonly ReflectionProbe.get_size_InjectedDelegate get_size_InjectedDelegateField;

		// Token: 0x04000327 RID: 807
		private static readonly ReflectionProbe.set_size_InjectedDelegate set_size_InjectedDelegateField;

		// Token: 0x04000328 RID: 808
		private static readonly ReflectionProbe.get_center_InjectedDelegate get_center_InjectedDelegateField;

		// Token: 0x04000329 RID: 809
		private static readonly ReflectionProbe.set_center_InjectedDelegate set_center_InjectedDelegateField;

		// Token: 0x0400032A RID: 810
		private static readonly ReflectionProbe.get_bounds_InjectedDelegate get_bounds_InjectedDelegateField;

		// Token: 0x0400032B RID: 811
		private static readonly ReflectionProbe.get_backgroundColor_InjectedDelegate get_backgroundColor_InjectedDelegateField;

		// Token: 0x0400032C RID: 812
		private static readonly ReflectionProbe.set_backgroundColor_InjectedDelegate set_backgroundColor_InjectedDelegateField;

		// Token: 0x0400032D RID: 813
		private static readonly ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegate get_textureHDRDecodeValues_InjectedDelegateField;

		// Token: 0x0400032E RID: 814
		private static readonly ReflectionProbe.get_defaultTextureHDRDecodeValues_InjectedDelegate get_defaultTextureHDRDecodeValues_InjectedDelegateField;

		// Token: 0x020003DE RID: 990
		[OriginalName("UnityEngine.CoreModule.dll", "", "ReflectionProbeEvent")]
		public enum ReflectionProbeEvent
		{
			// Token: 0x04001EC9 RID: 7881
			ReflectionProbeAdded,
			// Token: 0x04001ECA RID: 7882
			ReflectionProbeRemoved
		}

		// Token: 0x020003DF RID: 991
		// (Invoke) Token: 0x060025EA RID: 9706
		private delegate UnityEngine.Rendering.ReflectionProbeType get_typeDelegate(IntPtr @this);

		// Token: 0x020003E0 RID: 992
		// (Invoke) Token: 0x060025EC RID: 9708
		private delegate void set_typeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeType value);

		// Token: 0x020003E1 RID: 993
		// (Invoke) Token: 0x060025EE RID: 9710
		private delegate float get_nearClipPlaneDelegate(IntPtr @this);

		// Token: 0x020003E2 RID: 994
		// (Invoke) Token: 0x060025F0 RID: 9712
		private delegate void set_nearClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x020003E3 RID: 995
		// (Invoke) Token: 0x060025F2 RID: 9714
		private delegate float get_farClipPlaneDelegate(IntPtr @this);

		// Token: 0x020003E4 RID: 996
		// (Invoke) Token: 0x060025F4 RID: 9716
		private delegate void set_farClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x020003E5 RID: 997
		// (Invoke) Token: 0x060025F6 RID: 9718
		private delegate float get_intensityDelegate(IntPtr @this);

		// Token: 0x020003E6 RID: 998
		// (Invoke) Token: 0x060025F8 RID: 9720
		private delegate void set_intensityDelegate(IntPtr @this, float value);

		// Token: 0x020003E7 RID: 999
		// (Invoke) Token: 0x060025FA RID: 9722
		private delegate bool get_hdrDelegate(IntPtr @this);

		// Token: 0x020003E8 RID: 1000
		// (Invoke) Token: 0x060025FC RID: 9724
		private delegate void set_hdrDelegate(IntPtr @this, bool value);

		// Token: 0x020003E9 RID: 1001
		// (Invoke) Token: 0x060025FE RID: 9726
		private delegate bool get_renderDynamicObjectsDelegate(IntPtr @this);

		// Token: 0x020003EA RID: 1002
		// (Invoke) Token: 0x06002600 RID: 9728
		private delegate void set_renderDynamicObjectsDelegate(IntPtr @this, bool value);

		// Token: 0x020003EB RID: 1003
		// (Invoke) Token: 0x06002602 RID: 9730
		private delegate float get_shadowDistanceDelegate(IntPtr @this);

		// Token: 0x020003EC RID: 1004
		// (Invoke) Token: 0x06002604 RID: 9732
		private delegate void set_shadowDistanceDelegate(IntPtr @this, float value);

		// Token: 0x020003ED RID: 1005
		// (Invoke) Token: 0x06002606 RID: 9734
		private delegate int get_resolutionDelegate(IntPtr @this);

		// Token: 0x020003EE RID: 1006
		// (Invoke) Token: 0x06002608 RID: 9736
		private delegate void set_resolutionDelegate(IntPtr @this, int value);

		// Token: 0x020003EF RID: 1007
		// (Invoke) Token: 0x0600260A RID: 9738
		private delegate int get_cullingMaskDelegate(IntPtr @this);

		// Token: 0x020003F0 RID: 1008
		// (Invoke) Token: 0x0600260C RID: 9740
		private delegate void set_cullingMaskDelegate(IntPtr @this, int value);

		// Token: 0x020003F1 RID: 1009
		// (Invoke) Token: 0x0600260E RID: 9742
		private delegate UnityEngine.Rendering.ReflectionProbeClearFlags get_clearFlagsDelegate(IntPtr @this);

		// Token: 0x020003F2 RID: 1010
		// (Invoke) Token: 0x06002610 RID: 9744
		private delegate void set_clearFlagsDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeClearFlags value);

		// Token: 0x020003F3 RID: 1011
		// (Invoke) Token: 0x06002612 RID: 9746
		private delegate float get_blendDistanceDelegate(IntPtr @this);

		// Token: 0x020003F4 RID: 1012
		// (Invoke) Token: 0x06002614 RID: 9748
		private delegate void set_blendDistanceDelegate(IntPtr @this, float value);

		// Token: 0x020003F5 RID: 1013
		// (Invoke) Token: 0x06002616 RID: 9750
		private delegate bool get_boxProjectionDelegate(IntPtr @this);

		// Token: 0x020003F6 RID: 1014
		// (Invoke) Token: 0x06002618 RID: 9752
		private delegate void set_boxProjectionDelegate(IntPtr @this, bool value);

		// Token: 0x020003F7 RID: 1015
		// (Invoke) Token: 0x0600261A RID: 9754
		private delegate UnityEngine.Rendering.ReflectionProbeMode get_modeDelegate(IntPtr @this);

		// Token: 0x020003F8 RID: 1016
		// (Invoke) Token: 0x0600261C RID: 9756
		private delegate void set_modeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeMode value);

		// Token: 0x020003F9 RID: 1017
		// (Invoke) Token: 0x0600261E RID: 9758
		private delegate int get_importanceDelegate(IntPtr @this);

		// Token: 0x020003FA RID: 1018
		// (Invoke) Token: 0x06002620 RID: 9760
		private delegate void set_importanceDelegate(IntPtr @this, int value);

		// Token: 0x020003FB RID: 1019
		// (Invoke) Token: 0x06002622 RID: 9762
		private delegate UnityEngine.Rendering.ReflectionProbeRefreshMode get_refreshModeDelegate(IntPtr @this);

		// Token: 0x020003FC RID: 1020
		// (Invoke) Token: 0x06002624 RID: 9764
		private delegate void set_refreshModeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeRefreshMode value);

		// Token: 0x020003FD RID: 1021
		// (Invoke) Token: 0x06002626 RID: 9766
		private delegate UnityEngine.Rendering.ReflectionProbeTimeSlicingMode get_timeSlicingModeDelegate(IntPtr @this);

		// Token: 0x020003FE RID: 1022
		// (Invoke) Token: 0x06002628 RID: 9768
		private delegate void set_timeSlicingModeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeTimeSlicingMode value);

		// Token: 0x020003FF RID: 1023
		// (Invoke) Token: 0x0600262A RID: 9770
		private delegate IntPtr get_bakedTextureDelegate(IntPtr @this);

		// Token: 0x02000400 RID: 1024
		// (Invoke) Token: 0x0600262C RID: 9772
		private delegate void set_bakedTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000401 RID: 1025
		// (Invoke) Token: 0x0600262E RID: 9774
		private delegate IntPtr get_customBakedTextureDelegate(IntPtr @this);

		// Token: 0x02000402 RID: 1026
		// (Invoke) Token: 0x06002630 RID: 9776
		private delegate void set_customBakedTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000403 RID: 1027
		// (Invoke) Token: 0x06002632 RID: 9778
		private delegate IntPtr get_realtimeTextureDelegate(IntPtr @this);

		// Token: 0x02000404 RID: 1028
		// (Invoke) Token: 0x06002634 RID: 9780
		private delegate void set_realtimeTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000405 RID: 1029
		// (Invoke) Token: 0x06002636 RID: 9782
		private delegate IntPtr get_textureDelegate(IntPtr @this);

		// Token: 0x02000406 RID: 1030
		// (Invoke) Token: 0x06002638 RID: 9784
		private delegate void ResetDelegate(IntPtr @this);

		// Token: 0x02000407 RID: 1031
		// (Invoke) Token: 0x0600263A RID: 9786
		private delegate bool IsFinishedRenderingDelegate(IntPtr @this, int renderId);

		// Token: 0x02000408 RID: 1032
		// (Invoke) Token: 0x0600263C RID: 9788
		private delegate int ScheduleRenderDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode, IntPtr targetTexture);

		// Token: 0x02000409 RID: 1033
		// (Invoke) Token: 0x0600263E RID: 9790
		private delegate bool BlendCubemapDelegate(IntPtr src, IntPtr dst, float blend, IntPtr target);

		// Token: 0x0200040A RID: 1034
		// (Invoke) Token: 0x06002640 RID: 9792
		private delegate int get_minBakedCubemapResolutionDelegate();

		// Token: 0x0200040B RID: 1035
		// (Invoke) Token: 0x06002642 RID: 9794
		private delegate int get_maxBakedCubemapResolutionDelegate();

		// Token: 0x0200040C RID: 1036
		// (Invoke) Token: 0x06002644 RID: 9796
		private delegate IntPtr get_defaultTextureDelegate();

		// Token: 0x0200040D RID: 1037
		// (Invoke) Token: 0x06002646 RID: 9798
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200040E RID: 1038
		// (Invoke) Token: 0x06002648 RID: 9800
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200040F RID: 1039
		// (Invoke) Token: 0x0600264A RID: 9802
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000410 RID: 1040
		// (Invoke) Token: 0x0600264C RID: 9804
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000411 RID: 1041
		// (Invoke) Token: 0x0600264E RID: 9806
		private delegate void get_bounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000412 RID: 1042
		// (Invoke) Token: 0x06002650 RID: 9808
		private delegate void get_backgroundColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000413 RID: 1043
		// (Invoke) Token: 0x06002652 RID: 9810
		private delegate void set_backgroundColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000414 RID: 1044
		// (Invoke) Token: 0x06002654 RID: 9812
		private delegate void get_textureHDRDecodeValues_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000415 RID: 1045
		// (Invoke) Token: 0x06002656 RID: 9814
		private delegate void get_defaultTextureHDRDecodeValues_InjectedDelegate([Out] IntPtr ret);
	}
}
