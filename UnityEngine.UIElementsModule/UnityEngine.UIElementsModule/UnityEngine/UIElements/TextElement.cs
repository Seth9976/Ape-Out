using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000050 RID: 80
	public class TextElement : BindableElement
	{
		// Token: 0x0600014D RID: 333 RVA: 0x00002FD0 File Offset: 0x000011D0
		public void OnAttachToPanel(AttachToPanelEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002FDD File Offset: 0x000011DD
		public void OnGeometryChanged(GeometryChangedEvent e)
		{
			this.UpdateVisibleText();
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00002FE7 File Offset: 0x000011E7
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002FF4 File Offset: 0x000011F4
		public virtual string text
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

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00003001 File Offset: 0x00001201
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0000300E File Offset: 0x0000120E
		public bool displayTooltipWhenElided
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000301B File Offset: 0x0000121B
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00003028 File Offset: 0x00001228
		public bool isElided
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

		// Token: 0x06000155 RID: 341 RVA: 0x00003035 File Offset: 0x00001235
		public void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00009130 File Offset: 0x00007330
		public string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition)
		{
			float num = base.resolvedStyle.paddingRight;
			bool flag = Single.IsNaN(num);
			if (flag)
			{
				num = 0f;
			}
			float num2 = Mathf.Clamp(num, 1f / base.scaledPixelsPerPoint, 1f);
			Vector2 vector = this.MeasureTextSize(drawText, 0f, VisualElement.MeasureMode.Undefined, 0f, VisualElement.MeasureMode.Undefined);
			bool flag2 = vector.x <= width + num2 || String.IsNullOrEmpty(ellipsisText);
			string text;
			if (flag2)
			{
				text = drawText;
			}
			else
			{
				string text2 = ((drawText.Length > 1) ? ellipsisText : drawText);
				Vector2 vector2 = this.MeasureTextSize(text2, 0f, VisualElement.MeasureMode.Undefined, 0f, VisualElement.MeasureMode.Undefined);
				bool flag3 = vector2.x >= width;
				if (flag3)
				{
					text = text2;
				}
				else
				{
					int num3 = drawText.Length - 1;
					int num4 = -1;
					string text3 = drawText;
					int i = ((textOverflowPosition == TextOverflowPosition.Start) ? 1 : 0);
					int num5 = ((textOverflowPosition == TextOverflowPosition.Start || textOverflowPosition == TextOverflowPosition.Middle) ? num3 : (num3 - 1));
					int num6 = (i + num5) / 2;
					while (i <= num5)
					{
						bool flag4 = textOverflowPosition == TextOverflowPosition.Start;
						if (flag4)
						{
							text3 = String.Concat(ellipsisText, drawText.Substring(num6, num3 - (num6 - 1)));
						}
						else
						{
							bool flag5 = textOverflowPosition == TextOverflowPosition.End;
							if (flag5)
							{
								text3 = String.Concat(drawText.Substring(0, num6), ellipsisText);
							}
							else
							{
								bool flag6 = textOverflowPosition == TextOverflowPosition.Middle;
								if (flag6)
								{
									text3 = String.Concat(drawText.Substring(0, num6 - 1), ellipsisText, drawText.Substring(num3 - (num6 - 1)));
								}
							}
						}
						vector = this.MeasureTextSize(text3, 0f, VisualElement.MeasureMode.Undefined, 0f, VisualElement.MeasureMode.Undefined);
						bool flag7 = Math.Abs(vector.x - width) < 1E-30f;
						if (flag7)
						{
							return text3;
						}
						bool flag8 = textOverflowPosition == TextOverflowPosition.Start;
						if (flag8)
						{
							bool flag9 = vector.x > width;
							if (flag9)
							{
								bool flag10 = num4 == num6 - 1;
								if (flag10)
								{
									return String.Concat(ellipsisText, drawText.Substring(num4, num3 - (num4 - 1)));
								}
								i = num6 + 1;
							}
							else
							{
								num5 = num6 - 1;
								num4 = num6;
							}
						}
						else
						{
							bool flag11 = textOverflowPosition == TextOverflowPosition.End || textOverflowPosition == TextOverflowPosition.Middle;
							if (flag11)
							{
								bool flag12 = vector.x > width;
								if (flag12)
								{
									bool flag13 = num4 == num6 - 1;
									if (flag13)
									{
										bool flag14 = textOverflowPosition == TextOverflowPosition.End;
										if (flag14)
										{
											return String.Concat(drawText.Substring(0, num4), ellipsisText);
										}
										return String.Concat(drawText.Substring(0, num4 - 1), ellipsisText, drawText.Substring(num3 - (num4 - 1)));
									}
									else
									{
										num5 = num6 - 1;
									}
								}
								else
								{
									i = num6 + 1;
									num4 = num6;
								}
							}
						}
						num6 = (i + num5) / 2;
					}
					text = text3;
				}
			}
			return text;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00003042 File Offset: 0x00001242
		public void UpdateTooltip()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000304F File Offset: 0x0000124F
		public void UpdateVisibleText()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000305C File Offset: 0x0000125C
		public Vector2 MeasureTextSize(string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000093D8 File Offset: 0x000075D8
		public override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			return this.MeasureTextSize(this.text, desiredWidth, widthMode, desiredHeight, heightMode);
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00003069 File Offset: 0x00001269
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00003076 File Offset: 0x00001276
		public string UnityEngine.UIElements.INotifyValueChanged<System.String>.value
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

		// Token: 0x0600015D RID: 349 RVA: 0x00003083 File Offset: 0x00001283
		public void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(string newValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001A8 RID: 424
		public new class UxmlFactory : UxmlFactory<TextElement, TextElement.UxmlTraits>
		{
		}

		// Token: 0x020001A9 RID: 425
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x0200021D RID: 541
			public sealed class <get_uxmlChildElementsDescription>d__3
			{
			}
		}
	}
}
