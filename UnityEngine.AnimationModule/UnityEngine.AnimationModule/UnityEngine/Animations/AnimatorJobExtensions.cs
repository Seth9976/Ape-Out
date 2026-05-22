using System;
using Il2CppInterop.Runtime;
using Unity.Jobs;

namespace UnityEngine.Animations
{
	// Token: 0x02000056 RID: 86
	public static class AnimatorJobExtensions
	{
		// Token: 0x0600050F RID: 1295 RVA: 0x000050AE File Offset: 0x000032AE
		public static void AddJobDependency(Animator animator, JobHandle jobHandle)
		{
			AnimatorJobExtensions.InternalAddJobDependency(animator, jobHandle);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0000EB34 File Offset: 0x0000CD34
		public static bool OpenAnimationStream(Animator animator, ref AnimationStream stream)
		{
			return AnimatorJobExtensions.InternalOpenAnimationStream(animator, ref stream);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000050B9 File Offset: 0x000032B9
		public static void CloseAnimationStream(Animator animator, ref AnimationStream stream)
		{
			AnimatorJobExtensions.InternalCloseAnimationStream(animator, ref stream);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000050C4 File Offset: 0x000032C4
		public static void ResolveAllStreamHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalResolveAllStreamHandles(animator);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x000050CE File Offset: 0x000032CE
		public static void ResolveAllSceneHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalResolveAllSceneHandles(animator);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x000050D8 File Offset: 0x000032D8
		public static void UnbindAllHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalUnbindAllHandles(animator);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000050E2 File Offset: 0x000032E2
		public static void InternalAddJobDependency(Animator animator, JobHandle jobHandle)
		{
			AnimatorJobExtensions.InternalAddJobDependency_Injected(animator, ref jobHandle);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000050EC File Offset: 0x000032EC
		public static bool InternalOpenAnimationStream(Animator animator, ref AnimationStream stream)
		{
			return AnimatorJobExtensions.InternalOpenAnimationStreamDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator), ref stream);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000050FF File Offset: 0x000032FF
		public static void InternalCloseAnimationStream(Animator animator, ref AnimationStream stream)
		{
			AnimatorJobExtensions.InternalCloseAnimationStreamDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator), ref stream);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00005112 File Offset: 0x00003312
		public static void InternalResolveAllStreamHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalResolveAllStreamHandlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator));
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00005124 File Offset: 0x00003324
		public static void InternalResolveAllSceneHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalResolveAllSceneHandlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator));
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00005136 File Offset: 0x00003336
		public static void InternalUnbindAllHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalUnbindAllHandlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator));
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00005148 File Offset: 0x00003348
		public static void InternalAddJobDependency_Injected(Animator animator, ref JobHandle jobHandle)
		{
			AnimatorJobExtensions.InternalAddJobDependency_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator), ref jobHandle);
		}

		// Token: 0x040003CB RID: 971
		private static readonly AnimatorJobExtensions.InternalOpenAnimationStreamDelegate InternalOpenAnimationStreamDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalOpenAnimationStreamDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalOpenAnimationStream");

		// Token: 0x040003CC RID: 972
		private static readonly AnimatorJobExtensions.InternalCloseAnimationStreamDelegate InternalCloseAnimationStreamDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalCloseAnimationStreamDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalCloseAnimationStream");

		// Token: 0x040003CD RID: 973
		private static readonly AnimatorJobExtensions.InternalResolveAllStreamHandlesDelegate InternalResolveAllStreamHandlesDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalResolveAllStreamHandlesDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalResolveAllStreamHandles");

		// Token: 0x040003CE RID: 974
		private static readonly AnimatorJobExtensions.InternalResolveAllSceneHandlesDelegate InternalResolveAllSceneHandlesDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalResolveAllSceneHandlesDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalResolveAllSceneHandles");

		// Token: 0x040003CF RID: 975
		private static readonly AnimatorJobExtensions.InternalUnbindAllHandlesDelegate InternalUnbindAllHandlesDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalUnbindAllHandlesDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalUnbindAllHandles");

		// Token: 0x040003D0 RID: 976
		private static readonly AnimatorJobExtensions.InternalAddJobDependency_InjectedDelegate InternalAddJobDependency_InjectedDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalAddJobDependency_InjectedDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalAddJobDependency_Injected");

		// Token: 0x02000211 RID: 529
		// (Invoke) Token: 0x06000916 RID: 2326
		private delegate bool InternalOpenAnimationStreamDelegate(IntPtr animator, IntPtr stream);

		// Token: 0x02000212 RID: 530
		// (Invoke) Token: 0x06000918 RID: 2328
		private delegate void InternalCloseAnimationStreamDelegate(IntPtr animator, IntPtr stream);

		// Token: 0x02000213 RID: 531
		// (Invoke) Token: 0x0600091A RID: 2330
		private delegate void InternalResolveAllStreamHandlesDelegate(IntPtr animator);

		// Token: 0x02000214 RID: 532
		// (Invoke) Token: 0x0600091C RID: 2332
		private delegate void InternalResolveAllSceneHandlesDelegate(IntPtr animator);

		// Token: 0x02000215 RID: 533
		// (Invoke) Token: 0x0600091E RID: 2334
		private delegate void InternalUnbindAllHandlesDelegate(IntPtr animator);

		// Token: 0x02000216 RID: 534
		// (Invoke) Token: 0x06000920 RID: 2336
		private delegate void InternalAddJobDependency_InjectedDelegate(IntPtr animator, IntPtr jobHandle);
	}
}
