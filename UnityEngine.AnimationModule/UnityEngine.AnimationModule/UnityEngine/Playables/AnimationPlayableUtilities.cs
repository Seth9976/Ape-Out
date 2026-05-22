using System;
using UnityEngine.Animations;

namespace UnityEngine.Playables
{
	// Token: 0x0200004C RID: 76
	public static class AnimationPlayableUtilities
	{
		// Token: 0x060004D9 RID: 1241 RVA: 0x0000E60C File Offset: 0x0000C80C
		public static void Play(Animator animator, Playable playable, PlayableGraph graph)
		{
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, "AnimationClip", animator);
			animationPlayableOutput.SetSourcePlayable(playable, 0);
			AnimationPlayableGraphExtensions.SyncUpdateAndTimeMode(graph, animator);
			graph.Play();
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0000E640 File Offset: 0x0000C840
		public static AnimationClipPlayable PlayClip(Animator animator, AnimationClip clip, out PlayableGraph graph)
		{
			graph = PlayableGraph.Create();
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, "AnimationClip", animator);
			AnimationClipPlayable animationClipPlayable = AnimationClipPlayable.Create(graph, clip);
			PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, AnimationClipPlayable>(animationPlayableOutput, animationClipPlayable);
			AnimationPlayableGraphExtensions.SyncUpdateAndTimeMode(graph, animator);
			graph.Play();
			return animationClipPlayable;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0000E69C File Offset: 0x0000C89C
		public static AnimationMixerPlayable PlayMixer(Animator animator, int inputCount, out PlayableGraph graph)
		{
			graph = PlayableGraph.Create();
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, "Mixer", animator);
			AnimationMixerPlayable animationMixerPlayable = AnimationMixerPlayable.Create(graph, inputCount, false);
			PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, AnimationMixerPlayable>(animationPlayableOutput, animationMixerPlayable);
			AnimationPlayableGraphExtensions.SyncUpdateAndTimeMode(graph, animator);
			graph.Play();
			return animationMixerPlayable;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0000E6F8 File Offset: 0x0000C8F8
		public static AnimationLayerMixerPlayable PlayLayerMixer(Animator animator, int inputCount, out PlayableGraph graph)
		{
			graph = PlayableGraph.Create();
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, "Mixer", animator);
			AnimationLayerMixerPlayable animationLayerMixerPlayable = AnimationLayerMixerPlayable.Create(graph, inputCount);
			PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, AnimationLayerMixerPlayable>(animationPlayableOutput, animationLayerMixerPlayable);
			AnimationPlayableGraphExtensions.SyncUpdateAndTimeMode(graph, animator);
			graph.Play();
			return animationLayerMixerPlayable;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0000E754 File Offset: 0x0000C954
		public static AnimatorControllerPlayable PlayAnimatorController(Animator animator, RuntimeAnimatorController controller, out PlayableGraph graph)
		{
			graph = PlayableGraph.Create();
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, "AnimatorControllerPlayable", animator);
			AnimatorControllerPlayable animatorControllerPlayable = AnimatorControllerPlayable.Create(graph, controller);
			PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, AnimatorControllerPlayable>(animationPlayableOutput, animatorControllerPlayable);
			AnimationPlayableGraphExtensions.SyncUpdateAndTimeMode(graph, animator);
			graph.Play();
			return animatorControllerPlayable;
		}
	}
}
