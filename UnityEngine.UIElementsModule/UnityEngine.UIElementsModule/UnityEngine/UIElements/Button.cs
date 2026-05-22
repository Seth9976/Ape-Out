using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200007F RID: 127
	public class Button : TextElement
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000425B File Offset: 0x0000245B
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00004268 File Offset: 0x00002468
		public Clickable clickable
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

		// Token: 0x06000302 RID: 770 RVA: 0x00004275 File Offset: 0x00002475
		public override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000A354 File Offset: 0x00008554
		public override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
			base.ExecuteDefaultActionAtTarget(evt);
			bool flag = evt == null;
			if (!flag)
			{
				bool flag2 = base.eventInterpreter.IsActivationEvent(evt);
				if (flag2)
				{
					this.clickable.SimulateSingleClick(evt, 100);
					evt.StopPropagation();
				}
			}
		}

		// Token: 0x020001CA RID: 458
		public new class UxmlFactory : UxmlFactory<Button, Button.UxmlTraits>
		{
		}

		// Token: 0x020001CB RID: 459
		public new class UxmlTraits : TextElement.UxmlTraits
		{
		}
	}
}
