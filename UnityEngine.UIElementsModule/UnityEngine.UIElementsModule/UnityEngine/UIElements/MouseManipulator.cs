using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200002A RID: 42
	public abstract class MouseManipulator : Manipulator
	{
		// Token: 0x060000AB RID: 171 RVA: 0x000027AE File Offset: 0x000009AE
		public bool CanStartManipulation(IMouseEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000027BB File Offset: 0x000009BB
		public bool CanStopManipulation(IMouseEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
