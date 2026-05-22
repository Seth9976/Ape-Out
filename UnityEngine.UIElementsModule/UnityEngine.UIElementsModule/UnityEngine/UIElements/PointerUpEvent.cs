using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F5 RID: 245
	public sealed class PointerUpEvent : PointerEventBase<PointerUpEvent>
	{
		// Token: 0x0600056D RID: 1389 RVA: 0x00005CA1 File Offset: 0x00003EA1
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00005CAE File Offset: 0x00003EAE
		public void LocalInit()
		{
			this.recomputeTopElementUnderPointer = true;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00005CB9 File Offset: 0x00003EB9
		public override void PostDispatch(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
