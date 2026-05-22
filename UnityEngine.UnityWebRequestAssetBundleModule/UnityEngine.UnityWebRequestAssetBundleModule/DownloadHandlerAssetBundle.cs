using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000003 RID: 3
	public sealed class DownloadHandlerAssetBundle : DownloadHandler
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		public static IntPtr Create(DownloadHandlerAssetBundle obj, string url, uint crc)
		{
			return DownloadHandlerAssetBundle.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), IL2CPP.ManagedStringToIl2Cpp(url), crc);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002069 File Offset: 0x00000269
		public static IntPtr CreateCached(DownloadHandlerAssetBundle obj, string url, string name, Hash128 hash, uint crc)
		{
			return DownloadHandlerAssetBundle.CreateCached_Injected(obj, url, name, ref hash, crc);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002077 File Offset: 0x00000277
		public void InternalCreateAssetBundle(string url, uint crc)
		{
			base.m_Ptr = DownloadHandlerAssetBundle.Create(this, url, crc);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002088 File Offset: 0x00000288
		public void InternalCreateAssetBundleCached(string url, string name, Hash128 hash, uint crc)
		{
			base.m_Ptr = DownloadHandlerAssetBundle.CreateCached(this, url, name, hash, crc);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000209C File Offset: 0x0000029C
		public override Il2CppStructArray<byte> GetData()
		{
			throw new NotSupportedException("Raw data access is not supported for asset bundles");
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020A9 File Offset: 0x000002A9
		public override string GetText()
		{
			throw new NotSupportedException("String access is not supported for asset bundles");
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000022B4 File Offset: 0x000004B4
		public AssetBundle assetBundle
		{
			get
			{
				IntPtr intPtr = DownloadHandlerAssetBundle.get_assetBundleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000020B6 File Offset: 0x000002B6
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000020C8 File Offset: 0x000002C8
		public bool autoLoadAssetBundle
		{
			get
			{
				return DownloadHandlerAssetBundle.get_autoLoadAssetBundleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DownloadHandlerAssetBundle.set_autoLoadAssetBundleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000020DB File Offset: 0x000002DB
		public bool isDownloadComplete
		{
			get
			{
				return DownloadHandlerAssetBundle.get_isDownloadCompleteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000022E0 File Offset: 0x000004E0
		public static AssetBundle GetContent(UnityWebRequest www)
		{
			return DownloadHandler.GetCheckedDownloader<DownloadHandlerAssetBundle>(www).assetBundle;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020ED File Offset: 0x000002ED
		public static IntPtr CreateCached_Injected(DownloadHandlerAssetBundle obj, string url, string name, ref Hash128 hash, uint crc)
		{
			return DownloadHandlerAssetBundle.CreateCached_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), IL2CPP.ManagedStringToIl2Cpp(url), IL2CPP.ManagedStringToIl2Cpp(name), ref hash, crc);
		}

		// Token: 0x04000001 RID: 1
		private static readonly DownloadHandlerAssetBundle.CreateDelegate CreateDelegateField = IL2CPP.ResolveICall<DownloadHandlerAssetBundle.CreateDelegate>("UnityEngine.Networking.DownloadHandlerAssetBundle::Create");

		// Token: 0x04000002 RID: 2
		private static readonly DownloadHandlerAssetBundle.get_assetBundleDelegate get_assetBundleDelegateField = IL2CPP.ResolveICall<DownloadHandlerAssetBundle.get_assetBundleDelegate>("UnityEngine.Networking.DownloadHandlerAssetBundle::get_assetBundle");

		// Token: 0x04000003 RID: 3
		private static readonly DownloadHandlerAssetBundle.get_autoLoadAssetBundleDelegate get_autoLoadAssetBundleDelegateField = IL2CPP.ResolveICall<DownloadHandlerAssetBundle.get_autoLoadAssetBundleDelegate>("UnityEngine.Networking.DownloadHandlerAssetBundle::get_autoLoadAssetBundle");

		// Token: 0x04000004 RID: 4
		private static readonly DownloadHandlerAssetBundle.set_autoLoadAssetBundleDelegate set_autoLoadAssetBundleDelegateField = IL2CPP.ResolveICall<DownloadHandlerAssetBundle.set_autoLoadAssetBundleDelegate>("UnityEngine.Networking.DownloadHandlerAssetBundle::set_autoLoadAssetBundle");

		// Token: 0x04000005 RID: 5
		private static readonly DownloadHandlerAssetBundle.get_isDownloadCompleteDelegate get_isDownloadCompleteDelegateField = IL2CPP.ResolveICall<DownloadHandlerAssetBundle.get_isDownloadCompleteDelegate>("UnityEngine.Networking.DownloadHandlerAssetBundle::get_isDownloadComplete");

		// Token: 0x04000006 RID: 6
		private static readonly DownloadHandlerAssetBundle.CreateCached_InjectedDelegate CreateCached_InjectedDelegateField = IL2CPP.ResolveICall<DownloadHandlerAssetBundle.CreateCached_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerAssetBundle::CreateCached_Injected");

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x06000017 RID: 23
		private delegate IntPtr CreateDelegate(IntPtr obj, IntPtr url, uint crc);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000019 RID: 25
		private delegate IntPtr get_assetBundleDelegate(IntPtr @this);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x0600001B RID: 27
		private delegate bool get_autoLoadAssetBundleDelegate(IntPtr @this);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x0600001D RID: 29
		private delegate void set_autoLoadAssetBundleDelegate(IntPtr @this, bool value);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600001F RID: 31
		private delegate bool get_isDownloadCompleteDelegate(IntPtr @this);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000021 RID: 33
		private delegate IntPtr CreateCached_InjectedDelegate(IntPtr obj, IntPtr url, IntPtr name, IntPtr hash, uint crc);
	}
}
