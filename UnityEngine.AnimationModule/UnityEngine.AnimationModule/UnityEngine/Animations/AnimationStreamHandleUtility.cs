using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Animations
{
	// Token: 0x02000054 RID: 84
	public static class AnimationStreamHandleUtility
	{
		// Token: 0x0600050A RID: 1290 RVA: 0x0000506A File Offset: 0x0000326A
		public unsafe static void ReadStreamIntsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* intBuffer, int count)
		{
			AnimationStreamHandleUtility.ReadStreamIntsInternalDelegateField(ref stream, propertyStreamHandles, intBuffer, count);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000507A File Offset: 0x0000327A
		public unsafe static void ReadStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count)
		{
			AnimationStreamHandleUtility.ReadStreamFloatsInternalDelegateField(ref stream, propertyStreamHandles, floatBuffer, count);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000508A File Offset: 0x0000328A
		public unsafe static void WriteStreamIntsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* intBuffer, int count, bool useMask)
		{
			AnimationStreamHandleUtility.WriteStreamIntsInternalDelegateField(ref stream, propertyStreamHandles, intBuffer, count, useMask);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000509C File Offset: 0x0000329C
		public unsafe static void WriteStreamFloatsInternal(ref AnimationStream stream, void* propertyStreamHandles, void* floatBuffer, int count, bool useMask)
		{
			AnimationStreamHandleUtility.WriteStreamFloatsInternalDelegateField(ref stream, propertyStreamHandles, floatBuffer, count, useMask);
		}

		// Token: 0x040003C3 RID: 963
		private static readonly AnimationStreamHandleUtility.ReadStreamIntsInternalDelegate ReadStreamIntsInternalDelegateField = IL2CPP.ResolveICall<AnimationStreamHandleUtility.ReadStreamIntsInternalDelegate>("UnityEngine.Animations.AnimationStreamHandleUtility::ReadStreamIntsInternal");

		// Token: 0x040003C4 RID: 964
		private static readonly AnimationStreamHandleUtility.ReadStreamFloatsInternalDelegate ReadStreamFloatsInternalDelegateField = IL2CPP.ResolveICall<AnimationStreamHandleUtility.ReadStreamFloatsInternalDelegate>("UnityEngine.Animations.AnimationStreamHandleUtility::ReadStreamFloatsInternal");

		// Token: 0x040003C5 RID: 965
		private static readonly AnimationStreamHandleUtility.WriteStreamIntsInternalDelegate WriteStreamIntsInternalDelegateField = IL2CPP.ResolveICall<AnimationStreamHandleUtility.WriteStreamIntsInternalDelegate>("UnityEngine.Animations.AnimationStreamHandleUtility::WriteStreamIntsInternal");

		// Token: 0x040003C6 RID: 966
		private static readonly AnimationStreamHandleUtility.WriteStreamFloatsInternalDelegate WriteStreamFloatsInternalDelegateField = IL2CPP.ResolveICall<AnimationStreamHandleUtility.WriteStreamFloatsInternalDelegate>("UnityEngine.Animations.AnimationStreamHandleUtility::WriteStreamFloatsInternal");

		// Token: 0x0200020D RID: 525
		// (Invoke) Token: 0x0600090E RID: 2318
		private delegate void ReadStreamIntsInternalDelegate(IntPtr stream, IntPtr propertyStreamHandles, IntPtr intBuffer, int count);

		// Token: 0x0200020E RID: 526
		// (Invoke) Token: 0x06000910 RID: 2320
		private delegate void ReadStreamFloatsInternalDelegate(IntPtr stream, IntPtr propertyStreamHandles, IntPtr floatBuffer, int count);

		// Token: 0x0200020F RID: 527
		// (Invoke) Token: 0x06000912 RID: 2322
		private delegate void WriteStreamIntsInternalDelegate(IntPtr stream, IntPtr propertyStreamHandles, IntPtr intBuffer, int count, bool useMask);

		// Token: 0x02000210 RID: 528
		// (Invoke) Token: 0x06000914 RID: 2324
		private delegate void WriteStreamFloatsInternalDelegate(IntPtr stream, IntPtr propertyStreamHandles, IntPtr floatBuffer, int count, bool useMask);
	}
}
