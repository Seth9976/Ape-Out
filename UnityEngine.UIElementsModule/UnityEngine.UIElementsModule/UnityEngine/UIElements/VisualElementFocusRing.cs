using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000063 RID: 99
	public class VisualElementFocusRing
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00003D7A File Offset: 0x00001F7A
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00003D87 File Offset: 0x00001F87
		public VisualElementFocusRing.DefaultFocusOrder defaultFocusOrder
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

		// Token: 0x0600029A RID: 666 RVA: 0x00003D94 File Offset: 0x00001F94
		public int FocusRingAutoIndexSort(VisualElementFocusRing.FocusRingRecord a, VisualElementFocusRing.FocusRingRecord b)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00003DA1 File Offset: 0x00001FA1
		public int FocusRingSort(VisualElementFocusRing.FocusRingRecord a, VisualElementFocusRing.FocusRingRecord b)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00003DAE File Offset: 0x00001FAE
		public void DoUpdate()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00003DBB File Offset: 0x00001FBB
		public void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, List<VisualElementFocusRing.FocusRingRecord> scopeList)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00003DC8 File Offset: 0x00001FC8
		public void SortAndFlattenScopeLists(List<VisualElementFocusRing.FocusRingRecord> rootScopeList)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00003DD5 File Offset: 0x00001FD5
		public int GetFocusableInternalIndex(Focusable f)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00003DE2 File Offset: 0x00001FE2
		public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00003DEF File Offset: 0x00001FEF
		public static FocusChangeDirection GetKeyDownFocusChangeDirection(EventBase e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00003DFC File Offset: 0x00001FFC
		public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000A164 File Offset: 0x00008364
		public static Focusable GetNextFocusableInTree(VisualElement currentFocusable)
		{
			bool flag = currentFocusable == null;
			Focusable focusable;
			if (flag)
			{
				focusable = null;
			}
			else
			{
				VisualElement visualElement = currentFocusable.GetNextElementDepthFirst();
				while (!visualElement.canGrabFocus || visualElement.tabIndex < 0 || visualElement.excludeFromFocusRing)
				{
					visualElement = visualElement.GetNextElementDepthFirst();
					bool flag2 = visualElement == null;
					if (flag2)
					{
						visualElement = currentFocusable.GetRoot();
					}
					bool flag3 = visualElement == currentFocusable;
					if (flag3)
					{
						return currentFocusable;
					}
				}
				focusable = visualElement;
			}
			return focusable;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00003E09 File Offset: 0x00002009
		public static Focusable GetPreviousFocusableInTree(VisualElement currentFocusable)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001C3 RID: 451
		public enum DefaultFocusOrder
		{
			// Token: 0x04000235 RID: 565
			ChildOrder,
			// Token: 0x04000236 RID: 566
			PositionXY,
			// Token: 0x04000237 RID: 567
			PositionYX
		}

		// Token: 0x020001C4 RID: 452
		public class FocusRingRecord
		{
		}
	}
}
