using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F3 RID: 243
	public sealed class PointerMoveEvent : PointerEventBase<PointerMoveEvent>
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x00005C64 File Offset: 0x00003E64
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00005C71 File Offset: 0x00003E71
		public void LocalInit()
		{
			this.recomputeTopElementUnderPointer = true;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00005C7C File Offset: 0x00003E7C
		public override void PostDispatch(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
