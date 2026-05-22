using System;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine
{
	// Token: 0x02000203 RID: 515
	public struct Ray2D
	{
		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x00074F64 File Offset: 0x00073164
		// (set) Token: 0x06002095 RID: 8341 RVA: 0x00010F45 File Offset: 0x0000F145
		public Vector2 origin
		{
			get
			{
				return this.m_Origin;
			}
			set
			{
				this.m_Origin = value;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x00074F7C File Offset: 0x0007317C
		// (set) Token: 0x06002097 RID: 8343 RVA: 0x00010F4F File Offset: 0x0000F14F
		public Vector2 direction
		{
			get
			{
				return this.m_Direction;
			}
			set
			{
				this.m_Direction = value.normalized;
			}
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x00074F94 File Offset: 0x00073194
		public Vector2 GetPoint(float distance)
		{
			return this.m_Origin + this.m_Direction * distance;
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00074FC0 File Offset: 0x000731C0
		public override string ToString()
		{
			return this.ToString("F1", CultureInfo.InvariantCulture.NumberFormat);
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x00074FE8 File Offset: 0x000731E8
		public string ToString(string format)
		{
			return this.ToString(format, CultureInfo.InvariantCulture.NumberFormat);
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x00010F5F File Offset: 0x0000F15F
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001A88 RID: 6792
		public Vector2 m_Origin;

		// Token: 0x04001A89 RID: 6793
		public Vector2 m_Direction;
	}
}
