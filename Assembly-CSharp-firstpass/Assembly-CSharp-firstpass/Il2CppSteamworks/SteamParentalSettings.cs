using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x0200014A RID: 330
	public static class SteamParentalSettings : Object
	{
		// Token: 0x06000D07 RID: 3335 RVA: 0x00040D44 File Offset: 0x0003EF44
		// Note: this type is marked as 'beforefieldinit'.
		static SteamParentalSettings()
		{
			Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamParentalSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr);
			SteamParentalSettings.NativeMethodInfoPtr_BIsParentalLockEnabled_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr, 100664986);
			SteamParentalSettings.NativeMethodInfoPtr_BIsParentalLockLocked_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr, 100664987);
			SteamParentalSettings.NativeMethodInfoPtr_BIsAppBlocked_Public_Static_Boolean_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr, 100664988);
			SteamParentalSettings.NativeMethodInfoPtr_BIsAppInBlockList_Public_Static_Boolean_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr, 100664989);
			SteamParentalSettings.NativeMethodInfoPtr_BIsFeatureBlocked_Public_Static_Boolean_EParentalFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr, 100664990);
			SteamParentalSettings.NativeMethodInfoPtr_BIsFeatureInBlockList_Public_Static_Boolean_EParentalFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParentalSettings>.NativeClassPtr, 100664991);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00040DEC File Offset: 0x0003EFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10551, XrefRangeEnd = 10556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsParentalLockEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParentalSettings.NativeMethodInfoPtr_BIsParentalLockEnabled_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00040E1C File Offset: 0x0003F01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10556, XrefRangeEnd = 10561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsParentalLockLocked()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParentalSettings.NativeMethodInfoPtr_BIsParentalLockLocked_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00040E4C File Offset: 0x0003F04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10561, XrefRangeEnd = 10566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsAppBlocked(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParentalSettings.NativeMethodInfoPtr_BIsAppBlocked_Public_Static_Boolean_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00040E8C File Offset: 0x0003F08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10566, XrefRangeEnd = 10571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsAppInBlockList(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParentalSettings.NativeMethodInfoPtr_BIsAppInBlockList_Public_Static_Boolean_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00040ECC File Offset: 0x0003F0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10571, XrefRangeEnd = 10576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsFeatureBlocked(EParentalFeature eFeature)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eFeature;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParentalSettings.NativeMethodInfoPtr_BIsFeatureBlocked_Public_Static_Boolean_EParentalFeature_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00040F0C File Offset: 0x0003F10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10576, XrefRangeEnd = 10581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsFeatureInBlockList(EParentalFeature eFeature)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eFeature;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParentalSettings.NativeMethodInfoPtr_BIsFeatureInBlockList_Public_Static_Boolean_EParentalFeature_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00006543 File Offset: 0x00004743
		public SteamParentalSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr_BIsParentalLockEnabled_Public_Static_Boolean_0;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr_BIsParentalLockLocked_Public_Static_Boolean_0;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr_BIsAppBlocked_Public_Static_Boolean_AppId_t_0;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr_BIsAppInBlockList_Public_Static_Boolean_AppId_t_0;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr_BIsFeatureBlocked_Public_Static_Boolean_EParentalFeature_0;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeMethodInfoPtr_BIsFeatureInBlockList_Public_Static_Boolean_EParentalFeature_0;
	}
}
