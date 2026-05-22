using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011B RID: 283
	public static class StyleDebug
	{
		// Token: 0x060006D9 RID: 1753 RVA: 0x00006A70 File Offset: 0x00004C70
		public static Il2CppStringArray GetStylePropertyNames()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00006A7D File Offset: 0x00004C7D
		public static Il2CppStringArray GetLonghandPropertyNames(string shorthandName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00006A8A File Offset: 0x00004C8A
		public static UnityEngine.UIElements.StyleSheets.StylePropertyId GetStylePropertyIdFromName(string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00006A97 File Offset: 0x00004C97
		public static Object GetComputedStyleValue(ComputedStyle computedStyle, string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00006AA4 File Offset: 0x00004CA4
		public static Object GetInlineStyleValue(IStyle style, string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00006AB1 File Offset: 0x00004CB1
		public static void SetInlineStyleValue(IStyle style, string name, Object value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00006ABE File Offset: 0x00004CBE
		public static Type GetComputedStyleType(string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00006ACB File Offset: 0x00004CCB
		public static Object GetComputedStyleValue(ComputedStyle computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00006AD8 File Offset: 0x00004CD8
		public static Object GetInlineStyleValue(IStyle style, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00006AE5 File Offset: 0x00004CE5
		public static void SetInlineStyleValue(IStyle style, UnityEngine.UIElements.StyleSheets.StylePropertyId id, Object value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00006AF2 File Offset: 0x00004CF2
		public static Type GetComputedStyleType(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00006AFF File Offset: 0x00004CFF
		public static Il2CppStringArray GetLonghandPropertyNames(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0000D230 File Offset: 0x0000B430
		public static bool IsShorthandProperty(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			bool flag;
			switch (id)
			{
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderColor:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRadius:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderWidth:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Flex:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Margin:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Padding:
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			return flag;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0000D288 File Offset: 0x0000B488
		public static bool IsInheritedProperty(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			bool flag;
			switch (id)
			{
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Color:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.FontSize:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFont:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontStyleAndWeight:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextAlign:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Visibility:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.WhiteSpace:
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			return flag;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00006B0C File Offset: 0x00004D0C
		public static Il2CppStructArray<UnityEngine.UIElements.StyleSheets.StylePropertyId> GetInheritedProperties()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000E5 RID: 229
		public const int UnitySpecificity = -1;

		// Token: 0x040000E6 RID: 230
		public const int UndefinedSpecificity = 0;

		// Token: 0x040000E7 RID: 231
		public const int InheritedSpecificity = 2147483646;

		// Token: 0x040000E8 RID: 232
		public const int InlineSpecificity = 2147483647;
	}
}
