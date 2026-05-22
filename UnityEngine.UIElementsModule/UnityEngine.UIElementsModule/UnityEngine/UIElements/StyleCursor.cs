using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011A RID: 282
	public struct StyleCursor
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0000D188 File Offset: 0x0000B388
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x00006A3F File Offset: 0x00004C3F
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

		// Token: 0x060006D2 RID: 1746 RVA: 0x00006A49 File Offset: 0x00004C49
		public static bool operator ==(StyleCursor lhs, StyleCursor rhs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		public static bool operator !=(StyleCursor lhs, StyleCursor rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000D1BC File Offset: 0x0000B3BC
		public static implicit operator StyleCursor(StyleKeyword keyword)
		{
			return new StyleCursor(keyword);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0000D1D4 File Offset: 0x0000B3D4
		public bool Equals(StyleCursor other)
		{
			return other == this;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0000D1F4 File Offset: 0x0000B3F4
		public override bool Equals(Object obj)
		{
			bool flag = !(obj is StyleCursor);
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				StyleCursor styleCursor = (StyleCursor)obj;
				flag2 = styleCursor == this;
			}
			return flag2;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00006A56 File Offset: 0x00004C56
		public override int GetHashCode()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00006A63 File Offset: 0x00004C63
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000E4 RID: 228
		public StyleKeyword m_Keyword;
	}
}
