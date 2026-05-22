using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000121 RID: 289
	public struct InheritedData
	{
		// Token: 0x060006F3 RID: 1779 RVA: 0x00006B4A File Offset: 0x00004D4A
		public static bool operator ==(InheritedData lhs, InheritedData rhs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0000D3D8 File Offset: 0x0000B5D8
		public static bool operator !=(InheritedData lhs, InheritedData rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
		public bool Equals(InheritedData other)
		{
			return other == this;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0000D414 File Offset: 0x0000B614
		public override bool Equals(Object obj)
		{
			bool flag = obj == null;
			return !flag && obj is InheritedData && this.Equals((InheritedData)obj);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00006B57 File Offset: 0x00004D57
		public override int GetHashCode()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000F0 RID: 240
		public StyleColor color;

		// Token: 0x040000F1 RID: 241
		public StyleLength fontSize;
	}
}
