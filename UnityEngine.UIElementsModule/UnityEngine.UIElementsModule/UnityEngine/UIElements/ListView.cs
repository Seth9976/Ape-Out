using System;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000088 RID: 136
	public class ListView : BindableElement
	{
		// Token: 0x0600032F RID: 815 RVA: 0x00004492 File Offset: 0x00002692
		public void add_onItemChosen(Action<Object> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000449F File Offset: 0x0000269F
		public void remove_onItemChosen(Action<Object> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000331 RID: 817 RVA: 0x000044AC File Offset: 0x000026AC
		public void add_onItemsChosen(Action<IEnumerable<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000044B9 File Offset: 0x000026B9
		public void remove_onItemsChosen(Action<IEnumerable<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000044C6 File Offset: 0x000026C6
		public void add_onSelectionChanged(Action<List<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000044D3 File Offset: 0x000026D3
		public void remove_onSelectionChanged(Action<List<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000044E0 File Offset: 0x000026E0
		public void add_onSelectionChange(Action<IEnumerable<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000044ED File Offset: 0x000026ED
		public void remove_onSelectionChange(Action<IEnumerable<Object>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000337 RID: 823 RVA: 0x000044FA File Offset: 0x000026FA
		// (set) Token: 0x06000338 RID: 824 RVA: 0x00004507 File Offset: 0x00002707
		public IList itemsSource
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0000A3F4 File Offset: 0x000085F4
		public float resolvedItemHeight
		{
			get
			{
				float scaledPixelsPerPoint = base.scaledPixelsPerPoint;
				return Mathf.Round((float)this.itemHeight * scaledPixelsPerPoint) / scaledPixelsPerPoint;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00004514 File Offset: 0x00002714
		public List<ListView.RecycledItem> Pool
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00004521 File Offset: 0x00002721
		// (set) Token: 0x0600033C RID: 828 RVA: 0x0000452E File Offset: 0x0000272E
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

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000453B File Offset: 0x0000273B
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00004548 File Offset: 0x00002748
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

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00004555 File Offset: 0x00002755
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00004562 File Offset: 0x00002762
		public bool reorderable
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

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000456F File Offset: 0x0000276F
		public List<int> currentSelectionIds
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000457C File Offset: 0x0000277C
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00004589 File Offset: 0x00002789
		public int selectedIndex
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				this.SetSelection(value);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00004594 File Offset: 0x00002794
		public IEnumerable<int> selectedIndices
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000345 RID: 837 RVA: 0x000045A1 File Offset: 0x000027A1
		public Object selectedItem
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000346 RID: 838 RVA: 0x000045AE File Offset: 0x000027AE
		public IEnumerable<Object> selectedItems
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000347 RID: 839 RVA: 0x000045BB File Offset: 0x000027BB
		public override VisualElement contentContainer
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000348 RID: 840 RVA: 0x000045BE File Offset: 0x000027BE
		// (set) Token: 0x06000349 RID: 841 RVA: 0x000045CB File Offset: 0x000027CB
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

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600034A RID: 842 RVA: 0x000045D8 File Offset: 0x000027D8
		// (set) Token: 0x0600034B RID: 843 RVA: 0x000045E5 File Offset: 0x000027E5
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

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600034C RID: 844 RVA: 0x000045F2 File Offset: 0x000027F2
		// (set) Token: 0x0600034D RID: 845 RVA: 0x000045FF File Offset: 0x000027FF
		public bool showBoundCollectionSize
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

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0000460C File Offset: 0x0000280C
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00004619 File Offset: 0x00002819
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

		// Token: 0x06000350 RID: 848 RVA: 0x00004626 File Offset: 0x00002826
		public void OnAttachToPanel(AttachToPanelEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00004633 File Offset: 0x00002833
		public void OnDetachFromPanel(DetachFromPanelEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00004640 File Offset: 0x00002840
		public bool ProcessNavigationEvent(EventBase evt, out bool shouldScroll)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000464D File Offset: 0x0000284D
		public static bool IsSelectAllEvent(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000A420 File Offset: 0x00008620
		public void ProcessAnyEvent(EventBase evt)
		{
			bool flag2;
			bool flag = this.ProcessNavigationEvent(evt, out flag2);
			if (flag)
			{
				evt.StopPropagation();
				evt.PreventDefault();
				bool flag3 = flag2;
				if (flag3)
				{
					this.ScrollToItem(this.selectedIndex);
				}
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000465A File Offset: 0x0000285A
		public void OnKeyDown(KeyDownEvent evt)
		{
			this.ProcessAnyEvent(evt);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000A460 File Offset: 0x00008660
		public override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
			this.ProcessAnyEvent(evt);
			bool flag = !evt.isPropagationStopped;
			if (flag)
			{
				base.ExecuteDefaultActionAtTarget(evt);
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00004665 File Offset: 0x00002865
		public void ScrollToItem(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00004672 File Offset: 0x00002872
		public void OnPointerMove(PointerMoveEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000467F File Offset: 0x0000287F
		public void OnPointerDown(PointerDownEvent evt)
		{
			this.ProcessPointerDown(evt);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000468A File Offset: 0x0000288A
		public void OnPointerUp(PointerUpEvent evt)
		{
			this.ProcessPointerUp(evt);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00004695 File Offset: 0x00002895
		public void ProcessPointerDown(IPointerEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600035C RID: 860 RVA: 0x000046A2 File Offset: 0x000028A2
		public void ProcessPointerUp(IPointerEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000046AF File Offset: 0x000028AF
		public void DoSelect(Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000046BC File Offset: 0x000028BC
		public void ProcessSingleClick(int clickedIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000046C9 File Offset: 0x000028C9
		public void SelectAll()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000046D6 File Offset: 0x000028D6
		public int GetIdFromIndex(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000046E3 File Offset: 0x000028E3
		public void AddToSelection(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000A48C File Offset: 0x0000868C
		public void AddToSelection(IList<int> indexes)
		{
			bool flag = !this.HasValidDataAndBindings() || indexes == null || indexes.Count == 0;
			if (!flag)
			{
				foreach (int num in indexes)
				{
					this.AddToSelectionWithoutValidation(num);
				}
				this.NotifyOfSelectionChange();
				base.SaveViewData();
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000046F0 File Offset: 0x000028F0
		public void AddToSelectionWithoutValidation(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000A508 File Offset: 0x00008708
		public void RemoveFromSelection(int index)
		{
			bool flag = !this.HasValidDataAndBindings();
			if (!flag)
			{
				this.RemoveFromSelectionWithoutValidation(index);
				this.NotifyOfSelectionChange();
				base.SaveViewData();
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000046FD File Offset: 0x000028FD
		public void RemoveFromSelectionWithoutValidation(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000470A File Offset: 0x0000290A
		public void SetSelection(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00004717 File Offset: 0x00002917
		public void SetSelection(IEnumerable<int> indices)
		{
			this.SetSelectionInternal(indices, true);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00004723 File Offset: 0x00002923
		public void SetSelectionWithoutNotify(IEnumerable<int> indices)
		{
			this.SetSelectionInternal(indices, false);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000A53C File Offset: 0x0000873C
		public void SetSelectionInternal(IEnumerable<int> indices, bool sendNotification)
		{
			bool flag = !this.HasValidDataAndBindings() || indices == null;
			if (!flag)
			{
				this.ClearSelectionWithoutValidation();
				foreach (int num in indices)
				{
					this.AddToSelectionWithoutValidation(num);
				}
				if (sendNotification)
				{
					this.NotifyOfSelectionChange();
				}
				base.SaveViewData();
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000472F File Offset: 0x0000292F
		public void NotifyOfSelectionChange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000473C File Offset: 0x0000293C
		public void ClearSelection()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00004749 File Offset: 0x00002949
		public void ClearSelectionWithoutValidation()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00004756 File Offset: 0x00002956
		public void ScrollTo(VisualElement visualElement)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00004763 File Offset: 0x00002963
		public void SetDragAndDropController(IListViewDragAndDropController dragAndDropController)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00004770 File Offset: 0x00002970
		public IListViewDragAndDropController GetDragAndDropController()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000A5B8 File Offset: 0x000087B8
		public override void OnViewDataReady()
		{
			base.OnViewDataReady();
			string fullHierarchicalViewDataKey = base.GetFullHierarchicalViewDataKey();
			base.OverwriteFromViewData(this, fullHierarchicalViewDataKey);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000477D File Offset: 0x0000297D
		public override void ExecuteDefaultAction(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000478A File Offset: 0x0000298A
		public void OnScroll(float offset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00004797 File Offset: 0x00002997
		public bool HasValidDataAndBindings()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000047A4 File Offset: 0x000029A4
		public void Refresh()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000047B1 File Offset: 0x000029B1
		public void ResizeHeight(float height)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000047BE File Offset: 0x000029BE
		public void Setup(ListView.RecycledItem recycledItem, int newIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000047CB File Offset: 0x000029CB
		public void OnFocus(VisualElement leafTarget)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000047D8 File Offset: 0x000029D8
		public void HandleFocus(ListView.RecycledItem recycledItem, int previousIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000047E5 File Offset: 0x000029E5
		public void UpdateBackground()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000A5E0 File Offset: 0x000087E0
		public void OnSizeChanged(GeometryChangedEvent evt)
		{
			bool flag = !this.HasValidDataAndBindings();
			if (!flag)
			{
				bool flag2 = Mathf.Approximately(evt.newRect.height, evt.oldRect.height);
				if (!flag2)
				{
					this.ResizeHeight(evt.newRect.height);
				}
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000047F2 File Offset: 0x000029F2
		public void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000047FF File Offset: 0x000029FF
		public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00004802 File Offset: 0x00002A02
		public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			this.Refresh();
		}

		// Token: 0x040000A9 RID: 169
		public const int k_ExtraVisibleItems = 2;

		// Token: 0x020001D4 RID: 468
		public new class UxmlFactory : UxmlFactory<ListView, ListView.UxmlTraits>
		{
		}

		// Token: 0x020001D5 RID: 469
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x02000221 RID: 545
			public new sealed class <get_uxmlChildElementsDescription>d__8
			{
			}
		}

		// Token: 0x020001D6 RID: 470
		public class RecycledItem
		{
		}
	}
}
