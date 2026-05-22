using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x020002D0 RID: 720
	public static class TexturePlayableBinding
	{
		// Token: 0x06002300 RID: 8960 RVA: 0x00078A54 File Offset: 0x00076C54
		public static UnityEngine.Playables.PlayableBinding Create(string name, Object key)
		{
			return UnityEngine.Playables.PlayableBinding.CreateInternal(name, key, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<RenderTexture>()), new UnityEngine.Playables.PlayableBinding.CreateOutputMethod(TexturePlayableBinding.CreateTextureOutput));
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00078A84 File Offset: 0x00076C84
		public static UnityEngine.Playables.PlayableOutput CreateTextureOutput(UnityEngine.Playables.PlayableGraph graph, string name)
		{
			return TexturePlayableOutput.Create(graph, name, null);
		}
	}
}
