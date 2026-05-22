using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public class AssetBundleCreateRequest : AsyncOperation
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00002DAC File Offset: 0x00000FAC
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleCreateRequest()
		{
			Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundleCreateRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr);
			AssetBundleCreateRequest.get_assetBundleDelegateField = IL2CPP.ResolveICall<AssetBundleCreateRequest.get_assetBundleDelegate>("UnityEngine.AssetBundleCreateRequest::get_assetBundle");
			AssetBundleCreateRequest.SetEnableCompatibilityChecksDelegateField = IL2CPP.ResolveICall<AssetBundleCreateRequest.SetEnableCompatibilityChecksDelegate>("UnityEngine.AssetBundleCreateRequest::SetEnableCompatibilityChecks");
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000020AD File Offset: 0x000002AD
		public AssetBundleCreateRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002DFC File Offset: 0x00000FFC
		public AssetBundle assetBundle
		{
			get
			{
				IntPtr intPtr = AssetBundleCreateRequest.get_assetBundleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000020B6 File Offset: 0x000002B6
		public void SetEnableCompatibilityChecks(bool set)
		{
			AssetBundleCreateRequest.SetEnableCompatibilityChecksDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), set);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000020C9 File Offset: 0x000002C9
		public void DisableCompatibilityChecks()
		{
			this.SetEnableCompatibilityChecks(false);
		}

		// Token: 0x04000017 RID: 23
		private static readonly AssetBundleCreateRequest.get_assetBundleDelegate get_assetBundleDelegateField;

		// Token: 0x04000018 RID: 24
		private static readonly AssetBundleCreateRequest.SetEnableCompatibilityChecksDelegate SetEnableCompatibilityChecksDelegateField;

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000088 RID: 136
		private delegate IntPtr get_assetBundleDelegate(IntPtr @this);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x0600008A RID: 138
		private delegate void SetEnableCompatibilityChecksDelegate(IntPtr @this, bool set);
	}
}
