using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000022 RID: 34
	public static class AnimationPlayableGraphExtensions : Object
	{
		// Token: 0x06000398 RID: 920 RVA: 0x0000C7A0 File Offset: 0x0000A9A0
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationPlayableGraphExtensions()
		{
			Il2CppClassPointerStore<AnimationPlayableGraphExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationPlayableGraphExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlayableGraphExtensions>.NativeClassPtr);
			AnimationPlayableGraphExtensions.NativeMethodInfoPtr_InternalCreateAnimationOutput_Internal_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlayableGraphExtensions>.NativeClassPtr, 100663432);
			AnimationPlayableGraphExtensions.InternalSyncUpdateAndTimeModeDelegateField = IL2CPP.ResolveICall<AnimationPlayableGraphExtensions.InternalSyncUpdateAndTimeModeDelegate>("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalSyncUpdateAndTimeMode");
			AnimationPlayableGraphExtensions.InternalDestroyOutputDelegateField = IL2CPP.ResolveICall<AnimationPlayableGraphExtensions.InternalDestroyOutputDelegate>("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalDestroyOutput");
			AnimationPlayableGraphExtensions.InternalAnimationOutputCountDelegateField = IL2CPP.ResolveICall<AnimationPlayableGraphExtensions.InternalAnimationOutputCountDelegate>("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalAnimationOutputCount");
			AnimationPlayableGraphExtensions.InternalGetAnimationOutputDelegateField = IL2CPP.ResolveICall<AnimationPlayableGraphExtensions.InternalGetAnimationOutputDelegate>("UnityEngine.Animations.AnimationPlayableGraphExtensions::InternalGetAnimationOutput");
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000C820 File Offset: 0x0000AA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484458, XrefRangeEnd = 484462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalCreateAnimationOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlayableGraphExtensions.NativeMethodInfoPtr_InternalCreateAnimationOutput_Internal_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000041BA File Offset: 0x000023BA
		public AnimationPlayableGraphExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000041C3 File Offset: 0x000023C3
		public static void SyncUpdateAndTimeMode(PlayableGraph graph, Animator animator)
		{
			AnimationPlayableGraphExtensions.InternalSyncUpdateAndTimeMode(ref graph, animator);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000041CF File Offset: 0x000023CF
		public static void DestroyOutput(PlayableGraph graph, PlayableOutputHandle handle)
		{
			AnimationPlayableGraphExtensions.InternalDestroyOutput(ref graph, ref handle);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000041DC File Offset: 0x000023DC
		public static void InternalSyncUpdateAndTimeMode(ref PlayableGraph graph, Animator animator)
		{
			AnimationPlayableGraphExtensions.InternalSyncUpdateAndTimeModeDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(animator));
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000041EF File Offset: 0x000023EF
		public static void InternalDestroyOutput(ref PlayableGraph graph, ref PlayableOutputHandle handle)
		{
			AnimationPlayableGraphExtensions.InternalDestroyOutputDelegateField(ref graph, ref handle);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000041FD File Offset: 0x000023FD
		public static int InternalAnimationOutputCount(ref PlayableGraph graph)
		{
			return AnimationPlayableGraphExtensions.InternalAnimationOutputCountDelegateField(ref graph);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000420A File Offset: 0x0000240A
		public static bool InternalGetAnimationOutput(ref PlayableGraph graph, int index, out PlayableOutputHandle handle)
		{
			return AnimationPlayableGraphExtensions.InternalGetAnimationOutputDelegateField(ref graph, index, out handle);
		}

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreateAnimationOutput_Internal_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0;

		// Token: 0x04000220 RID: 544
		private static readonly AnimationPlayableGraphExtensions.InternalSyncUpdateAndTimeModeDelegate InternalSyncUpdateAndTimeModeDelegateField;

		// Token: 0x04000221 RID: 545
		private static readonly AnimationPlayableGraphExtensions.InternalDestroyOutputDelegate InternalDestroyOutputDelegateField;

		// Token: 0x04000222 RID: 546
		private static readonly AnimationPlayableGraphExtensions.InternalAnimationOutputCountDelegate InternalAnimationOutputCountDelegateField;

		// Token: 0x04000223 RID: 547
		private static readonly AnimationPlayableGraphExtensions.InternalGetAnimationOutputDelegate InternalGetAnimationOutputDelegateField;

		// Token: 0x0200018A RID: 394
		// (Invoke) Token: 0x0600080A RID: 2058
		private delegate void InternalSyncUpdateAndTimeModeDelegate(IntPtr graph, IntPtr animator);

		// Token: 0x0200018B RID: 395
		// (Invoke) Token: 0x0600080C RID: 2060
		private delegate void InternalDestroyOutputDelegate(IntPtr graph, IntPtr handle);

		// Token: 0x0200018C RID: 396
		// (Invoke) Token: 0x0600080E RID: 2062
		private delegate int InternalAnimationOutputCountDelegate(IntPtr graph);

		// Token: 0x0200018D RID: 397
		// (Invoke) Token: 0x06000810 RID: 2064
		private delegate bool InternalGetAnimationOutputDelegate(IntPtr graph, int index, [Out] IntPtr handle);
	}
}
