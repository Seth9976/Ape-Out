using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x02000025 RID: 37
	public static class PhysicsSceneExtensions
	{
		// Token: 0x060002FA RID: 762 RVA: 0x0000A698 File Offset: 0x00008898
		public static PhysicsScene GetPhysicsScene(Scene scene)
		{
			bool flag = !scene.IsValid();
			if (flag)
			{
				throw new ArgumentException("Cannot get physics scene; Unity scene is invalid.", "scene");
			}
			PhysicsScene physicsScene_Internal = PhysicsSceneExtensions.GetPhysicsScene_Internal(scene);
			bool flag2 = physicsScene_Internal.IsValid();
			if (flag2)
			{
				return physicsScene_Internal;
			}
			throw new Exception("The physics scene associated with the Unity scene is invalid.");
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000A6E8 File Offset: 0x000088E8
		public static PhysicsScene GetPhysicsScene_Internal(Scene scene)
		{
			PhysicsScene physicsScene;
			PhysicsSceneExtensions.GetPhysicsScene_Internal_Injected(ref scene, out physicsScene);
			return physicsScene;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000038C6 File Offset: 0x00001AC6
		public static void GetPhysicsScene_Internal_Injected(ref Scene scene, out PhysicsScene ret)
		{
			PhysicsSceneExtensions.GetPhysicsScene_Internal_InjectedDelegateField(ref scene, out ret);
		}

		// Token: 0x040001EE RID: 494
		private static readonly PhysicsSceneExtensions.GetPhysicsScene_Internal_InjectedDelegate GetPhysicsScene_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsSceneExtensions.GetPhysicsScene_Internal_InjectedDelegate>("UnityEngine.PhysicsSceneExtensions::GetPhysicsScene_Internal_Injected");

		// Token: 0x02000135 RID: 309
		// (Invoke) Token: 0x0600058E RID: 1422
		private delegate void GetPhysicsScene_Internal_InjectedDelegate(IntPtr scene, [Out] IntPtr ret);
	}
}
