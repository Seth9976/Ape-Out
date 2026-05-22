using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000090 RID: 144
	public class SliderInt : BaseSlider<int>
	{
		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00004C59 File Offset: 0x00002E59
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00004C66 File Offset: 0x00002E66
		public override float pageSize
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

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000B1A8 File Offset: 0x000093A8
		public override int SliderLerpUnclamped(int a, int b, float interpolant)
		{
			return Mathf.RoundToInt(Mathf.LerpUnclamped((float)a, (float)b, interpolant));
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000B1CC File Offset: 0x000093CC
		public override float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue)
		{
			return ((float)currentValue - (float)lowerValue) / ((float)higherValue - (float)lowerValue);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00004C73 File Offset: 0x00002E73
		public override int SliderRange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000B1EC File Offset: 0x000093EC
		public override int ParseStringToValue(string stringValue)
		{
			int num;
			bool flag = Int32.TryParse(stringValue, out num);
			int num2;
			if (flag)
			{
				num2 = num;
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00004C80 File Offset: 0x00002E80
		public override void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000B1 RID: 177
		public const int kDefaultHighValue = 10;

		// Token: 0x020001E5 RID: 485
		public class UxmlFactory : UxmlFactory<SliderInt, SliderInt.UxmlTraits>
		{
		}

		// Token: 0x020001E6 RID: 486
		public class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription>
		{
		}
	}
}
