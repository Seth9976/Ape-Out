using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200025F RID: 607
	public struct SnapAxisFilter
	{
		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x00076F50 File Offset: 0x00075150
		public float x
		{
			get
			{
				return ((this.m_Mask & SnapAxis.X) == SnapAxis.X) ? 1f : 0f;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x00076F7C File Offset: 0x0007517C
		public float y
		{
			get
			{
				return ((this.m_Mask & SnapAxis.Y) == SnapAxis.Y) ? 1f : 0f;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x00076FA8 File Offset: 0x000751A8
		public float z
		{
			get
			{
				return ((this.m_Mask & SnapAxis.Z) == SnapAxis.Z) ? 1f : 0f;
			}
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x00076FD4 File Offset: 0x000751D4
		public override string ToString()
		{
			return String.Format("{{{0}, {1}, {2}}}", this.x, this.y, this.z);
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x00077014 File Offset: 0x00075214
		public int active
		{
			get
			{
				int num = 0;
				bool flag = (this.m_Mask & SnapAxis.X) > SnapAxis.None;
				if (flag)
				{
					num++;
				}
				bool flag2 = (this.m_Mask & SnapAxis.Y) > SnapAxis.None;
				if (flag2)
				{
					num++;
				}
				bool flag3 = (this.m_Mask & SnapAxis.Z) > SnapAxis.None;
				if (flag3)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x00077064 File Offset: 0x00075264
		public static implicit operator Vector3(SnapAxisFilter mask)
		{
			return new Vector3(mask.x, mask.y, mask.z);
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x00077090 File Offset: 0x00075290
		public static explicit operator SnapAxisFilter(Vector3 v)
		{
			return new SnapAxisFilter(v);
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x000770A8 File Offset: 0x000752A8
		public static explicit operator SnapAxis(SnapAxisFilter mask)
		{
			return mask.m_Mask;
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x000770C0 File Offset: 0x000752C0
		public static SnapAxisFilter operator |(SnapAxisFilter left, SnapAxisFilter right)
		{
			return new SnapAxisFilter(left.m_Mask | right.m_Mask);
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x000770E4 File Offset: 0x000752E4
		public static SnapAxisFilter operator &(SnapAxisFilter left, SnapAxisFilter right)
		{
			return new SnapAxisFilter(left.m_Mask & right.m_Mask);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00077108 File Offset: 0x00075308
		public static SnapAxisFilter operator ^(SnapAxisFilter left, SnapAxisFilter right)
		{
			return new SnapAxisFilter(left.m_Mask ^ right.m_Mask);
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x0007712C File Offset: 0x0007532C
		public static SnapAxisFilter operator ~(SnapAxisFilter left)
		{
			return new SnapAxisFilter(~left.m_Mask);
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x0007714C File Offset: 0x0007534C
		public static Vector3 operator *(SnapAxisFilter mask, float value)
		{
			return new Vector3(mask.x * value, mask.y * value, mask.z * value);
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x00077180 File Offset: 0x00075380
		public static Vector3 operator *(SnapAxisFilter mask, Vector3 right)
		{
			return new Vector3(mask.x * right.x, mask.y * right.y, mask.z * right.z);
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000771C4 File Offset: 0x000753C4
		public static Vector3 operator *(Quaternion rotation, SnapAxisFilter mask)
		{
			int active = mask.active;
			bool flag = active > 2;
			Vector3 vector;
			if (flag)
			{
				vector = mask;
			}
			else
			{
				Vector3 vector2 = rotation * mask;
				vector2 = new Vector3(Mathf.Abs(vector2.x), Mathf.Abs(vector2.y), Mathf.Abs(vector2.z));
				bool flag2 = active > 1;
				if (flag2)
				{
					vector = new Vector3((float)((vector2.x > vector2.y || vector2.x > vector2.z) ? 1 : 0), (float)((vector2.y > vector2.x || vector2.y > vector2.z) ? 1 : 0), (float)((vector2.z > vector2.x || vector2.z > vector2.y) ? 1 : 0));
				}
				else
				{
					vector = new Vector3((float)((vector2.x > vector2.y && vector2.x > vector2.z) ? 1 : 0), (float)((vector2.y > vector2.z && vector2.y > vector2.x) ? 1 : 0), (float)((vector2.z > vector2.x && vector2.z > vector2.y) ? 1 : 0));
				}
			}
			return vector;
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x00077308 File Offset: 0x00075508
		public static bool operator ==(SnapAxisFilter left, SnapAxisFilter right)
		{
			return left.m_Mask == right.m_Mask;
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x00077328 File Offset: 0x00075528
		public static bool operator !=(SnapAxisFilter left, SnapAxisFilter right)
		{
			return !(left == right);
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060021E9 RID: 8681 RVA: 0x00077344 File Offset: 0x00075544
		// (set) Token: 0x060021EA RID: 8682 RVA: 0x00077380 File Offset: 0x00075580
		public float Item
		{
			get
			{
				bool flag = i < 0 || i > 2;
				if (flag)
				{
					throw new IndexOutOfRangeException();
				}
				return (float)(SnapAxis.X & (this.m_Mask >> (i & 31))) * 1f;
			}
			set
			{
				bool flag = i < 0 || i > 2;
				if (flag)
				{
					throw new IndexOutOfRangeException();
				}
				this.m_Mask &= (SnapAxis)(~(SnapAxis)(1 << i));
				this.m_Mask |= (SnapAxis)(((value > 0f) ? 1 : 0) << (i & 31));
			}
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x000773D8 File Offset: 0x000755D8
		public bool Equals(SnapAxisFilter other)
		{
			return this.m_Mask == other.m_Mask;
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x000773F8 File Offset: 0x000755F8
		public override bool Equals(Object obj)
		{
			bool flag = obj == null;
			return !flag && obj is SnapAxisFilter && this.Equals((SnapAxisFilter)obj);
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x00077430 File Offset: 0x00075630
		public override int GetHashCode()
		{
			return this.m_Mask.GetHashCode();
		}

		// Token: 0x04001BF3 RID: 7155
		public const SnapAxis X = SnapAxis.X;

		// Token: 0x04001BF4 RID: 7156
		public const SnapAxis Y = SnapAxis.Y;

		// Token: 0x04001BF5 RID: 7157
		public const SnapAxis Z = SnapAxis.Z;

		// Token: 0x04001BF6 RID: 7158
		public SnapAxis m_Mask;
	}
}
