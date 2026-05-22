using System;
using Il2CppSystem;
using Unity.Profiling;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x0200010C RID: 268
	public class UIRLayoutUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x00006443 File Offset: 0x00004643
		public override ProfilerMarker profilerMarker
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0000C534 File Offset: 0x0000A734
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			bool flag = (versionChangeType & (VersionChangeType)12) == (VersionChangeType)0;
			if (!flag)
			{
				bool flag2 = (versionChangeType & VersionChangeType.Hierarchy) != (VersionChangeType)0 && base.panel.duringLayoutPhase;
				if (flag2)
				{
					throw new InvalidOperationException("Hierarchy change detected while computing layout, this is not supported.");
				}
				YogaNode yogaNode = ve.yogaNode;
				bool flag3 = yogaNode != null && yogaNode.IsMeasureDefined;
				if (flag3)
				{
					yogaNode.MarkDirty();
				}
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00006450 File Offset: 0x00004650
		public override void Update()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0000645D File Offset: 0x0000465D
		public void UpdateSubTree(VisualElement ve, int currentLayoutPass)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000D3 RID: 211
		public const int kMaxValidateLayoutCount = 5;
	}
}
