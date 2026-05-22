using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F2 RID: 242
	public sealed class PointerDownEvent : PointerEventBase<PointerDownEvent>
	{
		// Token: 0x06000565 RID: 1381 RVA: 0x00005C3F File Offset: 0x00003E3F
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00005C4C File Offset: 0x00003E4C
		public void LocalInit()
		{
			this.recomputeTopElementUnderPointer = true;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00005C57 File Offset: 0x00003E57
		public override void PostDispatch(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
