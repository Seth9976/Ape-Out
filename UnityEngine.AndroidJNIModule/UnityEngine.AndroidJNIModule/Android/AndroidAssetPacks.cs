using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Android
{
	// Token: 0x02000018 RID: 24
	public static class AndroidAssetPacks
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000A368 File Offset: 0x00008568
		public static bool coreUnityAssetPacksDownloaded
		{
			get
			{
				return AndroidAssetPacks.CoreUnityAssetPacksDownloaded();
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000A380 File Offset: 0x00008580
		public static string dataPackName
		{
			get
			{
				return AndroidAssetPacks.GetDataPackName();
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000A398 File Offset: 0x00008598
		public static string streamingAssetsPackName
		{
			get
			{
				return AndroidAssetPacks.GetStreamingAssetsPackName();
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002938 File Offset: 0x00000B38
		public static bool CoreUnityAssetPacksDownloaded()
		{
			return AndroidAssetPacks.CoreUnityAssetPacksDownloadedDelegateField();
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000A3B0 File Offset: 0x000085B0
		public static string GetDataPackName()
		{
			IntPtr intPtr = AndroidAssetPacks.GetDataPackNameDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000A3D0 File Offset: 0x000085D0
		public static string GetStreamingAssetsPackName()
		{
			IntPtr intPtr = AndroidAssetPacks.GetStreamingAssetsPackNameDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000A3F0 File Offset: 0x000085F0
		public static Il2CppStringArray GetCoreUnityAssetPackNames()
		{
			IntPtr intPtr = AndroidAssetPacks.GetCoreUnityAssetPackNamesDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002944 File Offset: 0x00000B44
		public static GetAssetPackStateAsyncOperation GetAssetPackStateAsync(Il2CppStringArray assetPackNames)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002951 File Offset: 0x00000B51
		public static void DownloadAssetPackAsync(Il2CppStringArray assetPackNames, Action<AndroidAssetPackInfo> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000A418 File Offset: 0x00008618
		public static DownloadAssetPackAsyncOperation DownloadAssetPackAsync(Il2CppStringArray assetPackNames)
		{
			bool flag = assetPackNames == null || assetPackNames.Length == 0;
			DownloadAssetPackAsyncOperation downloadAssetPackAsyncOperation;
			if (flag)
			{
				downloadAssetPackAsyncOperation = null;
			}
			else
			{
				DownloadAssetPackAsyncOperation downloadAssetPackAsyncOperation2 = new DownloadAssetPackAsyncOperation(assetPackNames);
				AndroidAssetPacks.DownloadAssetPackAsync(assetPackNames, new Action<AndroidAssetPackInfo>(downloadAssetPackAsyncOperation2.OnUpdate));
				downloadAssetPackAsyncOperation = downloadAssetPackAsyncOperation2;
			}
			return downloadAssetPackAsyncOperation;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000295E File Offset: 0x00000B5E
		public static void RequestToUseMobileDataAsync(Action<AndroidAssetPackUseMobileDataRequestResult> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000A45C File Offset: 0x0000865C
		public static RequestToUseMobileDataAsyncOperation RequestToUseMobileDataAsync()
		{
			RequestToUseMobileDataAsyncOperation requestToUseMobileDataAsyncOperation = new RequestToUseMobileDataAsyncOperation();
			AndroidAssetPacks.RequestToUseMobileDataAsync(new Action<AndroidAssetPackUseMobileDataRequestResult>(requestToUseMobileDataAsyncOperation.OnResult));
			return requestToUseMobileDataAsyncOperation;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000296B File Offset: 0x00000B6B
		public static string GetAssetPackPath(string assetPackName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002978 File Offset: 0x00000B78
		public static void CancelAssetPackDownload(Il2CppStringArray assetPackNames)
		{
			AndroidAssetPacks.GetAssetPackManager().Call<string>("cancelAssetPackDownloads", assetPackNames);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000298C File Offset: 0x00000B8C
		public static void RemoveAssetPack(string assetPackName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002999 File Offset: 0x00000B99
		public static AndroidJavaObject GetAssetPackManager()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000180 RID: 384
		private static readonly AndroidAssetPacks.CoreUnityAssetPacksDownloadedDelegate CoreUnityAssetPacksDownloadedDelegateField = IL2CPP.ResolveICall<AndroidAssetPacks.CoreUnityAssetPacksDownloadedDelegate>("UnityEngine.Android.AndroidAssetPacks::CoreUnityAssetPacksDownloaded");

		// Token: 0x04000181 RID: 385
		private static readonly AndroidAssetPacks.GetDataPackNameDelegate GetDataPackNameDelegateField = IL2CPP.ResolveICall<AndroidAssetPacks.GetDataPackNameDelegate>("UnityEngine.Android.AndroidAssetPacks::GetDataPackName");

		// Token: 0x04000182 RID: 386
		private static readonly AndroidAssetPacks.GetStreamingAssetsPackNameDelegate GetStreamingAssetsPackNameDelegateField = IL2CPP.ResolveICall<AndroidAssetPacks.GetStreamingAssetsPackNameDelegate>("UnityEngine.Android.AndroidAssetPacks::GetStreamingAssetsPackName");

		// Token: 0x04000183 RID: 387
		private static readonly AndroidAssetPacks.GetCoreUnityAssetPackNamesDelegate GetCoreUnityAssetPackNamesDelegateField = IL2CPP.ResolveICall<AndroidAssetPacks.GetCoreUnityAssetPackNamesDelegate>("UnityEngine.Android.AndroidAssetPacks::GetCoreUnityAssetPackNames");

		// Token: 0x02000072 RID: 114
		public class AssetPackManagerDownloadStatusCallback : AndroidJavaProxy
		{
		}

		// Token: 0x02000073 RID: 115
		public class AssetPackManagerMobileDataConfirmationCallback : AndroidJavaProxy
		{
		}

		// Token: 0x02000074 RID: 116
		public class AssetPackManagerStatusQueryCallback : AndroidJavaProxy
		{
		}

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x0600029B RID: 667
		private delegate bool CoreUnityAssetPacksDownloadedDelegate();

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x0600029D RID: 669
		private delegate IntPtr GetDataPackNameDelegate();

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x0600029F RID: 671
		private delegate IntPtr GetStreamingAssetsPackNameDelegate();

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060002A1 RID: 673
		private delegate IntPtr GetCoreUnityAssetPackNamesDelegate();
	}
}
