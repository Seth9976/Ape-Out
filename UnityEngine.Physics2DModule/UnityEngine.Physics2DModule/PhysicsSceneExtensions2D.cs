using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x02000018 RID: 24
	public static class PhysicsSceneExtensions2D
	{
		// Token: 0x06000369 RID: 873 RVA: 0x0000D4D4 File Offset: 0x0000B6D4
		public static PhysicsScene2D GetPhysicsScene2D(Scene scene)
		{
			bool flag = !scene.IsValid();
			if (flag)
			{
				throw new ArgumentException("Cannot get physics scene; Unity scene is invalid.", "scene");
			}
			PhysicsScene2D physicsScene_Internal = PhysicsSceneExtensions2D.GetPhysicsScene_Internal(scene);
			bool flag2 = physicsScene_Internal.IsValid();
			if (flag2)
			{
				return physicsScene_Internal;
			}
			throw new Exception("The physics scene associated with the Unity scene is invalid.");
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000D524 File Offset: 0x0000B724
		public static PhysicsScene2D GetPhysicsScene_Internal(Scene scene)
		{
			PhysicsScene2D physicsScene2D;
			PhysicsSceneExtensions2D.GetPhysicsScene_Internal_Injected(ref scene, out physicsScene2D);
			return physicsScene2D;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000377C File Offset: 0x0000197C
		public static void GetPhysicsScene_Internal_Injected(ref Scene scene, out PhysicsScene2D ret)
		{
			PhysicsSceneExtensions2D.GetPhysicsScene_Internal_InjectedDelegateField(ref scene, out ret);
		}

		// Token: 0x040001F9 RID: 505
		private static readonly PhysicsSceneExtensions2D.GetPhysicsScene_Internal_InjectedDelegate GetPhysicsScene_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsSceneExtensions2D.GetPhysicsScene_Internal_InjectedDelegate>("UnityEngine.PhysicsSceneExtensions2D::GetPhysicsScene_Internal_Injected");

		// Token: 0x02000131 RID: 305
		// (Invoke) Token: 0x0600063C RID: 1596
		private delegate void GetPhysicsScene_Internal_InjectedDelegate(IntPtr scene, [Out] IntPtr ret);
	}
}
