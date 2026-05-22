using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000039 RID: 57
	public abstract class PointerManipulator : MouseManipulator
	{
		// Token: 0x0600012F RID: 303 RVA: 0x00002E67 File Offset: 0x00001067
		public bool CanStartManipulation(IPointerEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002E74 File Offset: 0x00001074
		public bool CanStopManipulation(IPointerEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
