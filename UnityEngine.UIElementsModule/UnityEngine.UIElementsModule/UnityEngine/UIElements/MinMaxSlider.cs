using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000089 RID: 137
	public class MinMaxSlider : BaseField<Vector2>
	{
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0000480C File Offset: 0x00002A0C
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00004819 File Offset: 0x00002A19
		public VisualElement dragElement
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00004826 File Offset: 0x00002A26
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00004833 File Offset: 0x00002A33
		public VisualElement dragMinThumb
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00004840 File Offset: 0x00002A40
		// (set) Token: 0x06000383 RID: 899 RVA: 0x0000484D File Offset: 0x00002A4D
		public VisualElement dragMaxThumb
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

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000485A File Offset: 0x00002A5A
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00004867 File Offset: 0x00002A67
		public float minValue
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

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00004874 File Offset: 0x00002A74
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00004881 File Offset: 0x00002A81
		public float maxValue
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0000488E File Offset: 0x00002A8E
		// (set) Token: 0x06000389 RID: 905 RVA: 0x0000489B File Offset: 0x00002A9B
		public override Vector2 value
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

		// Token: 0x0600038A RID: 906 RVA: 0x000048A8 File Offset: 0x00002AA8
		public override void SetValueWithoutNotify(Vector2 newValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0000A63C File Offset: 0x0000883C
		public float range
		{
			get
			{
				return Math.Abs(this.highLimit - this.lowLimit);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600038C RID: 908 RVA: 0x000048B5 File Offset: 0x00002AB5
		// (set) Token: 0x0600038D RID: 909 RVA: 0x000048C2 File Offset: 0x00002AC2
		public float lowLimit
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

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600038E RID: 910 RVA: 0x000048CF File Offset: 0x00002ACF
		// (set) Token: 0x0600038F RID: 911 RVA: 0x000048DC File Offset: 0x00002ADC
		public float highLimit
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

		// Token: 0x06000390 RID: 912 RVA: 0x000048E9 File Offset: 0x00002AE9
		public Vector2 ClampValues(Vector2 valueToClamp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000A660 File Offset: 0x00008860
		public void UpdateDragElementPosition(GeometryChangedEvent evt)
		{
			bool flag = evt.oldRect.size == evt.newRect.size;
			if (!flag)
			{
				this.UpdateDragElementPosition();
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000048F6 File Offset: 0x00002AF6
		public void UpdateDragElementPosition()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000A6A0 File Offset: 0x000088A0
		public float SliderLerpUnclamped(float a, float b, float interpolant)
		{
			return Mathf.LerpUnclamped(a, b, interpolant);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000A6BC File Offset: 0x000088BC
		public float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
		{
			return (currentValue - lowerValue) / (higherValue - lowerValue);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00004903 File Offset: 0x00002B03
		public float ComputeValueFromPosition(float positionToConvert)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00004910 File Offset: 0x00002B10
		public override void ExecuteDefaultAction(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000491D File Offset: 0x00002B1D
		public void SetSliderValueFromDrag()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000492A File Offset: 0x00002B2A
		public void SetSliderValueFromClick()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00004937 File Offset: 0x00002B37
		public void ComputeValueDragStateNoThumb(float lowLimitPosition, float highLimitPosition, float dragElementPos)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00004944 File Offset: 0x00002B44
		public void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000AA RID: 170
		public const float kDefaultHighValue = 10f;

		// Token: 0x020001D7 RID: 471
		public class UxmlFactory : UxmlFactory<MinMaxSlider, MinMaxSlider.UxmlTraits>
		{
		}

		// Token: 0x020001D8 RID: 472
		public class UxmlTraits : BaseField<Vector2>.UxmlTraits
		{
		}

		// Token: 0x020001D9 RID: 473
		public enum DragState
		{
			// Token: 0x0400023D RID: 573
			NoThumb,
			// Token: 0x0400023E RID: 574
			MinThumb,
			// Token: 0x0400023F RID: 575
			MiddleThumb,
			// Token: 0x04000240 RID: 576
			MaxThumb
		}
	}
}
