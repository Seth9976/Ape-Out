using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200008D RID: 141
	public class ScrollView : VisualElement
	{
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0000495E File Offset: 0x00002B5E
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0000496B File Offset: 0x00002B6B
		public bool showHorizontal
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

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00004978 File Offset: 0x00002B78
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00004985 File Offset: 0x00002B85
		public bool showVertical
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

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0000A6D8 File Offset: 0x000088D8
		public bool needsHorizontal
		{
			get
			{
				return this.showHorizontal || this.scrollableWidth > 0f;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0000A704 File Offset: 0x00008904
		public bool needsVertical
		{
			get
			{
				return this.showVertical || this.scrollableHeight > 0f;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000A730 File Offset: 0x00008930
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x0000A760 File Offset: 0x00008960
		public Vector2 scrollOffset
		{
			get
			{
				return new Vector2(this.horizontalScroller.value, this.verticalScroller.value);
			}
			set
			{
				bool flag = value != this.scrollOffset;
				if (flag)
				{
					this.horizontalScroller.value = value.x;
					this.verticalScroller.value = value.y;
					this.UpdateContentViewTransform();
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00004992 File Offset: 0x00002B92
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x0000499F File Offset: 0x00002B9F
		public float horizontalPageSize
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

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x000049AC File Offset: 0x00002BAC
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x000049B9 File Offset: 0x00002BB9
		public float verticalPageSize
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000A7AC File Offset: 0x000089AC
		public float scrollableWidth
		{
			get
			{
				return this.contentContainer.layout.width - this.contentViewport.layout.width;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x0000A7E8 File Offset: 0x000089E8
		public float scrollableHeight
		{
			get
			{
				return this.contentContainer.layout.height - this.contentViewport.layout.height;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003AA RID: 938 RVA: 0x000049C6 File Offset: 0x00002BC6
		public bool hasInertia
		{
			get
			{
				return this.scrollDecelerationRate > 0f;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003AB RID: 939 RVA: 0x000049D5 File Offset: 0x00002BD5
		// (set) Token: 0x060003AC RID: 940 RVA: 0x000049E2 File Offset: 0x00002BE2
		public float scrollDecelerationRate
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003AD RID: 941 RVA: 0x000049EF File Offset: 0x00002BEF
		// (set) Token: 0x060003AE RID: 942 RVA: 0x000049FC File Offset: 0x00002BFC
		public float elasticity
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00004A09 File Offset: 0x00002C09
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00004A16 File Offset: 0x00002C16
		public ScrollView.TouchScrollBehavior touchScrollBehavior
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

		// Token: 0x060003B1 RID: 945 RVA: 0x0000A824 File Offset: 0x00008A24
		public void UpdateContentViewTransform()
		{
			Vector3 position = this.contentContainer.transform.position;
			Vector2 scrollOffset = this.scrollOffset;
			bool needsVertical = this.needsVertical;
			if (needsVertical)
			{
				scrollOffset.y += this.contentContainer.resolvedStyle.top;
			}
			position.x = GUIUtility.RoundToPixelGrid(-scrollOffset.x);
			position.y = GUIUtility.RoundToPixelGrid(-scrollOffset.y);
			this.contentContainer.transform.position = position;
			base.IncrementVersion(VersionChangeType.Repaint);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		public void ScrollTo(VisualElement child)
		{
			bool flag = child == null;
			if (flag)
			{
				throw new ArgumentNullException("child");
			}
			bool flag2 = !this.contentContainer.Contains(child);
			if (flag2)
			{
				throw new ArgumentException("Cannot scroll to a VisualElement that is not a child of the ScrollView content-container.");
			}
			float num = 0f;
			float num2 = 0f;
			bool flag3 = this.scrollableHeight > 0f;
			if (flag3)
			{
				num = this.GetYDeltaOffset(child);
				this.verticalScroller.value = this.scrollOffset.y + num;
			}
			bool flag4 = this.scrollableWidth > 0f;
			if (flag4)
			{
				num2 = this.GetXDeltaOffset(child);
				this.horizontalScroller.value = this.scrollOffset.x + num2;
			}
			bool flag5 = num == 0f && num2 == 0f;
			if (!flag5)
			{
				this.UpdateContentViewTransform();
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000A990 File Offset: 0x00008B90
		public float GetXDeltaOffset(VisualElement child)
		{
			float num = this.contentContainer.transform.position.x * -1f;
			Rect worldBound = this.contentViewport.worldBound;
			float num2 = worldBound.xMin + num;
			float num3 = worldBound.xMax + num;
			Rect worldBound2 = child.worldBound;
			float num4 = worldBound2.xMin + num;
			float num5 = worldBound2.xMax + num;
			bool flag = (num4 >= num2 && num5 <= num3) || Single.IsNaN(num4) || Single.IsNaN(num5);
			float num6;
			if (flag)
			{
				num6 = 0f;
			}
			else
			{
				float deltaDistance = this.GetDeltaDistance(num2, num3, num4, num5);
				num6 = deltaDistance * this.horizontalScroller.highValue / this.scrollableWidth;
			}
			return num6;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000AA50 File Offset: 0x00008C50
		public float GetYDeltaOffset(VisualElement child)
		{
			float num = this.contentContainer.transform.position.y * -1f;
			Rect worldBound = this.contentViewport.worldBound;
			float num2 = worldBound.yMin + num;
			float num3 = worldBound.yMax + num;
			Rect worldBound2 = child.worldBound;
			float num4 = worldBound2.yMin + num;
			float num5 = worldBound2.yMax + num;
			bool flag = (num4 >= num2 && num5 <= num3) || Single.IsNaN(num4) || Single.IsNaN(num5);
			float num6;
			if (flag)
			{
				num6 = 0f;
			}
			else
			{
				float deltaDistance = this.GetDeltaDistance(num2, num3, num4, num5);
				num6 = deltaDistance * this.verticalScroller.highValue / this.scrollableHeight;
			}
			return num6;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000AB10 File Offset: 0x00008D10
		public float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax)
		{
			float num = viewMax - viewMin;
			float num2 = childBoundaryMax - childBoundaryMin;
			bool flag = num2 > num;
			float num3;
			if (flag)
			{
				bool flag2 = viewMin > childBoundaryMin && childBoundaryMax > viewMax;
				if (flag2)
				{
					num3 = 0f;
				}
				else
				{
					num3 = ((childBoundaryMin > viewMin) ? (childBoundaryMin - viewMin) : (childBoundaryMax - viewMax));
				}
			}
			else
			{
				float num4 = childBoundaryMax - viewMax;
				bool flag3 = num4 < -1f;
				if (flag3)
				{
					num4 = childBoundaryMin - viewMin;
				}
				num3 = num4;
			}
			return num3;
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00004A23 File Offset: 0x00002C23
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00004A30 File Offset: 0x00002C30
		public VisualElement contentViewport
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00004A3D File Offset: 0x00002C3D
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00004A4A File Offset: 0x00002C4A
		public Scroller horizontalScroller
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00004A57 File Offset: 0x00002C57
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00004A64 File Offset: 0x00002C64
		public Scroller verticalScroller
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00004A71 File Offset: 0x00002C71
		public override VisualElement contentContainer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00004A7E File Offset: 0x00002C7E
		public void SetScrollViewMode(ScrollViewMode scrollViewMode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00004A8B File Offset: 0x00002C8B
		public void OnAttachToPanel(AttachToPanelEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00004A98 File Offset: 0x00002C98
		public void OnDetachFromPanel(DetachFromPanelEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000AB7C File Offset: 0x00008D7C
		public void OnGeometryChanged(GeometryChangedEvent evt)
		{
			bool flag = evt.oldRect.size == evt.newRect.size;
			if (!flag)
			{
				bool flag2 = this.needsVertical;
				bool flag3 = this.needsHorizontal;
				bool flag4 = evt.layoutPass > 0;
				if (flag4)
				{
					flag2 = flag2 || this.verticalScroller.visible;
					flag3 = flag3 || this.horizontalScroller.visible;
				}
				this.UpdateScrollers(flag3, flag2);
				this.UpdateContentViewTransform();
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000AC08 File Offset: 0x00008E08
		public static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit)
		{
			initialScrollOffset = Mathf.Max(initialScrollOffset, hardLowLimit * 0.95f);
			initialScrollOffset = Mathf.Min(initialScrollOffset, hardHighLimit * 0.95f);
			bool flag = initialScrollOffset < lowLimit && hardLowLimit < lowLimit;
			float num;
			float num3;
			if (flag)
			{
				num = lowLimit - hardLowLimit;
				float num2 = (lowLimit - initialScrollOffset) / num;
				num3 = num2 * num / (1f - num2);
				num3 += deltaPointer;
				initialScrollOffset = lowLimit;
			}
			else
			{
				bool flag2 = initialScrollOffset > highLimit && hardHighLimit > highLimit;
				if (flag2)
				{
					num = hardHighLimit - highLimit;
					float num4 = (initialScrollOffset - highLimit) / num;
					num3 = -1f * num4 * num / (1f - num4);
					num3 += deltaPointer;
					initialScrollOffset = highLimit;
				}
				else
				{
					num3 = deltaPointer;
				}
			}
			float num5 = initialScrollOffset - num3;
			bool flag3 = num5 < lowLimit;
			float num6;
			if (flag3)
			{
				num3 = lowLimit - num5;
				initialScrollOffset = lowLimit;
				num = lowLimit - hardLowLimit;
				num6 = 1f;
			}
			else
			{
				bool flag4 = num5 <= highLimit;
				if (flag4)
				{
					return num5;
				}
				num3 = num5 - highLimit;
				initialScrollOffset = highLimit;
				num = hardHighLimit - highLimit;
				num6 = -1f;
			}
			bool flag5 = Mathf.Abs(num3) < 1E-30f;
			float num7;
			if (flag5)
			{
				num7 = initialScrollOffset;
			}
			else
			{
				float num8 = num3 / (num3 + num);
				num8 *= num;
				num8 *= num6;
				num5 = initialScrollOffset - num8;
				num7 = num5;
			}
			return num7;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00004AA5 File Offset: 0x00002CA5
		public void ComputeInitialSpringBackVelocity()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00004AB2 File Offset: 0x00002CB2
		public void SpringBack()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00004ABF File Offset: 0x00002CBF
		public void ApplyScrollInertia()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00004ACC File Offset: 0x00002CCC
		public void PostPointerUpAnimation()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00004AD9 File Offset: 0x00002CD9
		public void OnPointerDown(PointerDownEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00004AE6 File Offset: 0x00002CE6
		public void OnPointerMove(PointerMoveEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00004AF3 File Offset: 0x00002CF3
		public void OnPointerUp(PointerUpEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000AD38 File Offset: 0x00008F38
		public void UpdateScrollers(bool displayHorizontal, bool displayVertical)
		{
			float num = ((this.contentContainer.layout.width > 1E-30f) ? (this.contentViewport.layout.width / this.contentContainer.layout.width) : 1f);
			float num2 = ((this.contentContainer.layout.height > 1E-30f) ? (this.contentViewport.layout.height / this.contentContainer.layout.height) : 1f);
			this.horizontalScroller.Adjust(num);
			this.verticalScroller.Adjust(num2);
			this.horizontalScroller.SetEnabled(this.contentContainer.layout.width - this.contentViewport.layout.width > 0f);
			this.verticalScroller.SetEnabled(this.contentContainer.layout.height - this.contentViewport.layout.height > 0f);
			this.contentViewport.style.marginRight = (displayVertical ? this.verticalScroller.layout.width : 0f);
			this.horizontalScroller.style.right = (displayVertical ? this.verticalScroller.layout.width : 0f);
			this.contentViewport.style.marginBottom = (displayHorizontal ? this.horizontalScroller.layout.height : 0f);
			this.verticalScroller.style.bottom = (displayHorizontal ? this.horizontalScroller.layout.height : 0f);
			bool flag = displayHorizontal && this.scrollableWidth > 0f;
			if (flag)
			{
				this.horizontalScroller.lowValue = 0f;
				this.horizontalScroller.highValue = this.scrollableWidth;
			}
			else
			{
				this.horizontalScroller.value = 0f;
			}
			bool flag2 = displayVertical && this.scrollableHeight > 0f;
			if (flag2)
			{
				this.verticalScroller.lowValue = 0f;
				this.verticalScroller.highValue = this.scrollableHeight;
			}
			else
			{
				this.verticalScroller.value = 0f;
			}
			bool flag3 = this.horizontalScroller.visible != displayHorizontal;
			if (flag3)
			{
				this.horizontalScroller.visible = displayHorizontal;
			}
			bool flag4 = this.verticalScroller.visible != displayVertical;
			if (flag4)
			{
				this.verticalScroller.visible = displayVertical;
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000B024 File Offset: 0x00009224
		public void OnScrollWheel(WheelEvent evt)
		{
			float value = this.verticalScroller.value;
			bool flag = this.contentContainer.layout.height - base.layout.height > 0f;
			if (flag)
			{
				bool flag2 = evt.delta.y < 0f;
				if (flag2)
				{
					this.verticalScroller.ScrollPageUp(Mathf.Abs(evt.delta.y));
				}
				else
				{
					bool flag3 = evt.delta.y > 0f;
					if (flag3)
					{
						this.verticalScroller.ScrollPageDown(Mathf.Abs(evt.delta.y));
					}
				}
			}
			bool flag4 = this.verticalScroller.value != value;
			if (flag4)
			{
				evt.StopPropagation();
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00004B00 File Offset: 0x00002D00
		public void <.ctor>b__74_0(float value)
		{
			this.scrollOffset = new Vector2(value, this.scrollOffset.y);
			this.UpdateContentViewTransform();
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00004B22 File Offset: 0x00002D22
		public void <.ctor>b__74_1(float value)
		{
			this.scrollOffset = new Vector2(this.scrollOffset.x, value);
			this.UpdateContentViewTransform();
		}

		// Token: 0x020001DE RID: 478
		public new class UxmlFactory : UxmlFactory<ScrollView, ScrollView.UxmlTraits>
		{
		}

		// Token: 0x020001DF RID: 479
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
		}

		// Token: 0x020001E0 RID: 480
		public enum TouchScrollBehavior
		{
			// Token: 0x04000242 RID: 578
			Unrestricted,
			// Token: 0x04000243 RID: 579
			Elastic,
			// Token: 0x04000244 RID: 580
			Clamped
		}
	}
}
