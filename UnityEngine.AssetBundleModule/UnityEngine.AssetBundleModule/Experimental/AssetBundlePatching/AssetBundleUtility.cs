using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Experimental.AssetBundlePatching
{
	// Token: 0x0200000B RID: 11
	public static class AssetBundleUtility
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00002172 File Offset: 0x00000372
		public static void PatchAssetBundles(Il2CppReferenceArray<AssetBundle> bundles, Il2CppStringArray filenames)
		{
			AssetBundleUtility.PatchAssetBundlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(bundles), IL2CPP.Il2CppObjectBaseToPtr(filenames));
		}

		// Token: 0x04000049 RID: 73
		private static readonly AssetBundleUtility.PatchAssetBundlesDelegate PatchAssetBundlesDelegateField = IL2CPP.ResolveICall<AssetBundleUtility.PatchAssetBundlesDelegate>("UnityEngine.Experimental.AssetBundlePatching.AssetBundleUtility::PatchAssetBundles");

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x060000AC RID: 172
		private delegate void PatchAssetBundlesDelegate(IntPtr bundles, IntPtr filenames);
	}
}
