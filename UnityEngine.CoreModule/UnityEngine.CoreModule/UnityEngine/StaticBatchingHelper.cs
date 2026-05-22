using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000238 RID: 568
	public struct StaticBatchingHelper
	{
		// Token: 0x0600216D RID: 8557 RVA: 0x00011B79 File Offset: 0x0000FD79
		public static bool IsMeshBatchable(Mesh mesh)
		{
			return StaticBatchingHelper.IsMeshBatchableDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh));
		}

		// Token: 0x04001B93 RID: 7059
		private static readonly StaticBatchingHelper.IsMeshBatchableDelegate IsMeshBatchableDelegateField = IL2CPP.ResolveICall<StaticBatchingHelper.IsMeshBatchableDelegate>("UnityEngine.StaticBatchingHelper::IsMeshBatchable");

		// Token: 0x02000B6B RID: 2923
		// (Invoke) Token: 0x06003536 RID: 13622
		private delegate bool IsMeshBatchableDelegate(IntPtr mesh);
	}
}
