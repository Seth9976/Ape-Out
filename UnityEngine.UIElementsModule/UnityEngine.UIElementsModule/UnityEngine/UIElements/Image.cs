using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000084 RID: 132
	public class Image : VisualElement
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00004338 File Offset: 0x00002538
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00004345 File Offset: 0x00002545
		public Texture image
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00004352 File Offset: 0x00002552
		// (set) Token: 0x06000315 RID: 789 RVA: 0x0000435F File Offset: 0x0000255F
		public VectorImage vectorImage
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0000A3A0 File Offset: 0x000085A0
		// (set) Token: 0x06000317 RID: 791 RVA: 0x0000436C File Offset: 0x0000256C
		public Rect sourceRect
		{
			get
			{
				return this.GetSourceRect();
			}
			set
			{
				this.CalculateUV(value);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00004377 File Offset: 0x00002577
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00004384 File Offset: 0x00002584
		public Rect uv
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00004391 File Offset: 0x00002591
		// (set) Token: 0x0600031B RID: 795 RVA: 0x0000439E File Offset: 0x0000259E
		public ScaleMode scaleMode
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600031C RID: 796 RVA: 0x000043AB File Offset: 0x000025AB
		// (set) Token: 0x0600031D RID: 797 RVA: 0x000043B8 File Offset: 0x000025B8
		public Color tintColor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000A3B8 File Offset: 0x000085B8
		public Vector2 GetTextureDisplaySize(Texture texture)
		{
			Vector2 zero = Vector2.zero;
			bool flag = texture != null;
			if (flag)
			{
				zero = new Vector2((float)texture.width, (float)texture.height);
			}
			return zero;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000043C5 File Offset: 0x000025C5
		public override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000043D2 File Offset: 0x000025D2
		public void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000043DF File Offset: 0x000025DF
		public void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000043EC File Offset: 0x000025EC
		public void CalculateUV(Rect srcRect)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000043F9 File Offset: 0x000025F9
		public Rect GetSourceRect()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001D0 RID: 464
		public new class UxmlFactory : UxmlFactory<Image, Image.UxmlTraits>
		{
		}

		// Token: 0x020001D1 RID: 465
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x02000220 RID: 544
			public sealed class <get_uxmlChildElementsDescription>d__1
			{
			}
		}
	}
}
