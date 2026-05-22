using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200020C RID: 524
	public static class RendererExtensions
	{
		// Token: 0x060020E5 RID: 8421 RVA: 0x00011371 File Offset: 0x0000F571
		public static void UpdateGIMaterials(Renderer renderer)
		{
			RendererExtensions.UpdateGIMaterialsForRenderer(renderer);
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x0001137B File Offset: 0x0000F57B
		public static void UpdateGIMaterialsForRenderer(Renderer renderer)
		{
			RendererExtensions.UpdateGIMaterialsForRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x04001AC0 RID: 6848
		private static readonly RendererExtensions.UpdateGIMaterialsForRendererDelegate UpdateGIMaterialsForRendererDelegateField = IL2CPP.ResolveICall<RendererExtensions.UpdateGIMaterialsForRendererDelegate>("UnityEngine.RendererExtensions::UpdateGIMaterialsForRenderer");

		// Token: 0x02000B13 RID: 2835
		// (Invoke) Token: 0x06003488 RID: 13448
		private delegate void UpdateGIMaterialsForRendererDelegate(IntPtr renderer);
	}
}
