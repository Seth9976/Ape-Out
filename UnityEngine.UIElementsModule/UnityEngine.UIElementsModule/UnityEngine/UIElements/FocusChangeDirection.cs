using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001B RID: 27
	public class FocusChangeDirection
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000024D5 File Offset: 0x000006D5
		public static FocusChangeDirection unspecified
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000024E2 File Offset: 0x000006E2
		public static FocusChangeDirection none
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000024EF File Offset: 0x000006EF
		public static FocusChangeDirection lastValue
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000024FC File Offset: 0x000006FC
		public static implicit operator int(FocusChangeDirection fcd)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002509 File Offset: 0x00000709
		public void System.IDisposable.Dispose()
		{
			this.Dispose();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002512 File Offset: 0x00000712
		public virtual void Dispose()
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002515 File Offset: 0x00000715
		public virtual void ApplyTo(FocusController focusController, Focusable f)
		{
			focusController.SwitchFocus(f, this, false);
		}
	}
}
