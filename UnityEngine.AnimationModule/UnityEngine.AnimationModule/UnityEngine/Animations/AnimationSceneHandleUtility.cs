using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Animations
{
	// Token: 0x02000053 RID: 83
	public static class AnimationSceneHandleUtility
	{
		// Token: 0x06000506 RID: 1286 RVA: 0x0000EA58 File Offset: 0x0000CC58
		public static int ValidateAndGetArrayCount<T0, T1>(ref AnimationStream stream, NativeArray<T0> handles, NativeArray<T1> buffer) where T0 : struct where T1 : struct
		{
			stream.CheckIsValid();
			bool flag = !handles.IsCreated;
			if (flag)
			{
				throw new NullReferenceException("Handle array is invalid.");
			}
			bool flag2 = !buffer.IsCreated;
			if (flag2)
			{
				throw new NullReferenceException("Data buffer is invalid.");
			}
			bool flag3 = buffer.Length < handles.Length;
			if (flag3)
			{
				throw new InvalidOperationException("Data buffer array is smaller than handles array.");
			}
			return handles.Length;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0000500C File Offset: 0x0000320C
		public unsafe static void ReadSceneIntsInternal(ref AnimationStream stream, void* propertySceneHandles, void* intBuffer, int count)
		{
			AnimationSceneHandleUtility.ReadSceneIntsInternalDelegateField(ref stream, propertySceneHandles, intBuffer, count);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0000501C File Offset: 0x0000321C
		public unsafe static void ReadSceneFloatsInternal(ref AnimationStream stream, void* propertySceneHandles, void* floatBuffer, int count)
		{
			AnimationSceneHandleUtility.ReadSceneFloatsInternalDelegateField(ref stream, propertySceneHandles, floatBuffer, count);
		}

		// Token: 0x040003C1 RID: 961
		private static readonly AnimationSceneHandleUtility.ReadSceneIntsInternalDelegate ReadSceneIntsInternalDelegateField = IL2CPP.ResolveICall<AnimationSceneHandleUtility.ReadSceneIntsInternalDelegate>("UnityEngine.Animations.AnimationSceneHandleUtility::ReadSceneIntsInternal");

		// Token: 0x040003C2 RID: 962
		private static readonly AnimationSceneHandleUtility.ReadSceneFloatsInternalDelegate ReadSceneFloatsInternalDelegateField = IL2CPP.ResolveICall<AnimationSceneHandleUtility.ReadSceneFloatsInternalDelegate>("UnityEngine.Animations.AnimationSceneHandleUtility::ReadSceneFloatsInternal");

		// Token: 0x0200020B RID: 523
		// (Invoke) Token: 0x0600090A RID: 2314
		private delegate void ReadSceneIntsInternalDelegate(IntPtr stream, IntPtr propertySceneHandles, IntPtr intBuffer, int count);

		// Token: 0x0200020C RID: 524
		// (Invoke) Token: 0x0600090C RID: 2316
		private delegate void ReadSceneFloatsInternalDelegate(IntPtr stream, IntPtr propertySceneHandles, IntPtr floatBuffer, int count);
	}
}
