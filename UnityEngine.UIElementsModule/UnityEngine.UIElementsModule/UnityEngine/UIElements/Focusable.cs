using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001A RID: 26
	public abstract class Focusable : CallbackEventHandler
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002458 File Offset: 0x00000658
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002465 File Offset: 0x00000665
		public bool focusable
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

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002472 File Offset: 0x00000672
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0000247F File Offset: 0x0000067F
		public int tabIndex
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

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000248C File Offset: 0x0000068C
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002499 File Offset: 0x00000699
		public bool delegatesFocus
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

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000024A6 File Offset: 0x000006A6
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000024B3 File Offset: 0x000006B3
		public bool excludeFromFocusRing
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

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000024C0 File Offset: 0x000006C0
		public virtual bool canGrabFocus
		{
			get
			{
				return this.focusable;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000086B4 File Offset: 0x000068B4
		public virtual void Focus()
		{
			bool flag = this.focusController != null;
			if (flag)
			{
				bool canGrabFocus = this.canGrabFocus;
				if (canGrabFocus)
				{
					Focusable focusDelegate = this.GetFocusDelegate();
					this.focusController.SwitchFocus(focusDelegate, this != focusDelegate);
				}
				else
				{
					this.focusController.SwitchFocus(null, false);
				}
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000870C File Offset: 0x0000690C
		public virtual void Blur()
		{
			bool flag = this.focusController != null;
			if (flag)
			{
				bool flag2 = this.focusController.IsFocused(this);
				if (flag2)
				{
					this.focusController.SwitchFocus(null, false);
				}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000874C File Offset: 0x0000694C
		public Focusable GetFocusDelegate()
		{
			Focusable focusable = this;
			while (focusable != null && focusable.delegatesFocus)
			{
				focusable = Focusable.GetFirstFocusableChild(focusable.TryCast<VisualElement>());
			}
			return focusable;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000024C8 File Offset: 0x000006C8
		public static Focusable GetFirstFocusableChild(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00008784 File Offset: 0x00006984
		public override void ExecuteDefaultAction(EventBase evt)
		{
			base.ExecuteDefaultAction(evt);
			bool flag = evt != null && evt.target == evt.leafTarget;
			if (flag)
			{
				FocusController focusController = this.focusController;
				if (focusController != null)
				{
					focusController.SwitchFocusOnEvent(evt);
				}
			}
		}
	}
}
