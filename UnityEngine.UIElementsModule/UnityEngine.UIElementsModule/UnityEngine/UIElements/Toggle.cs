using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000095 RID: 149
	public class Toggle : BaseField<bool>
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00004D5A File Offset: 0x00002F5A
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x00004D67 File Offset: 0x00002F67
		public string text
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

		// Token: 0x06000401 RID: 1025 RVA: 0x00004D74 File Offset: 0x00002F74
		public override void SetValueWithoutNotify(bool newValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00004D81 File Offset: 0x00002F81
		public void OnClickEvent(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00004D8E File Offset: 0x00002F8E
		public void OnClick()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000B274 File Offset: 0x00009474
		public override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
			base.ExecuteDefaultActionAtTarget(evt);
			bool flag = evt == null;
			if (!flag)
			{
				bool flag2 = base.eventInterpreter.IsActivationEvent(evt);
				if (flag2)
				{
					this.OnClick();
					evt.StopPropagation();
				}
			}
		}

		// Token: 0x020001EA RID: 490
		public class UxmlFactory : UxmlFactory<Toggle, Toggle.UxmlTraits>
		{
		}

		// Token: 0x020001EB RID: 491
		public class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription>
		{
		}
	}
}
