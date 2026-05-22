using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.U2D
{
	// Token: 0x02000270 RID: 624
	public static class PixelPerfectRendering
	{
		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06002211 RID: 8721 RVA: 0x0001211B File Offset: 0x0001031B
		// (set) Token: 0x06002212 RID: 8722 RVA: 0x00012127 File Offset: 0x00010327
		public static float pixelSnapSpacing
		{
			get
			{
				return PixelPerfectRendering.get_pixelSnapSpacingDelegateField();
			}
			set
			{
				PixelPerfectRendering.set_pixelSnapSpacingDelegateField(value);
			}
		}

		// Token: 0x04001C2B RID: 7211
		private static readonly PixelPerfectRendering.get_pixelSnapSpacingDelegate get_pixelSnapSpacingDelegateField = IL2CPP.ResolveICall<PixelPerfectRendering.get_pixelSnapSpacingDelegate>("UnityEngine.U2D.PixelPerfectRendering::get_pixelSnapSpacing");

		// Token: 0x04001C2C RID: 7212
		private static readonly PixelPerfectRendering.set_pixelSnapSpacingDelegate set_pixelSnapSpacingDelegateField = IL2CPP.ResolveICall<PixelPerfectRendering.set_pixelSnapSpacingDelegate>("UnityEngine.U2D.PixelPerfectRendering::set_pixelSnapSpacing");

		// Token: 0x02000B9F RID: 2975
		// (Invoke) Token: 0x06003598 RID: 13720
		private delegate float get_pixelSnapSpacingDelegate();

		// Token: 0x02000BA0 RID: 2976
		// (Invoke) Token: 0x0600359A RID: 13722
		private delegate void set_pixelSnapSpacingDelegate(float value);
	}
}
