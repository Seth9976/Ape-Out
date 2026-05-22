using System;
using Il2CppInterop.Runtime;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Animations
{
	// Token: 0x0200004B RID: 75
	public static class AnimationPlayableOutputExtensions
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x0000E5CC File Offset: 0x0000C7CC
		public static AnimationStreamSource GetAnimationStreamSource(AnimationPlayableOutput output)
		{
			return AnimationPlayableOutputExtensions.InternalGetAnimationStreamSource(output.GetHandle());
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00004D63 File Offset: 0x00002F63
		public static void SetAnimationStreamSource(AnimationPlayableOutput output, AnimationStreamSource streamSource)
		{
			AnimationPlayableOutputExtensions.InternalSetAnimationStreamSource(output.GetHandle(), streamSource);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000E5EC File Offset: 0x0000C7EC
		public static ushort GetSortingOrder(AnimationPlayableOutput output)
		{
			return (ushort)AnimationPlayableOutputExtensions.InternalGetSortingOrder(output.GetHandle());
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00004D74 File Offset: 0x00002F74
		public static void SetSortingOrder(AnimationPlayableOutput output, ushort sortingOrder)
		{
			AnimationPlayableOutputExtensions.InternalSetSortingOrder(output.GetHandle(), (int)sortingOrder);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00004D85 File Offset: 0x00002F85
		public static AnimationStreamSource InternalGetAnimationStreamSource(PlayableOutputHandle output)
		{
			return AnimationPlayableOutputExtensions.InternalGetAnimationStreamSource_Injected(ref output);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00004D8E File Offset: 0x00002F8E
		public static void InternalSetAnimationStreamSource(PlayableOutputHandle output, AnimationStreamSource streamSource)
		{
			AnimationPlayableOutputExtensions.InternalSetAnimationStreamSource_Injected(ref output, streamSource);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00004D98 File Offset: 0x00002F98
		public static int InternalGetSortingOrder(PlayableOutputHandle output)
		{
			return AnimationPlayableOutputExtensions.InternalGetSortingOrder_Injected(ref output);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00004DA1 File Offset: 0x00002FA1
		public static void InternalSetSortingOrder(PlayableOutputHandle output, int sortingOrder)
		{
			AnimationPlayableOutputExtensions.InternalSetSortingOrder_Injected(ref output, sortingOrder);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00004DAB File Offset: 0x00002FAB
		public static AnimationStreamSource InternalGetAnimationStreamSource_Injected(ref PlayableOutputHandle output)
		{
			return AnimationPlayableOutputExtensions.InternalGetAnimationStreamSource_InjectedDelegateField(ref output);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00004DB8 File Offset: 0x00002FB8
		public static void InternalSetAnimationStreamSource_Injected(ref PlayableOutputHandle output, AnimationStreamSource streamSource)
		{
			AnimationPlayableOutputExtensions.InternalSetAnimationStreamSource_InjectedDelegateField(ref output, streamSource);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00004DC6 File Offset: 0x00002FC6
		public static int InternalGetSortingOrder_Injected(ref PlayableOutputHandle output)
		{
			return AnimationPlayableOutputExtensions.InternalGetSortingOrder_InjectedDelegateField(ref output);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00004DD3 File Offset: 0x00002FD3
		public static void InternalSetSortingOrder_Injected(ref PlayableOutputHandle output, int sortingOrder)
		{
			AnimationPlayableOutputExtensions.InternalSetSortingOrder_InjectedDelegateField(ref output, sortingOrder);
		}

		// Token: 0x04000394 RID: 916
		private static readonly AnimationPlayableOutputExtensions.InternalGetAnimationStreamSource_InjectedDelegate InternalGetAnimationStreamSource_InjectedDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutputExtensions.InternalGetAnimationStreamSource_InjectedDelegate>("UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions::InternalGetAnimationStreamSource_Injected");

		// Token: 0x04000395 RID: 917
		private static readonly AnimationPlayableOutputExtensions.InternalSetAnimationStreamSource_InjectedDelegate InternalSetAnimationStreamSource_InjectedDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutputExtensions.InternalSetAnimationStreamSource_InjectedDelegate>("UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions::InternalSetAnimationStreamSource_Injected");

		// Token: 0x04000396 RID: 918
		private static readonly AnimationPlayableOutputExtensions.InternalGetSortingOrder_InjectedDelegate InternalGetSortingOrder_InjectedDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutputExtensions.InternalGetSortingOrder_InjectedDelegate>("UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions::InternalGetSortingOrder_Injected");

		// Token: 0x04000397 RID: 919
		private static readonly AnimationPlayableOutputExtensions.InternalSetSortingOrder_InjectedDelegate InternalSetSortingOrder_InjectedDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutputExtensions.InternalSetSortingOrder_InjectedDelegate>("UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions::InternalSetSortingOrder_Injected");

		// Token: 0x020001ED RID: 493
		// (Invoke) Token: 0x060008D0 RID: 2256
		private delegate AnimationStreamSource InternalGetAnimationStreamSource_InjectedDelegate(IntPtr output);

		// Token: 0x020001EE RID: 494
		// (Invoke) Token: 0x060008D2 RID: 2258
		private delegate void InternalSetAnimationStreamSource_InjectedDelegate(IntPtr output, AnimationStreamSource streamSource);

		// Token: 0x020001EF RID: 495
		// (Invoke) Token: 0x060008D4 RID: 2260
		private delegate int InternalGetSortingOrder_InjectedDelegate(IntPtr output);

		// Token: 0x020001F0 RID: 496
		// (Invoke) Token: 0x060008D6 RID: 2262
		private delegate void InternalSetSortingOrder_InjectedDelegate(IntPtr output, int sortingOrder);
	}
}
