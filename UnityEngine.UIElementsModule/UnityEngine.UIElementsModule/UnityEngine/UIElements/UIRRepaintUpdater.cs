using System;
using Unity.Profiling;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x02000111 RID: 273
	public class UIRRepaintUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0000652D File Offset: 0x0000472D
		public override ProfilerMarker profilerMarker
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0000653A File Offset: 0x0000473A
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00006547 File Offset: 0x00004747
		public override void Update()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00006554 File Offset: 0x00004754
		public UnityEngine.UIElements.UIR.RenderChain DebugGetRenderChain()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0000C594 File Offset: 0x0000A794
		public virtual UnityEngine.UIElements.UIR.RenderChain CreateRenderChain()
		{
			return new UnityEngine.UIElements.UIR.RenderChain(base.panel);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00006561 File Offset: 0x00004761
		public static void OnGraphicsResourcesRecreate(bool recreate)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0000656E File Offset: 0x0000476E
		public void OnPanelChanged(BaseVisualElementPanel obj)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0000657B File Offset: 0x0000477B
		public void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00006588 File Offset: 0x00004788
		public void OnPanelStandardShaderChanged()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00006595 File Offset: 0x00004795
		public void OnPanelStandardWorldSpaceShaderChanged()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x000065A2 File Offset: 0x000047A2
		public void ResetAllElementsDataRecursive(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000065AF File Offset: 0x000047AF
		public void DisposeRenderChain()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x000065BC File Offset: 0x000047BC
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x000065C9 File Offset: 0x000047C9
		public bool disposed
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
		public override void Dispose(bool disposing)
		{
			bool disposed = this.disposed;
			if (!disposed)
			{
				if (disposing)
				{
					this.DisposeRenderChain();
				}
				this.disposed = true;
			}
		}
	}
}
