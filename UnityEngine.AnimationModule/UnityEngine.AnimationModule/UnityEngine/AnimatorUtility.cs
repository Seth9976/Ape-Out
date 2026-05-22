using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x0200003D RID: 61
	public class AnimatorUtility
	{
		// Token: 0x060004A4 RID: 1188 RVA: 0x00004B43 File Offset: 0x00002D43
		public static void OptimizeTransformHierarchy(GameObject go, Il2CppStringArray exposedTransforms)
		{
			AnimatorUtility.OptimizeTransformHierarchyDelegateField(IL2CPP.Il2CppObjectBaseToPtr(go), IL2CPP.Il2CppObjectBaseToPtr(exposedTransforms));
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00004B5B File Offset: 0x00002D5B
		public static void DeoptimizeTransformHierarchy(GameObject go)
		{
			AnimatorUtility.DeoptimizeTransformHierarchyDelegateField(IL2CPP.Il2CppObjectBaseToPtr(go));
		}

		// Token: 0x040002DD RID: 733
		private static readonly AnimatorUtility.OptimizeTransformHierarchyDelegate OptimizeTransformHierarchyDelegateField = IL2CPP.ResolveICall<AnimatorUtility.OptimizeTransformHierarchyDelegate>("UnityEngine.AnimatorUtility::OptimizeTransformHierarchy");

		// Token: 0x040002DE RID: 734
		private static readonly AnimatorUtility.DeoptimizeTransformHierarchyDelegate DeoptimizeTransformHierarchyDelegateField = IL2CPP.ResolveICall<AnimatorUtility.DeoptimizeTransformHierarchyDelegate>("UnityEngine.AnimatorUtility::DeoptimizeTransformHierarchy");

		// Token: 0x020001D2 RID: 466
		// (Invoke) Token: 0x0600089A RID: 2202
		private delegate void OptimizeTransformHierarchyDelegate(IntPtr go, IntPtr exposedTransforms);

		// Token: 0x020001D3 RID: 467
		// (Invoke) Token: 0x0600089C RID: 2204
		private delegate void DeoptimizeTransformHierarchyDelegate(IntPtr go);
	}
}
