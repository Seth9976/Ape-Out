using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	[Serializable]
	public static class AssetBundleLoadingCache
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000210A File Offset: 0x0000030A
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002116 File Offset: 0x00000316
		public static uint maxBlocksPerFile
		{
			get
			{
				return AssetBundleLoadingCache.get_maxBlocksPerFileDelegateField();
			}
			set
			{
				AssetBundleLoadingCache.set_maxBlocksPerFileDelegateField(value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002123 File Offset: 0x00000323
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0000212F File Offset: 0x0000032F
		public static uint blockCount
		{
			get
			{
				return AssetBundleLoadingCache.get_blockCountDelegateField();
			}
			set
			{
				AssetBundleLoadingCache.set_blockCountDelegateField(value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000213C File Offset: 0x0000033C
		public static uint blockSize
		{
			get
			{
				return AssetBundleLoadingCache.get_blockSizeDelegateField();
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000030D8 File Offset: 0x000012D8
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000030F8 File Offset: 0x000012F8
		public static uint memoryBudgetKB
		{
			get
			{
				return AssetBundleLoadingCache.blockCount * AssetBundleLoadingCache.blockSize;
			}
			set
			{
				uint num = Math.Max(value / AssetBundleLoadingCache.blockSize, 2U);
				uint num2 = Math.Max(AssetBundleLoadingCache.blockCount / 4U, 2U);
				bool flag = num != AssetBundleLoadingCache.blockCount || num2 != AssetBundleLoadingCache.maxBlocksPerFile;
				if (flag)
				{
					AssetBundleLoadingCache.blockCount = num;
					AssetBundleLoadingCache.maxBlocksPerFile = num2;
				}
			}
		}

		// Token: 0x04000031 RID: 49
		public const int kMinAllowedBlockCount = 2;

		// Token: 0x04000032 RID: 50
		public const int kMinAllowedMaxBlocksPerFile = 2;

		// Token: 0x04000033 RID: 51
		private static readonly AssetBundleLoadingCache.get_maxBlocksPerFileDelegate get_maxBlocksPerFileDelegateField = IL2CPP.ResolveICall<AssetBundleLoadingCache.get_maxBlocksPerFileDelegate>("UnityEngine.AssetBundleLoadingCache::get_maxBlocksPerFile");

		// Token: 0x04000034 RID: 52
		private static readonly AssetBundleLoadingCache.set_maxBlocksPerFileDelegate set_maxBlocksPerFileDelegateField = IL2CPP.ResolveICall<AssetBundleLoadingCache.set_maxBlocksPerFileDelegate>("UnityEngine.AssetBundleLoadingCache::set_maxBlocksPerFile");

		// Token: 0x04000035 RID: 53
		private static readonly AssetBundleLoadingCache.get_blockCountDelegate get_blockCountDelegateField = IL2CPP.ResolveICall<AssetBundleLoadingCache.get_blockCountDelegate>("UnityEngine.AssetBundleLoadingCache::get_blockCount");

		// Token: 0x04000036 RID: 54
		private static readonly AssetBundleLoadingCache.set_blockCountDelegate set_blockCountDelegateField = IL2CPP.ResolveICall<AssetBundleLoadingCache.set_blockCountDelegate>("UnityEngine.AssetBundleLoadingCache::set_blockCount");

		// Token: 0x04000037 RID: 55
		private static readonly AssetBundleLoadingCache.get_blockSizeDelegate get_blockSizeDelegateField = IL2CPP.ResolveICall<AssetBundleLoadingCache.get_blockSizeDelegate>("UnityEngine.AssetBundleLoadingCache::get_blockSize");

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x06000098 RID: 152
		private delegate uint get_maxBlocksPerFileDelegate();

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x0600009A RID: 154
		private delegate void set_maxBlocksPerFileDelegate(uint value);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x0600009C RID: 156
		private delegate uint get_blockCountDelegate();

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x0600009E RID: 158
		private delegate void set_blockCountDelegate(uint value);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x060000A0 RID: 160
		private delegate uint get_blockSizeDelegate();
	}
}
