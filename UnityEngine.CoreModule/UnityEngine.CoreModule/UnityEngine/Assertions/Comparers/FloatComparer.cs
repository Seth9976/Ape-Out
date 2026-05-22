using System;
using Il2CppSystem;

namespace UnityEngine.Assertions.Comparers
{
	// Token: 0x020002DF RID: 735
	public class FloatComparer
	{
		// Token: 0x060023AD RID: 9133 RVA: 0x000132D6 File Offset: 0x000114D6
		public bool Equals(float a, float b)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x000794F0 File Offset: 0x000776F0
		public int GetHashCode(float obj)
		{
			return base.GetHashCode();
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x00079508 File Offset: 0x00077708
		public static bool AreEqual(float expected, float actual, float error)
		{
			return Math.Abs(actual - expected) <= error;
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00079528 File Offset: 0x00077728
		public static bool AreEqualRelative(float expected, float actual, float error)
		{
			bool flag = expected == actual;
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				float num = Math.Abs(expected);
				float num2 = Math.Abs(actual);
				float num3 = Math.Abs((actual - expected) / ((num > num2) ? num : num2));
				flag2 = num3 <= error;
			}
			return flag2;
		}

		// Token: 0x04001E45 RID: 7749
		public const float kEpsilon = 1E-05f;
	}
}
