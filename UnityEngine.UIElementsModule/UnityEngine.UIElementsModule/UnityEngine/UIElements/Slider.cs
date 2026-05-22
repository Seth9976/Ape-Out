using System;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x0200008F RID: 143
	public class Slider : BaseSlider<float>
	{
		// Token: 0x060003E2 RID: 994 RVA: 0x0000B11C File Offset: 0x0000931C
		public override float SliderLerpUnclamped(float a, float b, float interpolant)
		{
			return (float)Mathf.RoundToInt(Mathf.LerpUnclamped(a, b, interpolant) * 100f) / 100f;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000B148 File Offset: 0x00009348
		public override float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
		{
			return (currentValue - lowerValue) / (higherValue - lowerValue);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00004C4C File Offset: 0x00002E4C
		public override float SliderRange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000B164 File Offset: 0x00009364
		public override float ParseStringToValue(string stringValue)
		{
			float num;
			bool flag = Single.TryParse(stringValue.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out num);
			float num2;
			if (flag)
			{
				num2 = num;
			}
			else
			{
				num2 = 0f;
			}
			return num2;
		}

		// Token: 0x040000B0 RID: 176
		public const float kDefaultHighValue = 10f;

		// Token: 0x020001E3 RID: 483
		public class UxmlFactory : UxmlFactory<Slider, Slider.UxmlTraits>
		{
		}

		// Token: 0x020001E4 RID: 484
		public class UxmlTraits : BaseFieldTraits<float, UxmlFloatAttributeDescription>
		{
		}
	}
}
