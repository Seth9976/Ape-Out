using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000065 RID: 101
	public sealed class LightmapSettings : Object
	{
		// Token: 0x060006E3 RID: 1763 RVA: 0x00026E58 File Offset: 0x00025058
		// Note: this type is marked as 'beforefieldinit'.
		static LightmapSettings()
		{
			Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightmapSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr);
			LightmapSettings.NativeMethodInfoPtr_get_lightmaps_Public_Static_get_Il2CppReferenceArray_1_LightmapData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100663822);
			LightmapSettings.set_lightmapsDelegateField = IL2CPP.ResolveICall<LightmapSettings.set_lightmapsDelegate>("UnityEngine.LightmapSettings::set_lightmaps");
			LightmapSettings.get_lightmapsModeDelegateField = IL2CPP.ResolveICall<LightmapSettings.get_lightmapsModeDelegate>("UnityEngine.LightmapSettings::get_lightmapsMode");
			LightmapSettings.set_lightmapsModeDelegateField = IL2CPP.ResolveICall<LightmapSettings.set_lightmapsModeDelegate>("UnityEngine.LightmapSettings::set_lightmapsMode");
			LightmapSettings.get_lightProbesDelegateField = IL2CPP.ResolveICall<LightmapSettings.get_lightProbesDelegate>("UnityEngine.LightmapSettings::get_lightProbes");
			LightmapSettings.set_lightProbesDelegateField = IL2CPP.ResolveICall<LightmapSettings.set_lightProbesDelegate>("UnityEngine.LightmapSettings::set_lightProbes");
			LightmapSettings.ResetDelegateField = IL2CPP.ResolveICall<LightmapSettings.ResetDelegate>("UnityEngine.LightmapSettings::Reset");
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00026EF8 File Offset: 0x000250F8
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00005735 File Offset: 0x00003935
		public unsafe static Il2CppReferenceArray<LightmapData> lightmaps
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488111, XrefRangeEnd = 488115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_get_lightmaps_Public_Static_get_Il2CppReferenceArray_1_LightmapData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LightmapData>>(intPtr3) : null;
			}
			set
			{
				LightmapSettings.set_lightmapsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0000572C File Offset: 0x0000392C
		public LightmapSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00005747 File Offset: 0x00003947
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00005753 File Offset: 0x00003953
		public static LightmapsMode lightmapsMode
		{
			get
			{
				return LightmapSettings.get_lightmapsModeDelegateField();
			}
			set
			{
				LightmapSettings.set_lightmapsModeDelegateField(value);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00026F2C File Offset: 0x0002512C
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x00005760 File Offset: 0x00003960
		public static LightProbes lightProbes
		{
			get
			{
				IntPtr intPtr = LightmapSettings.get_lightProbesDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightProbes>(intPtr2) : null;
			}
			set
			{
				LightmapSettings.set_lightProbesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00005772 File Offset: 0x00003972
		public static void Reset()
		{
			LightmapSettings.ResetDelegateField();
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00026F54 File Offset: 0x00025154
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x0000577E File Offset: 0x0000397E
		public static LightmapsModeLegacy lightmapsModeLegacy
		{
			get
			{
				return LightmapsModeLegacy.Single;
			}
			set
			{
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00026F68 File Offset: 0x00025168
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00005781 File Offset: 0x00003981
		public static ColorSpace bakedColorSpace
		{
			get
			{
				return QualitySettings.desiredColorSpace;
			}
			set
			{
			}
		}

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_get_lightmaps_Public_Static_get_Il2CppReferenceArray_1_LightmapData_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly LightmapSettings.set_lightmapsDelegate set_lightmapsDelegateField;

		// Token: 0x040004C7 RID: 1223
		private static readonly LightmapSettings.get_lightmapsModeDelegate get_lightmapsModeDelegateField;

		// Token: 0x040004C8 RID: 1224
		private static readonly LightmapSettings.set_lightmapsModeDelegate set_lightmapsModeDelegateField;

		// Token: 0x040004C9 RID: 1225
		private static readonly LightmapSettings.get_lightProbesDelegate get_lightProbesDelegateField;

		// Token: 0x040004CA RID: 1226
		private static readonly LightmapSettings.set_lightProbesDelegate set_lightProbesDelegateField;

		// Token: 0x040004CB RID: 1227
		private static readonly LightmapSettings.ResetDelegate ResetDelegateField;

		// Token: 0x02000491 RID: 1169
		// (Invoke) Token: 0x06002758 RID: 10072
		private delegate void set_lightmapsDelegate(IntPtr value);

		// Token: 0x02000492 RID: 1170
		// (Invoke) Token: 0x0600275A RID: 10074
		private delegate LightmapsMode get_lightmapsModeDelegate();

		// Token: 0x02000493 RID: 1171
		// (Invoke) Token: 0x0600275C RID: 10076
		private delegate void set_lightmapsModeDelegate(LightmapsMode value);

		// Token: 0x02000494 RID: 1172
		// (Invoke) Token: 0x0600275E RID: 10078
		private delegate IntPtr get_lightProbesDelegate();

		// Token: 0x02000495 RID: 1173
		// (Invoke) Token: 0x06002760 RID: 10080
		private delegate void set_lightProbesDelegate(IntPtr value);

		// Token: 0x02000496 RID: 1174
		// (Invoke) Token: 0x06002762 RID: 10082
		private delegate void ResetDelegate();
	}
}
