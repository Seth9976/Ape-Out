using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000062 RID: 98
	public class VisualElementFocusChangeTarget : FocusChangeDirection
	{
		// Token: 0x06000293 RID: 659 RVA: 0x00003D3C File Offset: 0x00001F3C
		public static VisualElementFocusChangeTarget GetPooled(Focusable target)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00003D49 File Offset: 0x00001F49
		public override void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00003D56 File Offset: 0x00001F56
		public override void ApplyTo(FocusController focusController, Focusable f)
		{
			f.Focus();
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00003D60 File Offset: 0x00001F60
		// (set) Token: 0x06000297 RID: 663 RVA: 0x00003D6D File Offset: 0x00001F6D
		public Focusable target
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
	}
}
