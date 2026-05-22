using System;
using System.Runtime.InteropServices;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001D RID: 29
	public class FocusController
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002522 File Offset: 0x00000722
		public IFocusRing focusRing
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000252F File Offset: 0x0000072F
		public Focusable focusedElement
		{
			get
			{
				return this.GetRetargetedFocusedElement(null);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002538 File Offset: 0x00000738
		public bool IsFocused(Focusable f)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002545 File Offset: 0x00000745
		public Focusable GetRetargetedFocusedElement(VisualElement retargetAgainst)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002552 File Offset: 0x00000752
		public Focusable GetLeafFocusedElement()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000255F File Offset: 0x0000075F
		public void SetFocusToLastFocusedElement()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000256C File Offset: 0x0000076C
		public void BlurLastFocusedElement()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002579 File Offset: 0x00000779
		public void DoFocusChange(Focusable f)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002586 File Offset: 0x00000786
		public void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002593 File Offset: 0x00000793
		public void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000025A0 File Offset: 0x000007A0
		public void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000025AD File Offset: 0x000007AD
		public void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, [Optional] bool bIsFocusDelegated)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000025BA File Offset: 0x000007BA
		public void SwitchFocus(Focusable newFocusedElement, [Optional] bool bIsFocusDelegated)
		{
			this.SwitchFocus(newFocusedElement, FocusChangeDirection.unspecified, bIsFocusDelegated);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000087C8 File Offset: 0x000069C8
		public void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction, [Optional] bool bIsFocusDelegated)
		{
			bool flag = this.GetLeafFocusedElement() == newFocusedElement;
			if (!flag)
			{
				Focusable leafFocusedElement = this.GetLeafFocusedElement();
				bool flag2 = newFocusedElement == null || !newFocusedElement.canGrabFocus;
				if (flag2)
				{
					bool flag3 = leafFocusedElement != null;
					if (flag3)
					{
						this.AboutToReleaseFocus(leafFocusedElement, null, direction);
						this.ReleaseFocus(leafFocusedElement, null, direction);
					}
				}
				else
				{
					bool flag4 = newFocusedElement != leafFocusedElement;
					if (flag4)
					{
						VisualElement visualElement = newFocusedElement.TryCast<VisualElement>();
						VisualElement visualElement2 = ((visualElement != null) ? visualElement.RetargetElement(leafFocusedElement.TryCast<VisualElement>()) : null);
						VisualElement visualElement3 = leafFocusedElement.TryCast<VisualElement>();
						VisualElement visualElement4 = ((visualElement3 != null) ? visualElement3.RetargetElement(newFocusedElement.TryCast<VisualElement>()) : null);
						bool flag5 = leafFocusedElement != null;
						if (flag5)
						{
							this.AboutToReleaseFocus(leafFocusedElement, visualElement2, direction);
						}
						this.AboutToGrabFocus(newFocusedElement, visualElement4, direction);
						bool flag6 = leafFocusedElement != null;
						if (flag6)
						{
							this.ReleaseFocus(leafFocusedElement, visualElement2, direction);
						}
						this.GrabFocus(newFocusedElement, visualElement4, direction, bIsFocusDelegated);
					}
				}
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000088B0 File Offset: 0x00006AB0
		public Focusable SwitchFocusOnEvent(EventBase e)
		{
			bool processedByFocusController = e.processedByFocusController;
			Focusable focusable;
			if (processedByFocusController)
			{
				focusable = this.GetLeafFocusedElement();
			}
			else
			{
				using (FocusChangeDirection focusChangeDirection = this.focusRing.GetFocusChangeDirection(this.GetLeafFocusedElement(), e))
				{
					bool flag = focusChangeDirection != FocusChangeDirection.none;
					if (flag)
					{
						Focusable nextFocusable = this.focusRing.GetNextFocusable(this.GetLeafFocusedElement(), focusChangeDirection);
						focusChangeDirection.ApplyTo(this, nextFocusable);
						e.processedByFocusController = true;
						return nextFocusable;
					}
				}
				focusable = this.GetLeafFocusedElement();
			}
			return focusable;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000025CB File Offset: 0x000007CB
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000025D8 File Offset: 0x000007D8
		public int imguiKeyboardControl
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

		// Token: 0x0600007F RID: 127 RVA: 0x00008948 File Offset: 0x00006B48
		public void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch)
		{
			this.imguiKeyboardControl = imguiKeyboardControlID;
			bool flag = forceSwitch || this.imguiKeyboardControl != 0;
			if (flag)
			{
				this.SwitchFocus(imguiContainerHavingKeyboardControl, FocusChangeDirection.unspecified, false);
			}
			else
			{
				this.SwitchFocus(null, FocusChangeDirection.unspecified, false);
			}
		}
	}
}
