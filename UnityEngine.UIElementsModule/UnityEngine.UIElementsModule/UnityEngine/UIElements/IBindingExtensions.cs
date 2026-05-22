using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200007D RID: 125
	public static class IBindingExtensions
	{
		// Token: 0x060002FF RID: 767 RVA: 0x0000A330 File Offset: 0x00008530
		public static bool IsBound(IBindable control)
		{
			return ((control != null) ? control.binding : null) != null;
		}
	}
}
