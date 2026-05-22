using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000118 RID: 280
	public struct StyleBackground
	{
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0000CF1C File Offset: 0x0000B11C
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x000069E6 File Offset: 0x00004BE6
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

		// Token: 0x060006BA RID: 1722 RVA: 0x000069F0 File Offset: 0x00004BF0
		public static bool operator ==(StyleBackground lhs, StyleBackground rhs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0000CF34 File Offset: 0x0000B134
		public static bool operator !=(StyleBackground lhs, StyleBackground rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0000CF50 File Offset: 0x0000B150
		public static implicit operator StyleBackground(StyleKeyword keyword)
		{
			return new StyleBackground(keyword);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0000CF68 File Offset: 0x0000B168
		public static implicit operator StyleBackground(Texture2D v)
		{
			return new StyleBackground(v);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0000CF80 File Offset: 0x0000B180
		public bool Equals(StyleBackground other)
		{
			return other == this;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0000CFA0 File Offset: 0x0000B1A0
		public override bool Equals(Object obj)
		{
			bool flag = !(obj is StyleBackground);
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				StyleBackground styleBackground = (StyleBackground)obj;
				flag2 = styleBackground == this;
			}
			return flag2;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x000069FD File Offset: 0x00004BFD
		public override int GetHashCode()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00006A0A File Offset: 0x00004C0A
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000E1 RID: 225
		public StyleKeyword m_Keyword;
	}
}
