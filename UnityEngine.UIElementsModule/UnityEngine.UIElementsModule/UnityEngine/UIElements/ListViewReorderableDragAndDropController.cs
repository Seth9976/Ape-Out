using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A9 RID: 169
	public class ListViewReorderableDragAndDropController
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00005376 File Offset: 0x00003576
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00005383 File Offset: 0x00003583
		public bool enableReordering
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

		// Token: 0x06000482 RID: 1154 RVA: 0x0000B4B0 File Offset: 0x000096B0
		public virtual bool CanStartDrag(IEnumerable<Object> items)
		{
			return this.enableReordering;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00005390 File Offset: 0x00003590
		public virtual StartDragArgs SetupDragAndDrop(IEnumerable<Object> items)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000539D File Offset: 0x0000359D
		public virtual DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000053AA File Offset: 0x000035AA
		public virtual void OnDrop(IListDragAndDropArgs args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x000053B7 File Offset: 0x000035B7
		public void InsertRange(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001F1 RID: 497
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
