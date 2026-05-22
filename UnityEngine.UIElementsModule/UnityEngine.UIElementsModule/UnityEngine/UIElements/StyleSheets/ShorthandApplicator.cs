using System;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000177 RID: 375
	public static class ShorthandApplicator
	{
		// Token: 0x060008AD RID: 2221 RVA: 0x00007F14 File Offset: 0x00006114
		public static void ApplyBorderColor(StylePropertyReader reader, ComputedStyle computedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00007F21 File Offset: 0x00006121
		public static void ApplyBorderRadius(StylePropertyReader reader, ComputedStyle computedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00007F2E File Offset: 0x0000612E
		public static void ApplyBorderWidth(StylePropertyReader reader, ComputedStyle computedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00007F3B File Offset: 0x0000613B
		public static void ApplyFlex(StylePropertyReader reader, ComputedStyle computedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00007F48 File Offset: 0x00006148
		public static void ApplyMargin(StylePropertyReader reader, ComputedStyle computedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00007F55 File Offset: 0x00006155
		public static void ApplyPadding(StylePropertyReader reader, ComputedStyle computedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0000EAF8 File Offset: 0x0000CCF8
		public static void CompileBoxArea(StylePropertyReader reader, out StyleLength top, out StyleLength right, out StyleLength bottom, out StyleLength left)
		{
			top = 0f;
			right = 0f;
			bottom = 0f;
			left = 0f;
			switch (reader.valueCount)
			{
			case 0:
				break;
			case 1:
				top = (right = (bottom = (left = reader.ReadStyleLength(0))));
				break;
			case 2:
				top = (bottom = reader.ReadStyleLength(0));
				left = (right = reader.ReadStyleLength(1));
				break;
			case 3:
				top = reader.ReadStyleLength(0);
				left = (right = reader.ReadStyleLength(1));
				bottom = reader.ReadStyleLength(2);
				break;
			default:
				top = reader.ReadStyleLength(0);
				right = reader.ReadStyleLength(1);
				bottom = reader.ReadStyleLength(2);
				left = reader.ReadStyleLength(3);
				break;
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00007F62 File Offset: 0x00006162
		public static void CompileBoxAreaNoKeyword(StylePropertyReader reader, out StyleLength top, out StyleLength right, out StyleLength bottom, out StyleLength left)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0000EC40 File Offset: 0x0000CE40
		public static void CompileBoxAreaNoKeyword(StylePropertyReader reader, out StyleColor top, out StyleColor right, out StyleColor bottom, out StyleColor left)
		{
			top = Color.clear;
			right = Color.clear;
			bottom = Color.clear;
			left = Color.clear;
			switch (reader.valueCount)
			{
			case 0:
				break;
			case 1:
				top = (right = (bottom = (left = reader.ReadStyleColor(0))));
				break;
			case 2:
				top = (bottom = reader.ReadStyleColor(0));
				left = (right = reader.ReadStyleColor(1));
				break;
			case 3:
				top = reader.ReadStyleColor(0);
				left = (right = reader.ReadStyleColor(1));
				bottom = reader.ReadStyleColor(2);
				break;
			default:
				top = reader.ReadStyleColor(0);
				right = reader.ReadStyleColor(1);
				bottom = reader.ReadStyleColor(2);
				left = reader.ReadStyleColor(3);
				break;
			}
			bool flag = top.keyword > StyleKeyword.Undefined;
			if (flag)
			{
				top.value = Color.clear;
			}
			bool flag2 = right.keyword > StyleKeyword.Undefined;
			if (flag2)
			{
				right.value = Color.clear;
			}
			bool flag3 = bottom.keyword > StyleKeyword.Undefined;
			if (flag3)
			{
				bottom.value = Color.clear;
			}
			bool flag4 = left.keyword > StyleKeyword.Undefined;
			if (flag4)
			{
				left.value = Color.clear;
			}
		}
	}
}
