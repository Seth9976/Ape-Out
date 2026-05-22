using System;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000075 RID: 117
	public class VisualTreeViewDataUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00004125 File Offset: 0x00002325
		public override ProfilerMarker profilerMarker
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00004132 File Offset: 0x00002332
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000413F File Offset: 0x0000233F
		public override void Update()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000414C File Offset: 0x0000234C
		public void ValidateViewDataOnSubTree(VisualElement ve, bool enablePersistence)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00004159 File Offset: 0x00002359
		public void PropagateToParents(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000092 RID: 146
		public const int kMaxValidatePersistentDataCount = 5;
	}
}
