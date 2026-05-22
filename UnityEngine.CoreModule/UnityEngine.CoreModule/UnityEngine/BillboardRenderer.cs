using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000206 RID: 518
	public sealed class BillboardRenderer : Renderer
	{
		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x00075348 File Offset: 0x00073548
		// (set) Token: 0x060020C0 RID: 8384 RVA: 0x0001116B File Offset: 0x0000F36B
		public BillboardAsset billboard
		{
			get
			{
				IntPtr intPtr = BillboardRenderer.get_billboardDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BillboardAsset>(intPtr2) : null;
			}
			set
			{
				BillboardRenderer.set_billboardDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AA3 RID: 6819
		private static readonly BillboardRenderer.get_billboardDelegate get_billboardDelegateField = IL2CPP.ResolveICall<BillboardRenderer.get_billboardDelegate>("UnityEngine.BillboardRenderer::get_billboard");

		// Token: 0x04001AA4 RID: 6820
		private static readonly BillboardRenderer.set_billboardDelegate set_billboardDelegateField = IL2CPP.ResolveICall<BillboardRenderer.set_billboardDelegate>("UnityEngine.BillboardRenderer::set_billboard");

		// Token: 0x02000B00 RID: 2816
		// (Invoke) Token: 0x06003462 RID: 13410
		private delegate IntPtr get_billboardDelegate(IntPtr @this);

		// Token: 0x02000B01 RID: 2817
		// (Invoke) Token: 0x06003464 RID: 13412
		private delegate void set_billboardDelegate(IntPtr @this, IntPtr value);
	}
}
