using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000122 RID: 290
	public struct NonInheritedData
	{
		// Token: 0x060006F8 RID: 1784 RVA: 0x00006B64 File Offset: 0x00004D64
		public static bool operator ==(NonInheritedData lhs, NonInheritedData rhs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0000D44C File Offset: 0x0000B64C
		public static bool operator !=(NonInheritedData lhs, NonInheritedData rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0000D468 File Offset: 0x0000B668
		public bool Equals(NonInheritedData other)
		{
			return other == this;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0000D488 File Offset: 0x0000B688
		public override bool Equals(Object obj)
		{
			bool flag = obj == null;
			return !flag && obj is NonInheritedData && this.Equals((NonInheritedData)obj);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00006B71 File Offset: 0x00004D71
		public override int GetHashCode()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000F2 RID: 242
		public StyleColor backgroundColor;

		// Token: 0x040000F3 RID: 243
		public StyleBackground backgroundImage;

		// Token: 0x040000F4 RID: 244
		public StyleColor borderBottomColor;

		// Token: 0x040000F5 RID: 245
		public StyleLength borderBottomLeftRadius;

		// Token: 0x040000F6 RID: 246
		public StyleLength borderBottomRightRadius;

		// Token: 0x040000F7 RID: 247
		public StyleColor borderLeftColor;

		// Token: 0x040000F8 RID: 248
		public StyleColor borderRightColor;

		// Token: 0x040000F9 RID: 249
		public StyleColor borderTopColor;

		// Token: 0x040000FA RID: 250
		public StyleLength borderTopLeftRadius;

		// Token: 0x040000FB RID: 251
		public StyleLength borderTopRightRadius;

		// Token: 0x040000FC RID: 252
		public StyleLength bottom;

		// Token: 0x040000FD RID: 253
		public StyleCursor cursor;

		// Token: 0x040000FE RID: 254
		public StyleLength flexBasis;

		// Token: 0x040000FF RID: 255
		public StyleLength height;

		// Token: 0x04000100 RID: 256
		public StyleLength left;

		// Token: 0x04000101 RID: 257
		public StyleLength marginBottom;

		// Token: 0x04000102 RID: 258
		public StyleLength marginLeft;

		// Token: 0x04000103 RID: 259
		public StyleLength marginRight;

		// Token: 0x04000104 RID: 260
		public StyleLength marginTop;

		// Token: 0x04000105 RID: 261
		public StyleLength maxHeight;

		// Token: 0x04000106 RID: 262
		public StyleLength maxWidth;

		// Token: 0x04000107 RID: 263
		public StyleLength minHeight;

		// Token: 0x04000108 RID: 264
		public StyleLength minWidth;

		// Token: 0x04000109 RID: 265
		public StyleLength paddingBottom;

		// Token: 0x0400010A RID: 266
		public StyleLength paddingLeft;

		// Token: 0x0400010B RID: 267
		public StyleLength paddingRight;

		// Token: 0x0400010C RID: 268
		public StyleLength paddingTop;

		// Token: 0x0400010D RID: 269
		public StyleLength right;

		// Token: 0x0400010E RID: 270
		public StyleLength top;

		// Token: 0x0400010F RID: 271
		public StyleColor unityBackgroundImageTintColor;

		// Token: 0x04000110 RID: 272
		public StyleLength width;
	}
}
