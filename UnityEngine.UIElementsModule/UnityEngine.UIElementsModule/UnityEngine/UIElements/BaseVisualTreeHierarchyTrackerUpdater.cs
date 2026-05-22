using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200006B RID: 107
	public abstract class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x00003ECF File Offset: 0x000020CF
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00003EDC File Offset: 0x000020DC
		public override void Update()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00003EE9 File Offset: 0x000020E9
		public void ProcessNewChange(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00003EF6 File Offset: 0x000020F6
		public void ProcessAddOrMove(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00003F03 File Offset: 0x00002103
		public void ProcessRemove(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001C5 RID: 453
		public enum State
		{
			// Token: 0x04000239 RID: 569
			Waiting,
			// Token: 0x0400023A RID: 570
			TrackingAddOrMove,
			// Token: 0x0400023B RID: 571
			TrackingRemove
		}
	}
}
