using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public class AssetBundleManifest : Object
	{
		// Token: 0x06000060 RID: 96 RVA: 0x000031A4 File Offset: 0x000013A4
		public Il2CppStringArray GetAllAssetBundles()
		{
			IntPtr intPtr = AssetBundleManifest.GetAllAssetBundlesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000031D0 File Offset: 0x000013D0
		public Il2CppStringArray GetAllAssetBundlesWithVariant()
		{
			IntPtr intPtr = AssetBundleManifest.GetAllAssetBundlesWithVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000031FC File Offset: 0x000013FC
		public Hash128 GetAssetBundleHash(string assetBundleName)
		{
			Hash128 hash;
			this.GetAssetBundleHash_Injected(assetBundleName, out hash);
			return hash;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003214 File Offset: 0x00001414
		public Il2CppStringArray GetDirectDependencies(string assetBundleName)
		{
			IntPtr intPtr = AssetBundleManifest.GetDirectDependenciesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(assetBundleName));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003248 File Offset: 0x00001448
		public Il2CppStringArray GetAllDependencies(string assetBundleName)
		{
			IntPtr intPtr = AssetBundleManifest.GetAllDependenciesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(assetBundleName));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002148 File Offset: 0x00000348
		public void GetAssetBundleHash_Injected(string assetBundleName, out Hash128 ret)
		{
			AssetBundleManifest.GetAssetBundleHash_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(assetBundleName), out ret);
		}

		// Token: 0x04000038 RID: 56
		private static readonly AssetBundleManifest.GetAllAssetBundlesDelegate GetAllAssetBundlesDelegateField = IL2CPP.ResolveICall<AssetBundleManifest.GetAllAssetBundlesDelegate>("UnityEngine.AssetBundleManifest::GetAllAssetBundles");

		// Token: 0x04000039 RID: 57
		private static readonly AssetBundleManifest.GetAllAssetBundlesWithVariantDelegate GetAllAssetBundlesWithVariantDelegateField = IL2CPP.ResolveICall<AssetBundleManifest.GetAllAssetBundlesWithVariantDelegate>("UnityEngine.AssetBundleManifest::GetAllAssetBundlesWithVariant");

		// Token: 0x0400003A RID: 58
		private static readonly AssetBundleManifest.GetDirectDependenciesDelegate GetDirectDependenciesDelegateField = IL2CPP.ResolveICall<AssetBundleManifest.GetDirectDependenciesDelegate>("UnityEngine.AssetBundleManifest::GetDirectDependencies");

		// Token: 0x0400003B RID: 59
		private static readonly AssetBundleManifest.GetAllDependenciesDelegate GetAllDependenciesDelegateField = IL2CPP.ResolveICall<AssetBundleManifest.GetAllDependenciesDelegate>("UnityEngine.AssetBundleManifest::GetAllDependencies");

		// Token: 0x0400003C RID: 60
		private static readonly AssetBundleManifest.GetAssetBundleHash_InjectedDelegate GetAssetBundleHash_InjectedDelegateField = IL2CPP.ResolveICall<AssetBundleManifest.GetAssetBundleHash_InjectedDelegate>("UnityEngine.AssetBundleManifest::GetAssetBundleHash_Injected");

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x060000A2 RID: 162
		private delegate IntPtr GetAllAssetBundlesDelegate(IntPtr @this);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x060000A4 RID: 164
		private delegate IntPtr GetAllAssetBundlesWithVariantDelegate(IntPtr @this);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x060000A6 RID: 166
		private delegate IntPtr GetDirectDependenciesDelegate(IntPtr @this, IntPtr assetBundleName);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x060000A8 RID: 168
		private delegate IntPtr GetAllDependenciesDelegate(IntPtr @this, IntPtr assetBundleName);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x060000AA RID: 170
		private delegate void GetAssetBundleHash_InjectedDelegate(IntPtr @this, IntPtr assetBundleName, [Out] IntPtr ret);
	}
}
