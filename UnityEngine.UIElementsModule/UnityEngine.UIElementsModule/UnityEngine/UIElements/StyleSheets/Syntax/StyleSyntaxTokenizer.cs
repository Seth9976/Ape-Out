using System;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x02000193 RID: 403
	public class StyleSyntaxTokenizer
	{
		// Token: 0x0600091D RID: 2333 RVA: 0x00008458 File Offset: 0x00006658
		public void Tokenize(string syntax)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0000F4D8 File Offset: 0x0000D6D8
		public static bool IsNextCharacter(string s, int index, char c)
		{
			return index + 1 < s.Length && s.get_Chars(index + 1) == c;
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0000F504 File Offset: 0x0000D704
		public static bool IsNextLetterOrDash(string s, int index)
		{
			return index + 1 < s.Length && (Char.IsLetter(s.get_Chars(index + 1)) || s.get_Chars(index + 1) == '-');
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0000F544 File Offset: 0x0000D744
		public static bool IsNextNumber(string s, int index)
		{
			return index + 1 < s.Length && Char.IsNumber(s.get_Chars(index + 1));
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0000F574 File Offset: 0x0000D774
		public static int GlobCharacter(string s, int index, char c)
		{
			while (StyleSyntaxTokenizer.IsNextCharacter(s, index, c))
			{
				index++;
			}
			return index;
		}
	}
}
