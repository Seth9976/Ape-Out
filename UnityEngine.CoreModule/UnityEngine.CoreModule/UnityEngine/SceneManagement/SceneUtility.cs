using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.SceneManagement
{
	// Token: 0x02000288 RID: 648
	public static class SceneUtility
	{
		// Token: 0x060022A5 RID: 8869 RVA: 0x00078450 File Offset: 0x00076650
		public static string GetScenePathByBuildIndex(int buildIndex)
		{
			IntPtr intPtr = SceneUtility.GetScenePathByBuildIndexDelegateField(buildIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x000127F2 File Offset: 0x000109F2
		public static int GetBuildIndexByScenePath(string scenePath)
		{
			return SceneUtility.GetBuildIndexByScenePathDelegateField(IL2CPP.ManagedStringToIl2Cpp(scenePath));
		}

		// Token: 0x04001C8B RID: 7307
		private static readonly SceneUtility.GetScenePathByBuildIndexDelegate GetScenePathByBuildIndexDelegateField = IL2CPP.ResolveICall<SceneUtility.GetScenePathByBuildIndexDelegate>("UnityEngine.SceneManagement.SceneUtility::GetScenePathByBuildIndex");

		// Token: 0x04001C8C RID: 7308
		private static readonly SceneUtility.GetBuildIndexByScenePathDelegate GetBuildIndexByScenePathDelegateField = IL2CPP.ResolveICall<SceneUtility.GetBuildIndexByScenePathDelegate>("UnityEngine.SceneManagement.SceneUtility::GetBuildIndexByScenePath");

		// Token: 0x02000BE6 RID: 3046
		// (Invoke) Token: 0x06003624 RID: 13860
		private delegate IntPtr GetScenePathByBuildIndexDelegate(int buildIndex);

		// Token: 0x02000BE7 RID: 3047
		// (Invoke) Token: 0x06003626 RID: 13862
		private delegate int GetBuildIndexByScenePathDelegate(IntPtr scenePath);
	}
}
