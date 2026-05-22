using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000FC RID: 252
	public class PropagationPaths
	{
		// Token: 0x06000578 RID: 1400 RVA: 0x00005D30 File Offset: 0x00003F30
		public static PropagationPaths Copy(PropagationPaths paths)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00005D3D File Offset: 0x00003F3D
		public static PropagationPaths Build(VisualElement elem, PropagationPaths.Type pathTypesRequested)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00005D4A File Offset: 0x00003F4A
		public void Release()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000D1 RID: 209
		public const int k_DefaultPropagationDepth = 16;

		// Token: 0x040000D2 RID: 210
		public const int k_DefaultTargetCount = 4;

		// Token: 0x020001F5 RID: 501
		public enum Type
		{
			// Token: 0x0400025C RID: 604
			None,
			// Token: 0x0400025D RID: 605
			TrickleDown,
			// Token: 0x0400025E RID: 606
			BubbleUp
		}
	}
}
