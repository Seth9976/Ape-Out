using System;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x0200006F RID: 111
	public class VisualTreeStyleUpdaterTraversal : UnityEngine.UIElements.StyleSheets.HierarchyTraversal
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00003F85 File Offset: 0x00002185
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x00003F92 File Offset: 0x00002192
		public float currentPixelsPerPoint
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

		// Token: 0x060002C7 RID: 711 RVA: 0x00003F9F File Offset: 0x0000219F
		public void PrepareTraversal(float pixelsPerPoint)
		{
			this.currentPixelsPerPoint = pixelsPerPoint;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00003FAA File Offset: 0x000021AA
		public void AddChangedElement(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00003FB7 File Offset: 0x000021B7
		public void Clear()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00003FC4 File Offset: 0x000021C4
		public void PropagateToChildren(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00003FD1 File Offset: 0x000021D1
		public void PropagateToParents(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00003FDE File Offset: 0x000021DE
		public override void TraverseRecursive(VisualElement element, int depth)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00003FEB File Offset: 0x000021EB
		public bool ShouldSkipElement(VisualElement element)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00003FF8 File Offset: 0x000021F8
		public void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001C6 RID: 454
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
