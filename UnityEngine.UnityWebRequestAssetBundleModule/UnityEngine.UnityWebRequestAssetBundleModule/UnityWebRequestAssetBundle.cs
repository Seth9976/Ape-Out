using System;
using System.Runtime.InteropServices;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000002 RID: 2
	public static class UnityWebRequestAssetBundle
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002110 File Offset: 0x00000310
		public static UnityWebRequest GetAssetBundle(string uri)
		{
			return UnityWebRequestAssetBundle.GetAssetBundle(uri, 0U);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000212C File Offset: 0x0000032C
		public static UnityWebRequest GetAssetBundle(Uri uri)
		{
			return UnityWebRequestAssetBundle.GetAssetBundle(uri, 0U);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002148 File Offset: 0x00000348
		public static UnityWebRequest GetAssetBundle(string uri, uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri, crc), null);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002170 File Offset: 0x00000370
		public static UnityWebRequest GetAssetBundle(Uri uri, uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri.AbsoluteUri, crc), null);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000219C File Offset: 0x0000039C
		public static UnityWebRequest GetAssetBundle(string uri, uint version, uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri, version, crc), null);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021C4 File Offset: 0x000003C4
		public static UnityWebRequest GetAssetBundle(Uri uri, uint version, uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri.AbsoluteUri, version, crc), null);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000021F4 File Offset: 0x000003F4
		public static UnityWebRequest GetAssetBundle(string uri, Hash128 hash, [Optional] uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri, hash, crc), null);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000221C File Offset: 0x0000041C
		public static UnityWebRequest GetAssetBundle(Uri uri, Hash128 hash, [Optional] uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri.AbsoluteUri, hash, crc), null);
		}
	}
}
