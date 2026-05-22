using System;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine
{
	// Token: 0x02000201 RID: 513
	public struct BoundsInt
	{
		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x0007467C File Offset: 0x0007287C
		// (set) Token: 0x06002061 RID: 8289 RVA: 0x00010D81 File Offset: 0x0000EF81
		public int x
		{
			get
			{
				return this.m_Position.x;
			}
			set
			{
				this.m_Position.x = value;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x0007469C File Offset: 0x0007289C
		// (set) Token: 0x06002063 RID: 8291 RVA: 0x00010D91 File Offset: 0x0000EF91
		public int y
		{
			get
			{
				return this.m_Position.y;
			}
			set
			{
				this.m_Position.y = value;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x000746BC File Offset: 0x000728BC
		// (set) Token: 0x06002065 RID: 8293 RVA: 0x00010DA1 File Offset: 0x0000EFA1
		public int z
		{
			get
			{
				return this.m_Position.z;
			}
			set
			{
				this.m_Position.z = value;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x000746DC File Offset: 0x000728DC
		public Vector3 center
		{
			get
			{
				return new Vector3((float)this.x + (float)this.m_Size.x / 2f, (float)this.y + (float)this.m_Size.y / 2f, (float)this.z + (float)this.m_Size.z / 2f);
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x00074744 File Offset: 0x00072944
		// (set) Token: 0x06002068 RID: 8296 RVA: 0x00010DB1 File Offset: 0x0000EFB1
		public Vector3Int min
		{
			get
			{
				return new Vector3Int(this.xMin, this.yMin, this.zMin);
			}
			set
			{
				this.xMin = value.x;
				this.yMin = value.y;
				this.zMin = value.z;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x00074770 File Offset: 0x00072970
		// (set) Token: 0x0600206A RID: 8298 RVA: 0x00010DDE File Offset: 0x0000EFDE
		public Vector3Int max
		{
			get
			{
				return new Vector3Int(this.xMax, this.yMax, this.zMax);
			}
			set
			{
				this.xMax = value.x;
				this.yMax = value.y;
				this.zMax = value.z;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x0007479C File Offset: 0x0007299C
		// (set) Token: 0x0600206C RID: 8300 RVA: 0x000747D8 File Offset: 0x000729D8
		public int xMin
		{
			get
			{
				return Math.Min(this.m_Position.x, this.m_Position.x + this.m_Size.x);
			}
			set
			{
				int xMax = this.xMax;
				this.m_Position.x = value;
				this.m_Size.x = xMax - this.m_Position.x;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x00074814 File Offset: 0x00072A14
		// (set) Token: 0x0600206E RID: 8302 RVA: 0x00074850 File Offset: 0x00072A50
		public int yMin
		{
			get
			{
				return Math.Min(this.m_Position.y, this.m_Position.y + this.m_Size.y);
			}
			set
			{
				int yMax = this.yMax;
				this.m_Position.y = value;
				this.m_Size.y = yMax - this.m_Position.y;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x0007488C File Offset: 0x00072A8C
		// (set) Token: 0x06002070 RID: 8304 RVA: 0x000748C8 File Offset: 0x00072AC8
		public int zMin
		{
			get
			{
				return Math.Min(this.m_Position.z, this.m_Position.z + this.m_Size.z);
			}
			set
			{
				int zMax = this.zMax;
				this.m_Position.z = value;
				this.m_Size.z = zMax - this.m_Position.z;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x00074904 File Offset: 0x00072B04
		// (set) Token: 0x06002072 RID: 8306 RVA: 0x00010E0B File Offset: 0x0000F00B
		public int xMax
		{
			get
			{
				return Math.Max(this.m_Position.x, this.m_Position.x + this.m_Size.x);
			}
			set
			{
				this.m_Size.x = value - this.m_Position.x;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x00074940 File Offset: 0x00072B40
		// (set) Token: 0x06002074 RID: 8308 RVA: 0x00010E27 File Offset: 0x0000F027
		public int yMax
		{
			get
			{
				return Math.Max(this.m_Position.y, this.m_Position.y + this.m_Size.y);
			}
			set
			{
				this.m_Size.y = value - this.m_Position.y;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x0007497C File Offset: 0x00072B7C
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x00010E43 File Offset: 0x0000F043
		public int zMax
		{
			get
			{
				return Math.Max(this.m_Position.z, this.m_Position.z + this.m_Size.z);
			}
			set
			{
				this.m_Size.z = value - this.m_Position.z;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x000749B8 File Offset: 0x00072BB8
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x00010E5F File Offset: 0x0000F05F
		public Vector3Int position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				this.m_Position = value;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x000749D0 File Offset: 0x00072BD0
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x00010E69 File Offset: 0x0000F069
		public Vector3Int size
		{
			get
			{
				return this.m_Size;
			}
			set
			{
				this.m_Size = value;
			}
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00010E73 File Offset: 0x0000F073
		public void SetMinMax(Vector3Int minPosition, Vector3Int maxPosition)
		{
			this.min = minPosition;
			this.max = maxPosition;
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x000749E8 File Offset: 0x00072BE8
		public void ClampToBounds(BoundsInt bounds)
		{
			this.position = new Vector3Int(Math.Max(Math.Min(bounds.xMax, this.position.x), bounds.xMin), Math.Max(Math.Min(bounds.yMax, this.position.y), bounds.yMin), Math.Max(Math.Min(bounds.zMax, this.position.z), bounds.zMin));
			this.size = new Vector3Int(Math.Min(bounds.xMax - this.position.x, this.size.x), Math.Min(bounds.yMax - this.position.y, this.size.y), Math.Min(bounds.zMax - this.position.z, this.size.z));
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00074AFC File Offset: 0x00072CFC
		public bool Contains(Vector3Int position)
		{
			return position.x >= this.xMin && position.y >= this.yMin && position.z >= this.zMin && position.x < this.xMax && position.y < this.yMax && position.z < this.zMax;
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00074B6C File Offset: 0x00072D6C
		public override string ToString()
		{
			return this.ToString(null, CultureInfo.InvariantCulture.NumberFormat);
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x00074B90 File Offset: 0x00072D90
		public string ToString(string format)
		{
			return this.ToString(format, CultureInfo.InvariantCulture.NumberFormat);
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00010E86 File Offset: 0x0000F086
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x00074BB4 File Offset: 0x00072DB4
		public static bool operator ==(BoundsInt lhs, BoundsInt rhs)
		{
			return lhs.m_Position == rhs.m_Position && lhs.m_Size == rhs.m_Size;
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x00074BF0 File Offset: 0x00072DF0
		public static bool operator !=(BoundsInt lhs, BoundsInt rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x00074C0C File Offset: 0x00072E0C
		public override bool Equals(Object other)
		{
			bool flag = !(other is BoundsInt);
			return !flag && this.Equals((BoundsInt)other);
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00074C40 File Offset: 0x00072E40
		public bool Equals(BoundsInt other)
		{
			return this.m_Position.Equals(other.m_Position) && this.m_Size.Equals(other.m_Size);
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x00074C7C File Offset: 0x00072E7C
		public override int GetHashCode()
		{
			return this.m_Position.GetHashCode() ^ (this.m_Size.GetHashCode() << 2);
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06002086 RID: 8326 RVA: 0x00074CB4 File Offset: 0x00072EB4
		public BoundsInt.PositionEnumerator allPositionsWithin
		{
			get
			{
				return new BoundsInt.PositionEnumerator(this.min, this.max);
			}
		}

		// Token: 0x04001A83 RID: 6787
		public Vector3Int m_Position;

		// Token: 0x04001A84 RID: 6788
		public Vector3Int m_Size;

		// Token: 0x02000AE3 RID: 2787
		public struct PositionEnumerator
		{
		}
	}
}
