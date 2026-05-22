using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppDG.Tweening.Plugins.Core
{
	// Token: 0x02000040 RID: 64
	public static class PluginsManager : Object
	{
		// Token: 0x060003BA RID: 954 RVA: 0x00018BBC File Offset: 0x00016DBC
		// Note: this type is marked as 'beforefieldinit'.
		static PluginsManager()
		{
			Il2CppClassPointerStore<PluginsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core", "PluginsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr);
			PluginsManager.NativeFieldInfoPtr__floatPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_floatPlugin");
			PluginsManager.NativeFieldInfoPtr__doublePlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_doublePlugin");
			PluginsManager.NativeFieldInfoPtr__intPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_intPlugin");
			PluginsManager.NativeFieldInfoPtr__uintPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_uintPlugin");
			PluginsManager.NativeFieldInfoPtr__longPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_longPlugin");
			PluginsManager.NativeFieldInfoPtr__ulongPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_ulongPlugin");
			PluginsManager.NativeFieldInfoPtr__vector2Plugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_vector2Plugin");
			PluginsManager.NativeFieldInfoPtr__vector3Plugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_vector3Plugin");
			PluginsManager.NativeFieldInfoPtr__vector4Plugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_vector4Plugin");
			PluginsManager.NativeFieldInfoPtr__quaternionPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_quaternionPlugin");
			PluginsManager.NativeFieldInfoPtr__colorPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_colorPlugin");
			PluginsManager.NativeFieldInfoPtr__rectPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_rectPlugin");
			PluginsManager.NativeFieldInfoPtr__rectOffsetPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_rectOffsetPlugin");
			PluginsManager.NativeFieldInfoPtr__stringPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_stringPlugin");
			PluginsManager.NativeFieldInfoPtr__vector3ArrayPlugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_vector3ArrayPlugin");
			PluginsManager.NativeFieldInfoPtr__color2Plugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_color2Plugin");
			PluginsManager.NativeFieldInfoPtr__MaxCustomPlugins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_MaxCustomPlugins");
			PluginsManager.NativeFieldInfoPtr__customPlugins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, "_customPlugins");
			PluginsManager.NativeMethodInfoPtr_GetDefaultPlugin_Internal_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, 100664117);
			PluginsManager.NativeMethodInfoPtr_GetCustomPlugin_Public_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, 100664118);
			PluginsManager.NativeMethodInfoPtr_PurgeAll_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluginsManager>.NativeClassPtr, 100664119);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00018D90 File Offset: 0x00016F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123551, XrefRangeEnd = 123791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>() where TPlugOptions : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginsManager.MethodInfoStoreGeneric_GetDefaultPlugin_Internal_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ABSTweenPlugin<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00018DC4 File Offset: 0x00016FC4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 123803, RefRangeEnd = 123812, XrefRangeStart = 123791, XrefRangeEnd = 123803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>() where TPlugin : new() where TPlugOptions : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginsManager.MethodInfoStoreGeneric_GetCustomPlugin_Public_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<TPlugin, T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ABSTweenPlugin<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00018DF8 File Offset: 0x00016FF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123832, RefRangeEnd = 123833, XrefRangeStart = 123812, XrefRangeEnd = 123832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PurgeAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluginsManager.NativeMethodInfoPtr_PurgeAll_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00003125 File Offset: 0x00001325
		public PluginsManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00018E20 File Offset: 0x00017020
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x0000312E File Offset: 0x0000132E
		public unsafe static ITweenPlugin _floatPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__floatPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__floatPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00018E48 File Offset: 0x00017048
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00003140 File Offset: 0x00001340
		public unsafe static ITweenPlugin _doublePlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__doublePlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__doublePlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00018E70 File Offset: 0x00017070
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00003152 File Offset: 0x00001352
		public unsafe static ITweenPlugin _intPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__intPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__intPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00018E98 File Offset: 0x00017098
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x00003164 File Offset: 0x00001364
		public unsafe static ITweenPlugin _uintPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__uintPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__uintPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00018EC0 File Offset: 0x000170C0
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00003176 File Offset: 0x00001376
		public unsafe static ITweenPlugin _longPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__longPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__longPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00018EE8 File Offset: 0x000170E8
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00003188 File Offset: 0x00001388
		public unsafe static ITweenPlugin _ulongPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__ulongPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__ulongPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00018F10 File Offset: 0x00017110
		// (set) Token: 0x060003CC RID: 972 RVA: 0x0000319A File Offset: 0x0000139A
		public unsafe static ITweenPlugin _vector2Plugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__vector2Plugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__vector2Plugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00018F38 File Offset: 0x00017138
		// (set) Token: 0x060003CE RID: 974 RVA: 0x000031AC File Offset: 0x000013AC
		public unsafe static ITweenPlugin _vector3Plugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__vector3Plugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__vector3Plugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00018F60 File Offset: 0x00017160
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x000031BE File Offset: 0x000013BE
		public unsafe static ITweenPlugin _vector4Plugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__vector4Plugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__vector4Plugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00018F88 File Offset: 0x00017188
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x000031D0 File Offset: 0x000013D0
		public unsafe static ITweenPlugin _quaternionPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__quaternionPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__quaternionPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00018FB0 File Offset: 0x000171B0
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x000031E2 File Offset: 0x000013E2
		public unsafe static ITweenPlugin _colorPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__colorPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__colorPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00018FD8 File Offset: 0x000171D8
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x000031F4 File Offset: 0x000013F4
		public unsafe static ITweenPlugin _rectPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__rectPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__rectPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00019000 File Offset: 0x00017200
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00003206 File Offset: 0x00001406
		public unsafe static ITweenPlugin _rectOffsetPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__rectOffsetPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__rectOffsetPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00019028 File Offset: 0x00017228
		// (set) Token: 0x060003DA RID: 986 RVA: 0x00003218 File Offset: 0x00001418
		public unsafe static ITweenPlugin _stringPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__stringPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__stringPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00019050 File Offset: 0x00017250
		// (set) Token: 0x060003DC RID: 988 RVA: 0x0000322A File Offset: 0x0000142A
		public unsafe static ITweenPlugin _vector3ArrayPlugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__vector3ArrayPlugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__vector3ArrayPlugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00019078 File Offset: 0x00017278
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0000323C File Offset: 0x0000143C
		public unsafe static ITweenPlugin _color2Plugin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__color2Plugin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITweenPlugin>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__color2Plugin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060003DF RID: 991 RVA: 0x000190A0 File Offset: 0x000172A0
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x0000324E File Offset: 0x0000144E
		public unsafe static int _MaxCustomPlugins
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__MaxCustomPlugins, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__MaxCustomPlugins, (void*)(&value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x000190BC File Offset: 0x000172BC
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x0000325C File Offset: 0x0000145C
		public unsafe static Dictionary<Type, ITweenPlugin> _customPlugins
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PluginsManager.NativeFieldInfoPtr__customPlugins, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, ITweenPlugin>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PluginsManager.NativeFieldInfoPtr__customPlugins, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeFieldInfoPtr__floatPlugin;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeFieldInfoPtr__doublePlugin;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeFieldInfoPtr__intPlugin;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeFieldInfoPtr__uintPlugin;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeFieldInfoPtr__longPlugin;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeFieldInfoPtr__ulongPlugin;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeFieldInfoPtr__vector2Plugin;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeFieldInfoPtr__vector3Plugin;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeFieldInfoPtr__vector4Plugin;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeFieldInfoPtr__quaternionPlugin;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeFieldInfoPtr__colorPlugin;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeFieldInfoPtr__rectPlugin;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeFieldInfoPtr__rectOffsetPlugin;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeFieldInfoPtr__stringPlugin;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeFieldInfoPtr__vector3ArrayPlugin;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeFieldInfoPtr__color2Plugin;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeFieldInfoPtr__MaxCustomPlugins;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeFieldInfoPtr__customPlugins;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultPlugin_Internal_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomPlugin_Public_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_PurgeAll_Internal_Static_Void_0;

		// Token: 0x020000E4 RID: 228
		private sealed class MethodInfoStoreGeneric_GetDefaultPlugin_Internal_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x04000645 RID: 1605
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PluginsManager.NativeMethodInfoPtr_GetDefaultPlugin_Internal_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<PluginsManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000E5 RID: 229
		private sealed class MethodInfoStoreGeneric_GetCustomPlugin_Public_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0<TPlugin, T1, T2, TPlugOptions>
		{
			// Token: 0x04000646 RID: 1606
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PluginsManager.NativeMethodInfoPtr_GetCustomPlugin_Public_Static_ABSTweenPlugin_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<PluginsManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugin>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}
	}
}
