using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000072 RID: 114
	public sealed class VisualTreeUpdater
	{
		// Token: 0x060002D4 RID: 724 RVA: 0x00004046 File Offset: 0x00002246
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00004053 File Offset: 0x00002253
		public void UpdateVisualTree()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00004060 File Offset: 0x00002260
		public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000406D File Offset: 0x0000226D
		public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000407A File Offset: 0x0000227A
		public void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00004087 File Offset: 0x00002287
		public void SetUpdater<T>(VisualTreeUpdatePhase phase) where T : new()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00004094 File Offset: 0x00002294
		public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000040A1 File Offset: 0x000022A1
		public void SetDefaultUpdaters()
		{
			this.SetUpdater<VisualTreeViewDataUpdater>(VisualTreeUpdatePhase.ViewData);
			this.SetUpdater<VisualTreeBindingsUpdater>(VisualTreeUpdatePhase.Bindings);
			this.SetUpdater<VisualElementAnimationSystem>(VisualTreeUpdatePhase.Animation);
			this.SetUpdater<VisualTreeStyleUpdater>(VisualTreeUpdatePhase.Styles);
			this.SetUpdater<UIRLayoutUpdater>(VisualTreeUpdatePhase.Layout);
			this.SetUpdater<VisualTreeTransformClipUpdater>(VisualTreeUpdatePhase.TransformClip);
			this.SetUpdater<UIRRepaintUpdater>(VisualTreeUpdatePhase.Repaint);
		}

		// Token: 0x020001C7 RID: 455
		public class UpdaterArray
		{
		}
	}
}
