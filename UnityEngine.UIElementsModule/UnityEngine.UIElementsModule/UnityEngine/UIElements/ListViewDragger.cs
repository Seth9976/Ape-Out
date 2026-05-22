using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A7 RID: 167
	public class ListViewDragger : DragEventsProcessor
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x000052DA File Offset: 0x000034DA
		public ListView targetListView
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x000052E7 File Offset: 0x000034E7
		public ScrollView targetScrollView
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x000052F4 File Offset: 0x000034F4
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00005301 File Offset: 0x00003501
		public IListViewDragAndDropController dragAndDropController
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

		// Token: 0x06000475 RID: 1141 RVA: 0x0000530E File Offset: 0x0000350E
		public override bool CanStartDrag(Vector3 pointerPosition)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000531B File Offset: 0x0000351B
		public override StartDragArgs StartDrag(Vector3 pointerPosition)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00005328 File Offset: 0x00003528
		public override DragVisualMode UpdateDrag(Vector3 pointerPosition)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00005335 File Offset: 0x00003535
		public override void OnDrop(Vector3 pointerPosition)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000B358 File Offset: 0x00009558
		public void HandleDragAndScroll(Vector2 pointerPosition)
		{
			bool flag = pointerPosition.y < this.targetScrollView.worldBound.yMin + 5f;
			bool flag2 = pointerPosition.y > this.targetScrollView.worldBound.yMax - 5f;
			bool flag3 = flag || flag2;
			if (flag3)
			{
				this.targetScrollView.scrollOffset += (flag ? Vector2.down : Vector2.up) * 20f;
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0000B3E4 File Offset: 0x000095E4
		public void PlaceHoverBarAtElement(VisualElement element)
		{
			VisualElement contentViewport = this.targetScrollView.contentViewport;
			this.PlaceHoverBarAt(Mathf.Min(VisualElementExtensions.WorldToLocal(contentViewport, element.worldBound).yMax, contentViewport.localBound.yMax - 2f));
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00005342 File Offset: 0x00003542
		public void PlaceHoverBarAt(float top)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0000534F File Offset: 0x0000354F
		public override void ClearDragAndDropUI()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0000B434 File Offset: 0x00009634
		public ListView.RecycledItem GetRecycledItem(Vector3 pointerPosition)
		{
			List<ListView.RecycledItem>.Enumerator enumerator = this.targetListView.Pool.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ListView.RecycledItem recycledItem = enumerator.Current;
					bool flag = recycledItem.element.worldBound.Contains(pointerPosition);
					if (flag)
					{
						return recycledItem;
					}
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			return null;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0000535C File Offset: 0x0000355C
		public void <.ctor>b__17_0(GeometryChangedEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000BF RID: 191
		public const int k_EmptyIndex = -1;

		// Token: 0x040000C0 RID: 192
		public const int k_AutoScrollAreaSize = 5;

		// Token: 0x040000C1 RID: 193
		public const int k_BetweenElementsAreaSize = 5;

		// Token: 0x040000C2 RID: 194
		public const int k_PanSpeed = 20;

		// Token: 0x040000C3 RID: 195
		public const int k_DragHoverBarHeight = 2;
	}
}
