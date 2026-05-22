using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000097 RID: 151
	public class TreeView : VisualElement
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x00004DC2 File Offset: 0x00002FC2
		public void add_onItemsChosen(Action<IEnumerable<ITreeViewItem>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00004DCF File Offset: 0x00002FCF
		public void remove_onItemsChosen(Action<IEnumerable<ITreeViewItem>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00004DDC File Offset: 0x00002FDC
		public void add_onSelectionChange(Action<IEnumerable<ITreeViewItem>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00004DE9 File Offset: 0x00002FE9
		public void remove_onSelectionChange(Action<IEnumerable<ITreeViewItem>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00004DF6 File Offset: 0x00002FF6
		public ITreeViewItem selectedItem
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00004E03 File Offset: 0x00003003
		public IEnumerable<ITreeViewItem> selectedItems
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00004E10 File Offset: 0x00003010
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00004E1D File Offset: 0x0000301D
		public IList<ITreeViewItem> rootItems
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

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00004E2A File Offset: 0x0000302A
		public IEnumerable<ITreeViewItem> items
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00004E37 File Offset: 0x00003037
		public float resolvedItemHeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00004E44 File Offset: 0x00003044
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x00004E51 File Offset: 0x00003051
		public int itemHeight
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

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00004E5E File Offset: 0x0000305E
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00004E6B File Offset: 0x0000306B
		public bool horizontalScrollingEnabled
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

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00004E78 File Offset: 0x00003078
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00004E85 File Offset: 0x00003085
		public bool showBorder
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

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00004E92 File Offset: 0x00003092
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00004E9F File Offset: 0x0000309F
		public SelectionType selectionType
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

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00004EAC File Offset: 0x000030AC
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00004EB9 File Offset: 0x000030B9
		public AlternatingRowBackground showAlternatingRowBackgrounds
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

		// Token: 0x0600041C RID: 1052 RVA: 0x00004EC6 File Offset: 0x000030C6
		public void Refresh()
		{
			this.RegenerateWrappers();
			this.ListViewRefresh();
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000B2B8 File Offset: 0x000094B8
		public override void OnViewDataReady()
		{
			base.OnViewDataReady();
			string fullHierarchicalViewDataKey = base.GetFullHierarchicalViewDataKey();
			base.OverwriteFromViewData(this, fullHierarchicalViewDataKey);
			this.Refresh();
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00004ED7 File Offset: 0x000030D7
		public static IEnumerable<ITreeViewItem> GetAllItems(IEnumerable<ITreeViewItem> rootItems)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00004EE4 File Offset: 0x000030E4
		public void OnKeyDown(KeyDownEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00004EF1 File Offset: 0x000030F1
		public void SetSelection(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00004EFE File Offset: 0x000030FE
		public void SetSelection(IEnumerable<int> ids)
		{
			this.SetSelectionInternal(ids, true);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00004F0A File Offset: 0x0000310A
		public void SetSelectionWithoutNotify(IEnumerable<int> ids)
		{
			this.SetSelectionInternal(ids, false);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00004F16 File Offset: 0x00003116
		public void SetSelectionInternal(IEnumerable<int> ids, bool sendNotification)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00004F23 File Offset: 0x00003123
		public void AddToSelection(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00004F30 File Offset: 0x00003130
		public void RemoveFromSelection(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00004F3D File Offset: 0x0000313D
		public int GetItemIndex(int id, [Optional] bool expand)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00004F4A File Offset: 0x0000314A
		public void ClearSelection()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00004F57 File Offset: 0x00003157
		public void ScrollTo(VisualElement visualElement)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00004F64 File Offset: 0x00003164
		public void ScrollToItem(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00004F71 File Offset: 0x00003171
		public bool IsExpanded(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00004F7E File Offset: 0x0000317E
		public void CollapseItem(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00004F8B File Offset: 0x0000318B
		public void ExpandItem(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000B2E4 File Offset: 0x000094E4
		public ITreeViewItem FindItem(int id)
		{
			foreach (ITreeViewItem treeViewItem in this.items)
			{
				bool flag = treeViewItem.id == id;
				if (flag)
				{
					return treeViewItem;
				}
			}
			return null;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00004F98 File Offset: 0x00003198
		public void ListViewRefresh()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00004FA5 File Offset: 0x000031A5
		public void OnItemsChosen(IEnumerable<Object> chosenItems)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00004FB2 File Offset: 0x000031B2
		public void OnSelectionChange(IEnumerable<Object> selectedListItems)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00004FBF File Offset: 0x000031BF
		public void OnTreeViewMouseUp(MouseUpEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00004FCC File Offset: 0x000031CC
		public void OnItemMouseUp(MouseUpEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00004FD9 File Offset: 0x000031D9
		public VisualElement MakeTreeItem()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00004FE6 File Offset: 0x000031E6
		public void UnbindTreeItem(VisualElement element, int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00004FF3 File Offset: 0x000031F3
		public void BindTreeItem(VisualElement element, int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00005000 File Offset: 0x00003200
		public int GetItemId(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000500D File Offset: 0x0000320D
		public bool IsExpandedByIndex(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000501A File Offset: 0x0000321A
		public void CollapseItemByIndex(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00005027 File Offset: 0x00003227
		public void ExpandItemByIndex(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00005034 File Offset: 0x00003234
		public void RegenerateWrappers()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00005041 File Offset: 0x00003241
		public void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000504E File Offset: 0x0000324E
		public int <SetSelectionInternal>b__68_0(int id)
		{
			return this.GetItemIndex(id, true);
		}

		// Token: 0x020001EC RID: 492
		public new class UxmlFactory : UxmlFactory<TreeView, TreeView.UxmlTraits>
		{
		}

		// Token: 0x020001ED RID: 493
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x02000224 RID: 548
			public sealed class <get_uxmlChildElementsDescription>d__5
			{
			}
		}

		// Token: 0x020001EE RID: 494
		public sealed class <GetAllItems>d__63
		{
		}
	}
}
