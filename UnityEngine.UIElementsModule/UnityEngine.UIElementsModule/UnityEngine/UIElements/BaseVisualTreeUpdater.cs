using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000074 RID: 116
	public abstract class BaseVisualTreeUpdater
	{
		// Token: 0x060002DC RID: 732 RVA: 0x000040DC File Offset: 0x000022DC
		public void add_panelChanged(Action<BaseVisualElementPanel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000040E9 File Offset: 0x000022E9
		public void remove_panelChanged(Action<BaseVisualElementPanel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002DE RID: 734 RVA: 0x000040F6 File Offset: 0x000022F6
		// (set) Token: 0x060002DF RID: 735 RVA: 0x00004103 File Offset: 0x00002303
		public BaseVisualElementPanel panel
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

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0000A25C File Offset: 0x0000845C
		public VisualElement visualTree
		{
			get
			{
				return this.panel.visualTree;
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00004110 File Offset: 0x00002310
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00004122 File Offset: 0x00002322
		public virtual void Dispose(bool disposing)
		{
		}
	}
}
