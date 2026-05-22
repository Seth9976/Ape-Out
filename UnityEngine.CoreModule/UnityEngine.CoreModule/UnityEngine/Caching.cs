using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x020001FC RID: 508
	public sealed class Caching
	{
		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600201F RID: 8223 RVA: 0x00010AF4 File Offset: 0x0000ECF4
		// (set) Token: 0x06002020 RID: 8224 RVA: 0x00010B00 File Offset: 0x0000ED00
		public static bool compressionEnabled
		{
			get
			{
				return Caching.get_compressionEnabledDelegateField();
			}
			set
			{
				Caching.set_compressionEnabledDelegateField(value);
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06002021 RID: 8225 RVA: 0x00010B0D File Offset: 0x0000ED0D
		public static bool ready
		{
			get
			{
				return Caching.get_readyDelegateField();
			}
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00010B19 File Offset: 0x0000ED19
		public static bool ClearCache()
		{
			return Caching.ClearCacheDelegateField();
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00074310 File Offset: 0x00072510
		public static bool ClearCache(int expiration)
		{
			return Caching.ClearCache_Int(expiration);
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00010B25 File Offset: 0x0000ED25
		public static bool ClearCache_Int(int expiration)
		{
			return Caching.ClearCache_IntDelegateField(expiration);
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x00074328 File Offset: 0x00072528
		public static bool ClearCachedVersion(string assetBundleName, Hash128 hash)
		{
			bool flag = String.IsNullOrEmpty(assetBundleName);
			if (flag)
			{
				throw new ArgumentException("Input AssetBundle name cannot be null or empty.");
			}
			return Caching.ClearCachedVersionInternal(assetBundleName, hash);
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x00010B32 File Offset: 0x0000ED32
		public static bool ClearCachedVersionInternal(string assetBundleName, Hash128 hash)
		{
			return Caching.ClearCachedVersionInternal_Injected(assetBundleName, ref hash);
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00074358 File Offset: 0x00072558
		public static bool ClearOtherCachedVersions(string assetBundleName, Hash128 hash)
		{
			bool flag = String.IsNullOrEmpty(assetBundleName);
			if (flag)
			{
				throw new ArgumentException("Input AssetBundle name cannot be null or empty.");
			}
			return Caching.ClearCachedVersions(assetBundleName, hash, true);
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00074388 File Offset: 0x00072588
		public static bool ClearAllCachedVersions(string assetBundleName)
		{
			bool flag = String.IsNullOrEmpty(assetBundleName);
			if (flag)
			{
				throw new ArgumentException("Input AssetBundle name cannot be null or empty.");
			}
			return Caching.ClearCachedVersions(assetBundleName, default(Hash128), false);
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x00010B3C File Offset: 0x0000ED3C
		public static bool ClearCachedVersions(string assetBundleName, Hash128 hash, bool keepInputVersion)
		{
			return Caching.ClearCachedVersions_Injected(assetBundleName, ref hash, keepInputVersion);
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x000743C0 File Offset: 0x000725C0
		public static Il2CppStructArray<Hash128> GetCachedVersions(string assetBundleName)
		{
			IntPtr intPtr = Caching.GetCachedVersionsDelegateField(IL2CPP.ManagedStringToIl2Cpp(assetBundleName));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Hash128>>(intPtr2) : null;
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x000743EC File Offset: 0x000725EC
		public static void GetCachedVersions(string assetBundleName, List<Hash128> outCachedVersions)
		{
			bool flag = String.IsNullOrEmpty(assetBundleName);
			if (flag)
			{
				throw new ArgumentException("Input AssetBundle name cannot be null or empty.");
			}
			bool flag2 = outCachedVersions == null;
			if (flag2)
			{
				throw new ArgumentNullException("Input outCachedVersions cannot be null.");
			}
			outCachedVersions.AddRange(Caching.GetCachedVersions(assetBundleName));
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00074430 File Offset: 0x00072630
		public static bool IsVersionCached(string url, int version)
		{
			return Caching.IsVersionCached(url, new Hash128(0U, 0U, 0U, (uint)version));
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00074454 File Offset: 0x00072654
		public static bool IsVersionCached(string url, Hash128 hash)
		{
			bool flag = String.IsNullOrEmpty(url);
			if (flag)
			{
				throw new ArgumentException("Input AssetBundle url cannot be null or empty.");
			}
			return Caching.IsVersionCached(url, "", hash);
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x00010B47 File Offset: 0x0000ED47
		public static bool IsVersionCached(string url, string assetBundleName, Hash128 hash)
		{
			return Caching.IsVersionCached_Injected(url, assetBundleName, ref hash);
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00074488 File Offset: 0x00072688
		public static bool MarkAsUsed(string url, int version)
		{
			return Caching.MarkAsUsed(url, new Hash128(0U, 0U, 0U, (uint)version));
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x000744AC File Offset: 0x000726AC
		public static bool MarkAsUsed(string url, Hash128 hash)
		{
			bool flag = String.IsNullOrEmpty(url);
			if (flag)
			{
				throw new ArgumentException("Input AssetBundle url cannot be null or empty.");
			}
			return Caching.MarkAsUsed(url, "", hash);
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00010B52 File Offset: 0x0000ED52
		public static bool MarkAsUsed(string url, string assetBundleName, Hash128 hash)
		{
			return Caching.MarkAsUsed_Injected(url, assetBundleName, ref hash);
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x000744E0 File Offset: 0x000726E0
		public static int GetVersionFromCache(string url)
		{
			return -1;
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x000744F4 File Offset: 0x000726F4
		public static int spaceUsed
		{
			get
			{
				return (int)Caching.spaceOccupied;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x00010B5D File Offset: 0x0000ED5D
		public static long spaceOccupied
		{
			get
			{
				return Caching.get_spaceOccupiedDelegateField();
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x0007450C File Offset: 0x0007270C
		public static int spaceAvailable
		{
			get
			{
				return (int)Caching.spaceFree;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x00010B69 File Offset: 0x0000ED69
		public static long spaceFree
		{
			get
			{
				return Caching.get_spaceFreeDelegateField();
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x00010B75 File Offset: 0x0000ED75
		// (set) Token: 0x06002038 RID: 8248 RVA: 0x00010B81 File Offset: 0x0000ED81
		public static long maximumAvailableDiskSpace
		{
			get
			{
				return Caching.get_maximumAvailableDiskSpaceDelegateField();
			}
			set
			{
				Caching.set_maximumAvailableDiskSpaceDelegateField(value);
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x00010B8E File Offset: 0x0000ED8E
		// (set) Token: 0x0600203A RID: 8250 RVA: 0x00010B9A File Offset: 0x0000ED9A
		public static int expirationDelay
		{
			get
			{
				return Caching.get_expirationDelayDelegateField();
			}
			set
			{
				Caching.set_expirationDelayDelegateField(value);
			}
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00010BA7 File Offset: 0x0000EDA7
		public static void GetAllCachePaths(List<string> cachePaths)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x00010BB4 File Offset: 0x0000EDB4
		public static int cacheCount
		{
			get
			{
				return Caching.get_cacheCountDelegateField();
			}
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00074524 File Offset: 0x00072724
		public static bool CleanCache()
		{
			return Caching.ClearCache();
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x00010BC0 File Offset: 0x0000EDC0
		public static bool ClearCachedVersionInternal_Injected(string assetBundleName, ref Hash128 hash)
		{
			return Caching.ClearCachedVersionInternal_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(assetBundleName), ref hash);
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x00010BD3 File Offset: 0x0000EDD3
		public static bool ClearCachedVersions_Injected(string assetBundleName, ref Hash128 hash, bool keepInputVersion)
		{
			return Caching.ClearCachedVersions_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(assetBundleName), ref hash, keepInputVersion);
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00010BE7 File Offset: 0x0000EDE7
		public static bool IsVersionCached_Injected(string url, string assetBundleName, ref Hash128 hash)
		{
			return Caching.IsVersionCached_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(url), IL2CPP.ManagedStringToIl2Cpp(assetBundleName), ref hash);
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x00010C00 File Offset: 0x0000EE00
		public static bool MarkAsUsed_Injected(string url, string assetBundleName, ref Hash128 hash)
		{
			return Caching.MarkAsUsed_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(url), IL2CPP.ManagedStringToIl2Cpp(assetBundleName), ref hash);
		}

		// Token: 0x04001A59 RID: 6745
		private static readonly Caching.get_compressionEnabledDelegate get_compressionEnabledDelegateField = IL2CPP.ResolveICall<Caching.get_compressionEnabledDelegate>("UnityEngine.Caching::get_compressionEnabled");

		// Token: 0x04001A5A RID: 6746
		private static readonly Caching.set_compressionEnabledDelegate set_compressionEnabledDelegateField = IL2CPP.ResolveICall<Caching.set_compressionEnabledDelegate>("UnityEngine.Caching::set_compressionEnabled");

		// Token: 0x04001A5B RID: 6747
		private static readonly Caching.get_readyDelegate get_readyDelegateField = IL2CPP.ResolveICall<Caching.get_readyDelegate>("UnityEngine.Caching::get_ready");

		// Token: 0x04001A5C RID: 6748
		private static readonly Caching.ClearCacheDelegate ClearCacheDelegateField = IL2CPP.ResolveICall<Caching.ClearCacheDelegate>("UnityEngine.Caching::ClearCache");

		// Token: 0x04001A5D RID: 6749
		private static readonly Caching.ClearCache_IntDelegate ClearCache_IntDelegateField = IL2CPP.ResolveICall<Caching.ClearCache_IntDelegate>("UnityEngine.Caching::ClearCache_Int");

		// Token: 0x04001A5E RID: 6750
		private static readonly Caching.GetCachedVersionsDelegate GetCachedVersionsDelegateField = IL2CPP.ResolveICall<Caching.GetCachedVersionsDelegate>("UnityEngine.Caching::GetCachedVersions");

		// Token: 0x04001A5F RID: 6751
		private static readonly Caching.get_spaceOccupiedDelegate get_spaceOccupiedDelegateField = IL2CPP.ResolveICall<Caching.get_spaceOccupiedDelegate>("UnityEngine.Caching::get_spaceOccupied");

		// Token: 0x04001A60 RID: 6752
		private static readonly Caching.get_spaceFreeDelegate get_spaceFreeDelegateField = IL2CPP.ResolveICall<Caching.get_spaceFreeDelegate>("UnityEngine.Caching::get_spaceFree");

		// Token: 0x04001A61 RID: 6753
		private static readonly Caching.get_maximumAvailableDiskSpaceDelegate get_maximumAvailableDiskSpaceDelegateField = IL2CPP.ResolveICall<Caching.get_maximumAvailableDiskSpaceDelegate>("UnityEngine.Caching::get_maximumAvailableDiskSpace");

		// Token: 0x04001A62 RID: 6754
		private static readonly Caching.set_maximumAvailableDiskSpaceDelegate set_maximumAvailableDiskSpaceDelegateField = IL2CPP.ResolveICall<Caching.set_maximumAvailableDiskSpaceDelegate>("UnityEngine.Caching::set_maximumAvailableDiskSpace");

		// Token: 0x04001A63 RID: 6755
		private static readonly Caching.get_expirationDelayDelegate get_expirationDelayDelegateField = IL2CPP.ResolveICall<Caching.get_expirationDelayDelegate>("UnityEngine.Caching::get_expirationDelay");

		// Token: 0x04001A64 RID: 6756
		private static readonly Caching.set_expirationDelayDelegate set_expirationDelayDelegateField = IL2CPP.ResolveICall<Caching.set_expirationDelayDelegate>("UnityEngine.Caching::set_expirationDelay");

		// Token: 0x04001A65 RID: 6757
		private static readonly Caching.get_cacheCountDelegate get_cacheCountDelegateField = IL2CPP.ResolveICall<Caching.get_cacheCountDelegate>("UnityEngine.Caching::get_cacheCount");

		// Token: 0x04001A66 RID: 6758
		private static readonly Caching.ClearCachedVersionInternal_InjectedDelegate ClearCachedVersionInternal_InjectedDelegateField = IL2CPP.ResolveICall<Caching.ClearCachedVersionInternal_InjectedDelegate>("UnityEngine.Caching::ClearCachedVersionInternal_Injected");

		// Token: 0x04001A67 RID: 6759
		private static readonly Caching.ClearCachedVersions_InjectedDelegate ClearCachedVersions_InjectedDelegateField = IL2CPP.ResolveICall<Caching.ClearCachedVersions_InjectedDelegate>("UnityEngine.Caching::ClearCachedVersions_Injected");

		// Token: 0x04001A68 RID: 6760
		private static readonly Caching.IsVersionCached_InjectedDelegate IsVersionCached_InjectedDelegateField = IL2CPP.ResolveICall<Caching.IsVersionCached_InjectedDelegate>("UnityEngine.Caching::IsVersionCached_Injected");

		// Token: 0x04001A69 RID: 6761
		private static readonly Caching.MarkAsUsed_InjectedDelegate MarkAsUsed_InjectedDelegateField = IL2CPP.ResolveICall<Caching.MarkAsUsed_InjectedDelegate>("UnityEngine.Caching::MarkAsUsed_Injected");

		// Token: 0x02000AC0 RID: 2752
		// (Invoke) Token: 0x060033E4 RID: 13284
		private delegate bool get_compressionEnabledDelegate();

		// Token: 0x02000AC1 RID: 2753
		// (Invoke) Token: 0x060033E6 RID: 13286
		private delegate void set_compressionEnabledDelegate(bool value);

		// Token: 0x02000AC2 RID: 2754
		// (Invoke) Token: 0x060033E8 RID: 13288
		private delegate bool get_readyDelegate();

		// Token: 0x02000AC3 RID: 2755
		// (Invoke) Token: 0x060033EA RID: 13290
		private delegate bool ClearCacheDelegate();

		// Token: 0x02000AC4 RID: 2756
		// (Invoke) Token: 0x060033EC RID: 13292
		private delegate bool ClearCache_IntDelegate(int expiration);

		// Token: 0x02000AC5 RID: 2757
		// (Invoke) Token: 0x060033EE RID: 13294
		private delegate IntPtr GetCachedVersionsDelegate(IntPtr assetBundleName);

		// Token: 0x02000AC6 RID: 2758
		// (Invoke) Token: 0x060033F0 RID: 13296
		private delegate long get_spaceOccupiedDelegate();

		// Token: 0x02000AC7 RID: 2759
		// (Invoke) Token: 0x060033F2 RID: 13298
		private delegate long get_spaceFreeDelegate();

		// Token: 0x02000AC8 RID: 2760
		// (Invoke) Token: 0x060033F4 RID: 13300
		private delegate long get_maximumAvailableDiskSpaceDelegate();

		// Token: 0x02000AC9 RID: 2761
		// (Invoke) Token: 0x060033F6 RID: 13302
		private delegate void set_maximumAvailableDiskSpaceDelegate(long value);

		// Token: 0x02000ACA RID: 2762
		// (Invoke) Token: 0x060033F8 RID: 13304
		private delegate int get_expirationDelayDelegate();

		// Token: 0x02000ACB RID: 2763
		// (Invoke) Token: 0x060033FA RID: 13306
		private delegate void set_expirationDelayDelegate(int value);

		// Token: 0x02000ACC RID: 2764
		// (Invoke) Token: 0x060033FC RID: 13308
		private delegate int get_cacheCountDelegate();

		// Token: 0x02000ACD RID: 2765
		// (Invoke) Token: 0x060033FE RID: 13310
		private delegate bool ClearCachedVersionInternal_InjectedDelegate(IntPtr assetBundleName, IntPtr hash);

		// Token: 0x02000ACE RID: 2766
		// (Invoke) Token: 0x06003400 RID: 13312
		private delegate bool ClearCachedVersions_InjectedDelegate(IntPtr assetBundleName, IntPtr hash, bool keepInputVersion);

		// Token: 0x02000ACF RID: 2767
		// (Invoke) Token: 0x06003402 RID: 13314
		private delegate bool IsVersionCached_InjectedDelegate(IntPtr url, IntPtr assetBundleName, IntPtr hash);

		// Token: 0x02000AD0 RID: 2768
		// (Invoke) Token: 0x06003404 RID: 13316
		private delegate bool MarkAsUsed_InjectedDelegate(IntPtr url, IntPtr assetBundleName, IntPtr hash);
	}
}
