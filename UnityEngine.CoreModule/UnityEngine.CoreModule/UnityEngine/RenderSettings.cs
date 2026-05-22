using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000070 RID: 112
	public sealed class RenderSettings : Object
	{
		// Token: 0x060008F2 RID: 2290 RVA: 0x0002A8B8 File Offset: 0x00028AB8
		// Note: this type is marked as 'beforefieldinit'.
		static RenderSettings()
		{
			Il2CppClassPointerStore<RenderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr);
			RenderSettings.NativeMethodInfoPtr_get_fog_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100663900);
			RenderSettings.NativeMethodInfoPtr_set_fog_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100663901);
			RenderSettings.NativeMethodInfoPtr_get_fogStartDistance_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100663902);
			RenderSettings.NativeMethodInfoPtr_get_fogEndDistance_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100663903);
			RenderSettings.NativeMethodInfoPtr_get_fogColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100663904);
			RenderSettings.NativeMethodInfoPtr_get_fogDensity_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100663905);
			RenderSettings.NativeMethodInfoPtr_get_fogColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100663906);
			RenderSettings.set_fogStartDistanceDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogStartDistanceDelegate>("UnityEngine.RenderSettings::set_fogStartDistance");
			RenderSettings.set_fogEndDistanceDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogEndDistanceDelegate>("UnityEngine.RenderSettings::set_fogEndDistance");
			RenderSettings.get_fogModeDelegateField = IL2CPP.ResolveICall<RenderSettings.get_fogModeDelegate>("UnityEngine.RenderSettings::get_fogMode");
			RenderSettings.set_fogModeDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogModeDelegate>("UnityEngine.RenderSettings::set_fogMode");
			RenderSettings.set_fogDensityDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogDensityDelegate>("UnityEngine.RenderSettings::set_fogDensity");
			RenderSettings.get_ambientModeDelegateField = IL2CPP.ResolveICall<RenderSettings.get_ambientModeDelegate>("UnityEngine.RenderSettings::get_ambientMode");
			RenderSettings.set_ambientModeDelegateField = IL2CPP.ResolveICall<RenderSettings.set_ambientModeDelegate>("UnityEngine.RenderSettings::set_ambientMode");
			RenderSettings.get_ambientIntensityDelegateField = IL2CPP.ResolveICall<RenderSettings.get_ambientIntensityDelegate>("UnityEngine.RenderSettings::get_ambientIntensity");
			RenderSettings.set_ambientIntensityDelegateField = IL2CPP.ResolveICall<RenderSettings.set_ambientIntensityDelegate>("UnityEngine.RenderSettings::set_ambientIntensity");
			RenderSettings.get_skyboxDelegateField = IL2CPP.ResolveICall<RenderSettings.get_skyboxDelegate>("UnityEngine.RenderSettings::get_skybox");
			RenderSettings.set_skyboxDelegateField = IL2CPP.ResolveICall<RenderSettings.set_skyboxDelegate>("UnityEngine.RenderSettings::set_skybox");
			RenderSettings.get_sunDelegateField = IL2CPP.ResolveICall<RenderSettings.get_sunDelegate>("UnityEngine.RenderSettings::get_sun");
			RenderSettings.set_sunDelegateField = IL2CPP.ResolveICall<RenderSettings.set_sunDelegate>("UnityEngine.RenderSettings::set_sun");
			RenderSettings.get_customReflectionDelegateField = IL2CPP.ResolveICall<RenderSettings.get_customReflectionDelegate>("UnityEngine.RenderSettings::get_customReflection");
			RenderSettings.set_customReflectionDelegateField = IL2CPP.ResolveICall<RenderSettings.set_customReflectionDelegate>("UnityEngine.RenderSettings::set_customReflection");
			RenderSettings.get_reflectionIntensityDelegateField = IL2CPP.ResolveICall<RenderSettings.get_reflectionIntensityDelegate>("UnityEngine.RenderSettings::get_reflectionIntensity");
			RenderSettings.set_reflectionIntensityDelegateField = IL2CPP.ResolveICall<RenderSettings.set_reflectionIntensityDelegate>("UnityEngine.RenderSettings::set_reflectionIntensity");
			RenderSettings.get_reflectionBouncesDelegateField = IL2CPP.ResolveICall<RenderSettings.get_reflectionBouncesDelegate>("UnityEngine.RenderSettings::get_reflectionBounces");
			RenderSettings.set_reflectionBouncesDelegateField = IL2CPP.ResolveICall<RenderSettings.set_reflectionBouncesDelegate>("UnityEngine.RenderSettings::set_reflectionBounces");
			RenderSettings.get_defaultReflectionModeDelegateField = IL2CPP.ResolveICall<RenderSettings.get_defaultReflectionModeDelegate>("UnityEngine.RenderSettings::get_defaultReflectionMode");
			RenderSettings.set_defaultReflectionModeDelegateField = IL2CPP.ResolveICall<RenderSettings.set_defaultReflectionModeDelegate>("UnityEngine.RenderSettings::set_defaultReflectionMode");
			RenderSettings.get_defaultReflectionResolutionDelegateField = IL2CPP.ResolveICall<RenderSettings.get_defaultReflectionResolutionDelegate>("UnityEngine.RenderSettings::get_defaultReflectionResolution");
			RenderSettings.set_defaultReflectionResolutionDelegateField = IL2CPP.ResolveICall<RenderSettings.set_defaultReflectionResolutionDelegate>("UnityEngine.RenderSettings::set_defaultReflectionResolution");
			RenderSettings.get_haloStrengthDelegateField = IL2CPP.ResolveICall<RenderSettings.get_haloStrengthDelegate>("UnityEngine.RenderSettings::get_haloStrength");
			RenderSettings.set_haloStrengthDelegateField = IL2CPP.ResolveICall<RenderSettings.set_haloStrengthDelegate>("UnityEngine.RenderSettings::set_haloStrength");
			RenderSettings.get_flareStrengthDelegateField = IL2CPP.ResolveICall<RenderSettings.get_flareStrengthDelegate>("UnityEngine.RenderSettings::get_flareStrength");
			RenderSettings.set_flareStrengthDelegateField = IL2CPP.ResolveICall<RenderSettings.set_flareStrengthDelegate>("UnityEngine.RenderSettings::set_flareStrength");
			RenderSettings.get_flareFadeSpeedDelegateField = IL2CPP.ResolveICall<RenderSettings.get_flareFadeSpeedDelegate>("UnityEngine.RenderSettings::get_flareFadeSpeed");
			RenderSettings.set_flareFadeSpeedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_flareFadeSpeedDelegate>("UnityEngine.RenderSettings::set_flareFadeSpeed");
			RenderSettings.GetRenderSettingsDelegateField = IL2CPP.ResolveICall<RenderSettings.GetRenderSettingsDelegate>("UnityEngine.RenderSettings::GetRenderSettings");
			RenderSettings.ResetDelegateField = IL2CPP.ResolveICall<RenderSettings.ResetDelegate>("UnityEngine.RenderSettings::Reset");
			RenderSettings.set_fogColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_fogColor_InjectedDelegate>("UnityEngine.RenderSettings::set_fogColor_Injected");
			RenderSettings.get_ambientSkyColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.get_ambientSkyColor_InjectedDelegate>("UnityEngine.RenderSettings::get_ambientSkyColor_Injected");
			RenderSettings.set_ambientSkyColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_ambientSkyColor_InjectedDelegate>("UnityEngine.RenderSettings::set_ambientSkyColor_Injected");
			RenderSettings.get_ambientEquatorColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.get_ambientEquatorColor_InjectedDelegate>("UnityEngine.RenderSettings::get_ambientEquatorColor_Injected");
			RenderSettings.set_ambientEquatorColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_ambientEquatorColor_InjectedDelegate>("UnityEngine.RenderSettings::set_ambientEquatorColor_Injected");
			RenderSettings.get_ambientGroundColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.get_ambientGroundColor_InjectedDelegate>("UnityEngine.RenderSettings::get_ambientGroundColor_Injected");
			RenderSettings.set_ambientGroundColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_ambientGroundColor_InjectedDelegate>("UnityEngine.RenderSettings::set_ambientGroundColor_Injected");
			RenderSettings.get_ambientLight_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.get_ambientLight_InjectedDelegate>("UnityEngine.RenderSettings::get_ambientLight_Injected");
			RenderSettings.set_ambientLight_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_ambientLight_InjectedDelegate>("UnityEngine.RenderSettings::set_ambientLight_Injected");
			RenderSettings.get_subtractiveShadowColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.get_subtractiveShadowColor_InjectedDelegate>("UnityEngine.RenderSettings::get_subtractiveShadowColor_Injected");
			RenderSettings.set_subtractiveShadowColor_InjectedDelegateField = IL2CPP.ResolveICall<RenderSettings.set_subtractiveShadowColor_InjectedDelegate>("UnityEngine.RenderSettings::set_subtractiveShadowColor_Injected");
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x0002ABEC File Offset: 0x00028DEC
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x0002AC1C File Offset: 0x00028E1C
		public unsafe static bool fog
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488575, XrefRangeEnd = 488579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fog_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488579, XrefRangeEnd = 488583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fog_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0002AC50 File Offset: 0x00028E50
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00006E62 File Offset: 0x00005062
		public unsafe static float fogStartDistance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488583, XrefRangeEnd = 488587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogStartDistance_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				RenderSettings.set_fogStartDistanceDelegateField(value);
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0002AC80 File Offset: 0x00028E80
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x00006E6F File Offset: 0x0000506F
		public unsafe static float fogEndDistance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488587, XrefRangeEnd = 488591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogEndDistance_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				RenderSettings.set_fogEndDistanceDelegateField(value);
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0002ACB0 File Offset: 0x00028EB0
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x00006E95 File Offset: 0x00005095
		public unsafe static Color fogColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488591, XrefRangeEnd = 488593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				RenderSettings.set_fogColor_Injected(ref value);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0002ACE0 File Offset: 0x00028EE0
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x00006E9E File Offset: 0x0000509E
		public unsafe static float fogDensity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488593, XrefRangeEnd = 488597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogDensity_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				RenderSettings.set_fogDensityDelegateField(value);
			}
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0002AD10 File Offset: 0x00028F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488597, XrefRangeEnd = 488601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_fogColor_Injected(out Color ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00006E4F File Offset: 0x0000504F
		public RenderSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x0002AD44 File Offset: 0x00028F44
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x00006E58 File Offset: 0x00005058
		public static float ambientSkyboxAmount
		{
			get
			{
				return RenderSettings.ambientIntensity;
			}
			set
			{
				RenderSettings.ambientIntensity = value;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00006E7C File Offset: 0x0000507C
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x00006E88 File Offset: 0x00005088
		public static FogMode fogMode
		{
			get
			{
				return RenderSettings.get_fogModeDelegateField();
			}
			set
			{
				RenderSettings.set_fogModeDelegateField(value);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x00006EAB File Offset: 0x000050AB
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x00006EB7 File Offset: 0x000050B7
		public static UnityEngine.Rendering.AmbientMode ambientMode
		{
			get
			{
				return RenderSettings.get_ambientModeDelegateField();
			}
			set
			{
				RenderSettings.set_ambientModeDelegateField(value);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x0002AD5C File Offset: 0x00028F5C
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x00006EC4 File Offset: 0x000050C4
		public static Color ambientSkyColor
		{
			get
			{
				Color color;
				RenderSettings.get_ambientSkyColor_Injected(out color);
				return color;
			}
			set
			{
				RenderSettings.set_ambientSkyColor_Injected(ref value);
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x0002AD74 File Offset: 0x00028F74
		// (set) Token: 0x06000908 RID: 2312 RVA: 0x00006ECD File Offset: 0x000050CD
		public static Color ambientEquatorColor
		{
			get
			{
				Color color;
				RenderSettings.get_ambientEquatorColor_Injected(out color);
				return color;
			}
			set
			{
				RenderSettings.set_ambientEquatorColor_Injected(ref value);
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x0002AD8C File Offset: 0x00028F8C
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x00006ED6 File Offset: 0x000050D6
		public static Color ambientGroundColor
		{
			get
			{
				Color color;
				RenderSettings.get_ambientGroundColor_Injected(out color);
				return color;
			}
			set
			{
				RenderSettings.set_ambientGroundColor_Injected(ref value);
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x00006EDF File Offset: 0x000050DF
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x00006EEB File Offset: 0x000050EB
		public static float ambientIntensity
		{
			get
			{
				return RenderSettings.get_ambientIntensityDelegateField();
			}
			set
			{
				RenderSettings.set_ambientIntensityDelegateField(value);
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0002ADA4 File Offset: 0x00028FA4
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x00006EF8 File Offset: 0x000050F8
		public static Color ambientLight
		{
			get
			{
				Color color;
				RenderSettings.get_ambientLight_Injected(out color);
				return color;
			}
			set
			{
				RenderSettings.set_ambientLight_Injected(ref value);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x0002ADBC File Offset: 0x00028FBC
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x00006F01 File Offset: 0x00005101
		public static Color subtractiveShadowColor
		{
			get
			{
				Color color;
				RenderSettings.get_subtractiveShadowColor_Injected(out color);
				return color;
			}
			set
			{
				RenderSettings.set_subtractiveShadowColor_Injected(ref value);
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x0002ADD4 File Offset: 0x00028FD4
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x00006F0A File Offset: 0x0000510A
		public static Material skybox
		{
			get
			{
				IntPtr intPtr = RenderSettings.get_skyboxDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				RenderSettings.set_skyboxDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x0002ADFC File Offset: 0x00028FFC
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x00006F1C File Offset: 0x0000511C
		public static Light sun
		{
			get
			{
				IntPtr intPtr = RenderSettings.get_sunDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				RenderSettings.set_sunDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x0002AE24 File Offset: 0x00029024
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00006F2E File Offset: 0x0000512E
		public static Cubemap customReflection
		{
			get
			{
				IntPtr intPtr = RenderSettings.get_customReflectionDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr2) : null;
			}
			set
			{
				RenderSettings.set_customReflectionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x00006F40 File Offset: 0x00005140
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00006F4C File Offset: 0x0000514C
		public static float reflectionIntensity
		{
			get
			{
				return RenderSettings.get_reflectionIntensityDelegateField();
			}
			set
			{
				RenderSettings.set_reflectionIntensityDelegateField(value);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x00006F59 File Offset: 0x00005159
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x00006F65 File Offset: 0x00005165
		public static int reflectionBounces
		{
			get
			{
				return RenderSettings.get_reflectionBouncesDelegateField();
			}
			set
			{
				RenderSettings.set_reflectionBouncesDelegateField(value);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00006F72 File Offset: 0x00005172
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x00006F7E File Offset: 0x0000517E
		public static UnityEngine.Rendering.DefaultReflectionMode defaultReflectionMode
		{
			get
			{
				return RenderSettings.get_defaultReflectionModeDelegateField();
			}
			set
			{
				RenderSettings.set_defaultReflectionModeDelegateField(value);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00006F8B File Offset: 0x0000518B
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x00006F97 File Offset: 0x00005197
		public static int defaultReflectionResolution
		{
			get
			{
				return RenderSettings.get_defaultReflectionResolutionDelegateField();
			}
			set
			{
				RenderSettings.set_defaultReflectionResolutionDelegateField(value);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x00006FA4 File Offset: 0x000051A4
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x00006FB0 File Offset: 0x000051B0
		public static float haloStrength
		{
			get
			{
				return RenderSettings.get_haloStrengthDelegateField();
			}
			set
			{
				RenderSettings.set_haloStrengthDelegateField(value);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00006FBD File Offset: 0x000051BD
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x00006FC9 File Offset: 0x000051C9
		public static float flareStrength
		{
			get
			{
				return RenderSettings.get_flareStrengthDelegateField();
			}
			set
			{
				RenderSettings.set_flareStrengthDelegateField(value);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00006FD6 File Offset: 0x000051D6
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x00006FE2 File Offset: 0x000051E2
		public static float flareFadeSpeed
		{
			get
			{
				return RenderSettings.get_flareFadeSpeedDelegateField();
			}
			set
			{
				RenderSettings.set_flareFadeSpeedDelegateField(value);
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0002AE4C File Offset: 0x0002904C
		public static Object GetRenderSettings()
		{
			IntPtr intPtr = RenderSettings.GetRenderSettingsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00006FEF File Offset: 0x000051EF
		public static void Reset()
		{
			RenderSettings.ResetDelegateField();
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00006FFB File Offset: 0x000051FB
		public static void set_fogColor_Injected(ref Color value)
		{
			RenderSettings.set_fogColor_InjectedDelegateField(ref value);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00007008 File Offset: 0x00005208
		public static void get_ambientSkyColor_Injected(out Color ret)
		{
			RenderSettings.get_ambientSkyColor_InjectedDelegateField(out ret);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00007015 File Offset: 0x00005215
		public static void set_ambientSkyColor_Injected(ref Color value)
		{
			RenderSettings.set_ambientSkyColor_InjectedDelegateField(ref value);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00007022 File Offset: 0x00005222
		public static void get_ambientEquatorColor_Injected(out Color ret)
		{
			RenderSettings.get_ambientEquatorColor_InjectedDelegateField(out ret);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0000702F File Offset: 0x0000522F
		public static void set_ambientEquatorColor_Injected(ref Color value)
		{
			RenderSettings.set_ambientEquatorColor_InjectedDelegateField(ref value);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0000703C File Offset: 0x0000523C
		public static void get_ambientGroundColor_Injected(out Color ret)
		{
			RenderSettings.get_ambientGroundColor_InjectedDelegateField(out ret);
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00007049 File Offset: 0x00005249
		public static void set_ambientGroundColor_Injected(ref Color value)
		{
			RenderSettings.set_ambientGroundColor_InjectedDelegateField(ref value);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00007056 File Offset: 0x00005256
		public static void get_ambientLight_Injected(out Color ret)
		{
			RenderSettings.get_ambientLight_InjectedDelegateField(out ret);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00007063 File Offset: 0x00005263
		public static void set_ambientLight_Injected(ref Color value)
		{
			RenderSettings.set_ambientLight_InjectedDelegateField(ref value);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00007070 File Offset: 0x00005270
		public static void get_subtractiveShadowColor_Injected(out Color ret)
		{
			RenderSettings.get_subtractiveShadowColor_InjectedDelegateField(out ret);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0000707D File Offset: 0x0000527D
		public static void set_subtractiveShadowColor_Injected(ref Color value)
		{
			RenderSettings.set_subtractiveShadowColor_InjectedDelegateField(ref value);
		}

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_get_fog_Public_Static_get_Boolean_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_set_fog_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_get_fogStartDistance_Public_Static_get_Single_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_get_fogEndDistance_Public_Static_get_Single_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_get_fogColor_Public_Static_get_Color_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_get_fogDensity_Public_Static_get_Single_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_get_fogColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x0400061A RID: 1562
		private static readonly RenderSettings.set_fogStartDistanceDelegate set_fogStartDistanceDelegateField;

		// Token: 0x0400061B RID: 1563
		private static readonly RenderSettings.set_fogEndDistanceDelegate set_fogEndDistanceDelegateField;

		// Token: 0x0400061C RID: 1564
		private static readonly RenderSettings.get_fogModeDelegate get_fogModeDelegateField;

		// Token: 0x0400061D RID: 1565
		private static readonly RenderSettings.set_fogModeDelegate set_fogModeDelegateField;

		// Token: 0x0400061E RID: 1566
		private static readonly RenderSettings.set_fogDensityDelegate set_fogDensityDelegateField;

		// Token: 0x0400061F RID: 1567
		private static readonly RenderSettings.get_ambientModeDelegate get_ambientModeDelegateField;

		// Token: 0x04000620 RID: 1568
		private static readonly RenderSettings.set_ambientModeDelegate set_ambientModeDelegateField;

		// Token: 0x04000621 RID: 1569
		private static readonly RenderSettings.get_ambientIntensityDelegate get_ambientIntensityDelegateField;

		// Token: 0x04000622 RID: 1570
		private static readonly RenderSettings.set_ambientIntensityDelegate set_ambientIntensityDelegateField;

		// Token: 0x04000623 RID: 1571
		private static readonly RenderSettings.get_skyboxDelegate get_skyboxDelegateField;

		// Token: 0x04000624 RID: 1572
		private static readonly RenderSettings.set_skyboxDelegate set_skyboxDelegateField;

		// Token: 0x04000625 RID: 1573
		private static readonly RenderSettings.get_sunDelegate get_sunDelegateField;

		// Token: 0x04000626 RID: 1574
		private static readonly RenderSettings.set_sunDelegate set_sunDelegateField;

		// Token: 0x04000627 RID: 1575
		private static readonly RenderSettings.get_customReflectionDelegate get_customReflectionDelegateField;

		// Token: 0x04000628 RID: 1576
		private static readonly RenderSettings.set_customReflectionDelegate set_customReflectionDelegateField;

		// Token: 0x04000629 RID: 1577
		private static readonly RenderSettings.get_reflectionIntensityDelegate get_reflectionIntensityDelegateField;

		// Token: 0x0400062A RID: 1578
		private static readonly RenderSettings.set_reflectionIntensityDelegate set_reflectionIntensityDelegateField;

		// Token: 0x0400062B RID: 1579
		private static readonly RenderSettings.get_reflectionBouncesDelegate get_reflectionBouncesDelegateField;

		// Token: 0x0400062C RID: 1580
		private static readonly RenderSettings.set_reflectionBouncesDelegate set_reflectionBouncesDelegateField;

		// Token: 0x0400062D RID: 1581
		private static readonly RenderSettings.get_defaultReflectionModeDelegate get_defaultReflectionModeDelegateField;

		// Token: 0x0400062E RID: 1582
		private static readonly RenderSettings.set_defaultReflectionModeDelegate set_defaultReflectionModeDelegateField;

		// Token: 0x0400062F RID: 1583
		private static readonly RenderSettings.get_defaultReflectionResolutionDelegate get_defaultReflectionResolutionDelegateField;

		// Token: 0x04000630 RID: 1584
		private static readonly RenderSettings.set_defaultReflectionResolutionDelegate set_defaultReflectionResolutionDelegateField;

		// Token: 0x04000631 RID: 1585
		private static readonly RenderSettings.get_haloStrengthDelegate get_haloStrengthDelegateField;

		// Token: 0x04000632 RID: 1586
		private static readonly RenderSettings.set_haloStrengthDelegate set_haloStrengthDelegateField;

		// Token: 0x04000633 RID: 1587
		private static readonly RenderSettings.get_flareStrengthDelegate get_flareStrengthDelegateField;

		// Token: 0x04000634 RID: 1588
		private static readonly RenderSettings.set_flareStrengthDelegate set_flareStrengthDelegateField;

		// Token: 0x04000635 RID: 1589
		private static readonly RenderSettings.get_flareFadeSpeedDelegate get_flareFadeSpeedDelegateField;

		// Token: 0x04000636 RID: 1590
		private static readonly RenderSettings.set_flareFadeSpeedDelegate set_flareFadeSpeedDelegateField;

		// Token: 0x04000637 RID: 1591
		private static readonly RenderSettings.GetRenderSettingsDelegate GetRenderSettingsDelegateField;

		// Token: 0x04000638 RID: 1592
		private static readonly RenderSettings.ResetDelegate ResetDelegateField;

		// Token: 0x04000639 RID: 1593
		private static readonly RenderSettings.set_fogColor_InjectedDelegate set_fogColor_InjectedDelegateField;

		// Token: 0x0400063A RID: 1594
		private static readonly RenderSettings.get_ambientSkyColor_InjectedDelegate get_ambientSkyColor_InjectedDelegateField;

		// Token: 0x0400063B RID: 1595
		private static readonly RenderSettings.set_ambientSkyColor_InjectedDelegate set_ambientSkyColor_InjectedDelegateField;

		// Token: 0x0400063C RID: 1596
		private static readonly RenderSettings.get_ambientEquatorColor_InjectedDelegate get_ambientEquatorColor_InjectedDelegateField;

		// Token: 0x0400063D RID: 1597
		private static readonly RenderSettings.set_ambientEquatorColor_InjectedDelegate set_ambientEquatorColor_InjectedDelegateField;

		// Token: 0x0400063E RID: 1598
		private static readonly RenderSettings.get_ambientGroundColor_InjectedDelegate get_ambientGroundColor_InjectedDelegateField;

		// Token: 0x0400063F RID: 1599
		private static readonly RenderSettings.set_ambientGroundColor_InjectedDelegate set_ambientGroundColor_InjectedDelegateField;

		// Token: 0x04000640 RID: 1600
		private static readonly RenderSettings.get_ambientLight_InjectedDelegate get_ambientLight_InjectedDelegateField;

		// Token: 0x04000641 RID: 1601
		private static readonly RenderSettings.set_ambientLight_InjectedDelegate set_ambientLight_InjectedDelegateField;

		// Token: 0x04000642 RID: 1602
		private static readonly RenderSettings.get_subtractiveShadowColor_InjectedDelegate get_subtractiveShadowColor_InjectedDelegateField;

		// Token: 0x04000643 RID: 1603
		private static readonly RenderSettings.set_subtractiveShadowColor_InjectedDelegate set_subtractiveShadowColor_InjectedDelegateField;

		// Token: 0x02000577 RID: 1399
		// (Invoke) Token: 0x06002924 RID: 10532
		private delegate void set_fogStartDistanceDelegate(float value);

		// Token: 0x02000578 RID: 1400
		// (Invoke) Token: 0x06002926 RID: 10534
		private delegate void set_fogEndDistanceDelegate(float value);

		// Token: 0x02000579 RID: 1401
		// (Invoke) Token: 0x06002928 RID: 10536
		private delegate FogMode get_fogModeDelegate();

		// Token: 0x0200057A RID: 1402
		// (Invoke) Token: 0x0600292A RID: 10538
		private delegate void set_fogModeDelegate(FogMode value);

		// Token: 0x0200057B RID: 1403
		// (Invoke) Token: 0x0600292C RID: 10540
		private delegate void set_fogDensityDelegate(float value);

		// Token: 0x0200057C RID: 1404
		// (Invoke) Token: 0x0600292E RID: 10542
		private delegate UnityEngine.Rendering.AmbientMode get_ambientModeDelegate();

		// Token: 0x0200057D RID: 1405
		// (Invoke) Token: 0x06002930 RID: 10544
		private delegate void set_ambientModeDelegate(UnityEngine.Rendering.AmbientMode value);

		// Token: 0x0200057E RID: 1406
		// (Invoke) Token: 0x06002932 RID: 10546
		private delegate float get_ambientIntensityDelegate();

		// Token: 0x0200057F RID: 1407
		// (Invoke) Token: 0x06002934 RID: 10548
		private delegate void set_ambientIntensityDelegate(float value);

		// Token: 0x02000580 RID: 1408
		// (Invoke) Token: 0x06002936 RID: 10550
		private delegate IntPtr get_skyboxDelegate();

		// Token: 0x02000581 RID: 1409
		// (Invoke) Token: 0x06002938 RID: 10552
		private delegate void set_skyboxDelegate(IntPtr value);

		// Token: 0x02000582 RID: 1410
		// (Invoke) Token: 0x0600293A RID: 10554
		private delegate IntPtr get_sunDelegate();

		// Token: 0x02000583 RID: 1411
		// (Invoke) Token: 0x0600293C RID: 10556
		private delegate void set_sunDelegate(IntPtr value);

		// Token: 0x02000584 RID: 1412
		// (Invoke) Token: 0x0600293E RID: 10558
		private delegate IntPtr get_customReflectionDelegate();

		// Token: 0x02000585 RID: 1413
		// (Invoke) Token: 0x06002940 RID: 10560
		private delegate void set_customReflectionDelegate(IntPtr value);

		// Token: 0x02000586 RID: 1414
		// (Invoke) Token: 0x06002942 RID: 10562
		private delegate float get_reflectionIntensityDelegate();

		// Token: 0x02000587 RID: 1415
		// (Invoke) Token: 0x06002944 RID: 10564
		private delegate void set_reflectionIntensityDelegate(float value);

		// Token: 0x02000588 RID: 1416
		// (Invoke) Token: 0x06002946 RID: 10566
		private delegate int get_reflectionBouncesDelegate();

		// Token: 0x02000589 RID: 1417
		// (Invoke) Token: 0x06002948 RID: 10568
		private delegate void set_reflectionBouncesDelegate(int value);

		// Token: 0x0200058A RID: 1418
		// (Invoke) Token: 0x0600294A RID: 10570
		private delegate UnityEngine.Rendering.DefaultReflectionMode get_defaultReflectionModeDelegate();

		// Token: 0x0200058B RID: 1419
		// (Invoke) Token: 0x0600294C RID: 10572
		private delegate void set_defaultReflectionModeDelegate(UnityEngine.Rendering.DefaultReflectionMode value);

		// Token: 0x0200058C RID: 1420
		// (Invoke) Token: 0x0600294E RID: 10574
		private delegate int get_defaultReflectionResolutionDelegate();

		// Token: 0x0200058D RID: 1421
		// (Invoke) Token: 0x06002950 RID: 10576
		private delegate void set_defaultReflectionResolutionDelegate(int value);

		// Token: 0x0200058E RID: 1422
		// (Invoke) Token: 0x06002952 RID: 10578
		private delegate float get_haloStrengthDelegate();

		// Token: 0x0200058F RID: 1423
		// (Invoke) Token: 0x06002954 RID: 10580
		private delegate void set_haloStrengthDelegate(float value);

		// Token: 0x02000590 RID: 1424
		// (Invoke) Token: 0x06002956 RID: 10582
		private delegate float get_flareStrengthDelegate();

		// Token: 0x02000591 RID: 1425
		// (Invoke) Token: 0x06002958 RID: 10584
		private delegate void set_flareStrengthDelegate(float value);

		// Token: 0x02000592 RID: 1426
		// (Invoke) Token: 0x0600295A RID: 10586
		private delegate float get_flareFadeSpeedDelegate();

		// Token: 0x02000593 RID: 1427
		// (Invoke) Token: 0x0600295C RID: 10588
		private delegate void set_flareFadeSpeedDelegate(float value);

		// Token: 0x02000594 RID: 1428
		// (Invoke) Token: 0x0600295E RID: 10590
		private delegate IntPtr GetRenderSettingsDelegate();

		// Token: 0x02000595 RID: 1429
		// (Invoke) Token: 0x06002960 RID: 10592
		private delegate void ResetDelegate();

		// Token: 0x02000596 RID: 1430
		// (Invoke) Token: 0x06002962 RID: 10594
		private delegate void set_fogColor_InjectedDelegate(IntPtr value);

		// Token: 0x02000597 RID: 1431
		// (Invoke) Token: 0x06002964 RID: 10596
		private delegate void get_ambientSkyColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000598 RID: 1432
		// (Invoke) Token: 0x06002966 RID: 10598
		private delegate void set_ambientSkyColor_InjectedDelegate(IntPtr value);

		// Token: 0x02000599 RID: 1433
		// (Invoke) Token: 0x06002968 RID: 10600
		private delegate void get_ambientEquatorColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200059A RID: 1434
		// (Invoke) Token: 0x0600296A RID: 10602
		private delegate void set_ambientEquatorColor_InjectedDelegate(IntPtr value);

		// Token: 0x0200059B RID: 1435
		// (Invoke) Token: 0x0600296C RID: 10604
		private delegate void get_ambientGroundColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200059C RID: 1436
		// (Invoke) Token: 0x0600296E RID: 10606
		private delegate void set_ambientGroundColor_InjectedDelegate(IntPtr value);

		// Token: 0x0200059D RID: 1437
		// (Invoke) Token: 0x06002970 RID: 10608
		private delegate void get_ambientLight_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200059E RID: 1438
		// (Invoke) Token: 0x06002972 RID: 10610
		private delegate void set_ambientLight_InjectedDelegate(IntPtr value);

		// Token: 0x0200059F RID: 1439
		// (Invoke) Token: 0x06002974 RID: 10612
		private delegate void get_subtractiveShadowColor_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x020005A0 RID: 1440
		// (Invoke) Token: 0x06002976 RID: 10614
		private delegate void set_subtractiveShadowColor_InjectedDelegate(IntPtr value);
	}
}
