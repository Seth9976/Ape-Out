using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000119 RID: 281
	public struct StyleColor
	{
		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x0000CFDC File Offset: 0x0000B1DC
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x00006A17 File Offset: 0x00004C17
		public Color value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : Color.clear;
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0000D004 File Offset: 0x0000B204
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x00006A28 File Offset: 0x00004C28
		public StyleKeyword keyword
		{
			get
			{
				return this.m_Keyword;
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0000D01C File Offset: 0x0000B21C
		public static bool operator ==(StyleColor lhs, StyleColor rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0000D050 File Offset: 0x0000B250
		public static bool operator !=(StyleColor lhs, StyleColor rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0000D06C File Offset: 0x0000B26C
		public static bool operator ==(StyleColor lhs, Color rhs)
		{
			StyleColor styleColor = new StyleColor(rhs);
			return lhs == styleColor;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0000D090 File Offset: 0x0000B290
		public static bool operator !=(StyleColor lhs, Color rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0000D0AC File Offset: 0x0000B2AC
		public static implicit operator StyleColor(StyleKeyword keyword)
		{
			return new StyleColor(keyword);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
		public static implicit operator StyleColor(Color v)
		{
			return new StyleColor(v);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0000D0DC File Offset: 0x0000B2DC
		public bool Equals(StyleColor other)
		{
			return other == this;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0000D0FC File Offset: 0x0000B2FC
		public override bool Equals(Object obj)
		{
			bool flag = !(obj is StyleColor);
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				StyleColor styleColor = (StyleColor)obj;
				flag2 = styleColor == this;
			}
			return flag2;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0000D138 File Offset: 0x0000B338
		public override int GetHashCode()
		{
			int num = 917506989;
			num = num * -1521134295 + this.m_Keyword.GetHashCode();
			return num * -1521134295 + this.m_Value.GetHashCode();
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00006A32 File Offset: 0x00004C32
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000E2 RID: 226
		public StyleKeyword m_Keyword;

		// Token: 0x040000E3 RID: 227
		public Color m_Value;
	}
}
