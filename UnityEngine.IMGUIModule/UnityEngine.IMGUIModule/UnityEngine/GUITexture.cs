using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000028 RID: 40
	public sealed class GUITexture
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x00004774 File Offset: 0x00002974
		public static void FeatureRemoved()
		{
			throw new Exception("GUITexture has been removed from Unity. Use UI.Image instead.");
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x00017EEC File Offset: 0x000160EC
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x00004781 File Offset: 0x00002981
		public Color color
		{
			get
			{
				GUITexture.FeatureRemoved();
				return new Color(0f, 0f, 0f);
			}
			set
			{
				GUITexture.FeatureRemoved();
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00017F18 File Offset: 0x00016118
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x0000478A File Offset: 0x0000298A
		public Texture texture
		{
			get
			{
				GUITexture.FeatureRemoved();
				return null;
			}
			set
			{
				GUITexture.FeatureRemoved();
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00017F34 File Offset: 0x00016134
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00004793 File Offset: 0x00002993
		public Rect pixelInset
		{
			get
			{
				GUITexture.FeatureRemoved();
				return default(Rect);
			}
			set
			{
				GUITexture.FeatureRemoved();
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00017F58 File Offset: 0x00016158
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x0000479C File Offset: 0x0000299C
		public RectOffset border
		{
			get
			{
				GUITexture.FeatureRemoved();
				return null;
			}
			set
			{
				GUITexture.FeatureRemoved();
			}
		}
	}
}
