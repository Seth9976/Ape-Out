using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000134 RID: 308
	public static class SteamAppList : Object
	{
		// Token: 0x06000A32 RID: 2610 RVA: 0x0003095C File Offset: 0x0002EB5C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAppList()
		{
			Il2CppClassPointerStore<SteamAppList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamAppList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAppList>.NativeClassPtr);
			SteamAppList.NativeMethodInfoPtr_GetNumInstalledApps_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppList>.NativeClassPtr, 100664305);
			SteamAppList.NativeMethodInfoPtr_GetInstalledApps_Public_Static_UInt32_Il2CppStructArray_1_AppId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppList>.NativeClassPtr, 100664306);
			SteamAppList.NativeMethodInfoPtr_GetAppName_Public_Static_Int32_AppId_t_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppList>.NativeClassPtr, 100664307);
			SteamAppList.NativeMethodInfoPtr_GetAppInstallDir_Public_Static_Int32_AppId_t_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppList>.NativeClassPtr, 100664308);
			SteamAppList.NativeMethodInfoPtr_GetAppBuildId_Public_Static_Int32_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppList>.NativeClassPtr, 100664309);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x000309F0 File Offset: 0x0002EBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5459, XrefRangeEnd = 5464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetNumInstalledApps()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAppList.NativeMethodInfoPtr_GetNumInstalledApps_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00030A20 File Offset: 0x0002EC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5464, XrefRangeEnd = 5469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetInstalledApps(Il2CppStructArray<AppId_t> pvecAppID, uint unMaxAppIDs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pvecAppID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unMaxAppIDs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAppList.NativeMethodInfoPtr_GetInstalledApps_Public_Static_UInt32_Il2CppStructArray_1_AppId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00030A70 File Offset: 0x0002EC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5469, XrefRangeEnd = 5485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAppName(AppId_t nAppID, out string pchName, int cchNameMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchNameMax;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamAppList.NativeMethodInfoPtr_GetAppName_Public_Static_Int32_AppId_t_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00030AD8 File Offset: 0x0002ECD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5485, XrefRangeEnd = 5501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAppInstallDir(AppId_t nAppID, out string pchDirectory, int cchNameMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchNameMax;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamAppList.NativeMethodInfoPtr_GetAppInstallDir_Public_Static_Int32_AppId_t_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchDirectory = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00030B40 File Offset: 0x0002ED40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5501, XrefRangeEnd = 5506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAppBuildId(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAppList.NativeMethodInfoPtr_GetAppBuildId_Public_Static_Int32_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0000647D File Offset: 0x0000467D
		public SteamAppList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_GetNumInstalledApps_Public_Static_UInt32_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_GetInstalledApps_Public_Static_UInt32_Il2CppStructArray_1_AppId_t_UInt32_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_GetAppName_Public_Static_Int32_AppId_t_byref_String_Int32_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_GetAppInstallDir_Public_Static_Int32_AppId_t_byref_String_Int32_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_GetAppBuildId_Public_Static_Int32_AppId_t_0;
	}
}
