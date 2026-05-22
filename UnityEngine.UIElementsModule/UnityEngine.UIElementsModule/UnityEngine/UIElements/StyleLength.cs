using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011C RID: 284
	public struct StyleLength
	{
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00006B19 File Offset: 0x00004D19
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

		// Token: 0x060006EA RID: 1770 RVA: 0x00006B23 File Offset: 0x00004D23
		public static bool operator ==(StyleLength lhs, StyleLength rhs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0000D2F8 File Offset: 0x0000B4F8
		public static bool operator !=(StyleLength lhs, StyleLength rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0000D314 File Offset: 0x0000B514
		public static implicit operator StyleLength(StyleKeyword keyword)
		{
			return new StyleLength(keyword);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0000D32C File Offset: 0x0000B52C
		public static implicit operator StyleLength(float v)
		{
			return new StyleLength(v);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0000D344 File Offset: 0x0000B544
		public bool Equals(StyleLength other)
		{
			return other == this;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0000D364 File Offset: 0x0000B564
		public override bool Equals(Object obj)
		{
			bool flag = !(obj is StyleLength);
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				StyleLength styleLength = (StyleLength)obj;
				flag2 = styleLength == this;
			}
			return flag2;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00006B30 File Offset: 0x00004D30
		public override int GetHashCode()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00006B3D File Offset: 0x00004D3D
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000E9 RID: 233
		public StyleKeyword m_Keyword;
	}
}
