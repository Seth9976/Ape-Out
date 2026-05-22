using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002C0 RID: 704
	public enum SortingCriteria
	{
		// Token: 0x04001DC8 RID: 7624
		None,
		// Token: 0x04001DC9 RID: 7625
		SortingLayer,
		// Token: 0x04001DCA RID: 7626
		RenderQueue,
		// Token: 0x04001DCB RID: 7627
		BackToFront = 4,
		// Token: 0x04001DCC RID: 7628
		QuantizedFrontToBack = 8,
		// Token: 0x04001DCD RID: 7629
		OptimizeStateChanges = 16,
		// Token: 0x04001DCE RID: 7630
		CanvasOrder = 32,
		// Token: 0x04001DCF RID: 7631
		RendererPriority = 64,
		// Token: 0x04001DD0 RID: 7632
		CommonOpaque = 59,
		// Token: 0x04001DD1 RID: 7633
		CommonTransparent = 23
	}
}
