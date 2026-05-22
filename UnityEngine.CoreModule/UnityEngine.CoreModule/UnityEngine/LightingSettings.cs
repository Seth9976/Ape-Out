using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000058 RID: 88
	public sealed class LightingSettings : Object
	{
		// Token: 0x0600051C RID: 1308 RVA: 0x00022A10 File Offset: 0x00020C10
		// Note: this type is marked as 'beforefieldinit'.
		static LightingSettings()
		{
			Il2CppClassPointerStore<LightingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightingSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr);
			LightingSettings.NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingSettings>.NativeClassPtr, 100663731);
			LightingSettings.Internal_CreateDelegateField = IL2CPP.ResolveICall<LightingSettings.Internal_CreateDelegate>("UnityEngine.LightingSettings::Internal_Create");
			LightingSettings.get_bakedGIDelegateField = IL2CPP.ResolveICall<LightingSettings.get_bakedGIDelegate>("UnityEngine.LightingSettings::get_bakedGI");
			LightingSettings.set_bakedGIDelegateField = IL2CPP.ResolveICall<LightingSettings.set_bakedGIDelegate>("UnityEngine.LightingSettings::set_bakedGI");
			LightingSettings.get_realtimeGIDelegateField = IL2CPP.ResolveICall<LightingSettings.get_realtimeGIDelegate>("UnityEngine.LightingSettings::get_realtimeGI");
			LightingSettings.set_realtimeGIDelegateField = IL2CPP.ResolveICall<LightingSettings.set_realtimeGIDelegate>("UnityEngine.LightingSettings::set_realtimeGI");
			LightingSettings.get_realtimeEnvironmentLightingDelegateField = IL2CPP.ResolveICall<LightingSettings.get_realtimeEnvironmentLightingDelegate>("UnityEngine.LightingSettings::get_realtimeEnvironmentLighting");
			LightingSettings.set_realtimeEnvironmentLightingDelegateField = IL2CPP.ResolveICall<LightingSettings.set_realtimeEnvironmentLightingDelegate>("UnityEngine.LightingSettings::set_realtimeEnvironmentLighting");
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00022AC0 File Offset: 0x00020CC0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LightingSettingsDontStripMe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightingSettings.NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00004A35 File Offset: 0x00002C35
		public LightingSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00004A3E File Offset: 0x00002C3E
		public static void Internal_Create(LightingSettings self)
		{
			LightingSettings.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00004A50 File Offset: 0x00002C50
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00004A62 File Offset: 0x00002C62
		public bool bakedGI
		{
			get
			{
				return LightingSettings.get_bakedGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightingSettings.set_bakedGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00004A75 File Offset: 0x00002C75
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00004A87 File Offset: 0x00002C87
		public bool realtimeGI
		{
			get
			{
				return LightingSettings.get_realtimeGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightingSettings.set_realtimeGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00004A9A File Offset: 0x00002C9A
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00004AAC File Offset: 0x00002CAC
		public bool realtimeEnvironmentLighting
		{
			get
			{
				return LightingSettings.get_realtimeEnvironmentLightingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LightingSettings.set_realtimeEnvironmentLightingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_LightingSettingsDontStripMe_Internal_Void_0;

		// Token: 0x040003E5 RID: 997
		private static readonly LightingSettings.Internal_CreateDelegate Internal_CreateDelegateField;

		// Token: 0x040003E6 RID: 998
		private static readonly LightingSettings.get_bakedGIDelegate get_bakedGIDelegateField;

		// Token: 0x040003E7 RID: 999
		private static readonly LightingSettings.set_bakedGIDelegate set_bakedGIDelegateField;

		// Token: 0x040003E8 RID: 1000
		private static readonly LightingSettings.get_realtimeGIDelegate get_realtimeGIDelegateField;

		// Token: 0x040003E9 RID: 1001
		private static readonly LightingSettings.set_realtimeGIDelegate set_realtimeGIDelegateField;

		// Token: 0x040003EA RID: 1002
		private static readonly LightingSettings.get_realtimeEnvironmentLightingDelegate get_realtimeEnvironmentLightingDelegateField;

		// Token: 0x040003EB RID: 1003
		private static readonly LightingSettings.set_realtimeEnvironmentLightingDelegate set_realtimeEnvironmentLightingDelegateField;

		// Token: 0x02000421 RID: 1057
		// (Invoke) Token: 0x0600266C RID: 9836
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000422 RID: 1058
		// (Invoke) Token: 0x0600266E RID: 9838
		private delegate bool get_bakedGIDelegate(IntPtr @this);

		// Token: 0x02000423 RID: 1059
		// (Invoke) Token: 0x06002670 RID: 9840
		private delegate void set_bakedGIDelegate(IntPtr @this, bool value);

		// Token: 0x02000424 RID: 1060
		// (Invoke) Token: 0x06002672 RID: 9842
		private delegate bool get_realtimeGIDelegate(IntPtr @this);

		// Token: 0x02000425 RID: 1061
		// (Invoke) Token: 0x06002674 RID: 9844
		private delegate void set_realtimeGIDelegate(IntPtr @this, bool value);

		// Token: 0x02000426 RID: 1062
		// (Invoke) Token: 0x06002676 RID: 9846
		private delegate bool get_realtimeEnvironmentLightingDelegate(IntPtr @this);

		// Token: 0x02000427 RID: 1063
		// (Invoke) Token: 0x06002678 RID: 9848
		private delegate void set_realtimeEnvironmentLightingDelegate(IntPtr @this, bool value);
	}
}
