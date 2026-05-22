using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200001A RID: 26
	public static class Version : Object
	{
		// Token: 0x06000114 RID: 276 RVA: 0x0001153C File Offset: 0x0000F73C
		// Note: this type is marked as 'beforefieldinit'.
		static Version()
		{
			Il2CppClassPointerStore<Version>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "Version");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Version>.NativeClassPtr);
			Version.NativeFieldInfoPtr_SteamworksNETVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "SteamworksNETVersion");
			Version.NativeFieldInfoPtr_SteamworksSDKVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "SteamworksSDKVersion");
			Version.NativeFieldInfoPtr_SteamAPIDLLVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "SteamAPIDLLVersion");
			Version.NativeFieldInfoPtr_SteamAPIDLLSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "SteamAPIDLLSize");
			Version.NativeFieldInfoPtr_SteamAPI64DLLSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "SteamAPI64DLLSize");
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002846 File Offset: 0x00000A46
		public Version(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000115D0 File Offset: 0x0000F7D0
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0000284F File Offset: 0x00000A4F
		public unsafe static string SteamworksNETVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_SteamworksNETVersion, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_SteamworksNETVersion, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000115F0 File Offset: 0x0000F7F0
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002861 File Offset: 0x00000A61
		public unsafe static string SteamworksSDKVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_SteamworksSDKVersion, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_SteamworksSDKVersion, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00011610 File Offset: 0x0000F810
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002873 File Offset: 0x00000A73
		public unsafe static string SteamAPIDLLVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_SteamAPIDLLVersion, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_SteamAPIDLLVersion, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00011630 File Offset: 0x0000F830
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002885 File Offset: 0x00000A85
		public unsafe static int SteamAPIDLLSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_SteamAPIDLLSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_SteamAPIDLLSize, (void*)(&value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0001164C File Offset: 0x0000F84C
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002893 File Offset: 0x00000A93
		public unsafe static int SteamAPI64DLLSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_SteamAPI64DLLSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_SteamAPI64DLLSize, (void*)(&value));
			}
		}

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_SteamworksNETVersion;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_SteamworksSDKVersion;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_SteamAPIDLLVersion;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_SteamAPIDLLSize;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_SteamAPI64DLLSize;
	}
}
