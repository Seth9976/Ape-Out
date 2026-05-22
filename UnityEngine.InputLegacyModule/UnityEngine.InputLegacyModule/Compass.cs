using System;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	public class Compass
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00002450 File Offset: 0x00000650
		public float magneticHeading
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000245D File Offset: 0x0000065D
		public float trueHeading
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000246A File Offset: 0x0000066A
		public float headingAccuracy
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00002477 File Offset: 0x00000677
		public Vector3 rawVector
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002484 File Offset: 0x00000684
		public double timestamp
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00003D8C File Offset: 0x00001F8C
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002491 File Offset: 0x00000691
		public bool enabled
		{
			get
			{
				return LocationService.IsHeadingUpdatesEnabled();
			}
			set
			{
				LocationService.SetHeadingUpdatesEnabled(value);
			}
		}
	}
}
