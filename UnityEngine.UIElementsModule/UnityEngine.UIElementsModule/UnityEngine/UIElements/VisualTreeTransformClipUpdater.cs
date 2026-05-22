using System;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000070 RID: 112
	public class VisualTreeTransformClipUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00004005 File Offset: 0x00002205
		public override ProfilerMarker profilerMarker
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00004012 File Offset: 0x00002212
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000401F File Offset: 0x0000221F
		public static void DirtyHierarchy(VisualElement ve, bool mustDirtyWorldTransform, bool mustDirtyWorldClip)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000402C File Offset: 0x0000222C
		public static void DirtyBoundingBoxHierarchy(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00004039 File Offset: 0x00002239
		public override void Update()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
