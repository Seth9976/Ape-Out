using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000129 RID: 297
	[Serializable]
	public class StyleSheet : ScriptableObject
	{
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x00006C5B File Offset: 0x00004E5B
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x00006C68 File Offset: 0x00004E68
		public Il2CppReferenceArray<StyleRule> rules
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x00006C75 File Offset: 0x00004E75
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x00006C82 File Offset: 0x00004E82
		public Il2CppReferenceArray<StyleComplexSelector> complexSelectors
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00006C8F File Offset: 0x00004E8F
		public List<StyleSheet> flattenedRecursiveImports
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00006C9C File Offset: 0x00004E9C
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00006CA9 File Offset: 0x00004EA9
		public int contentHash
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00006CB6 File Offset: 0x00004EB6
		public void OnEnable()
		{
			this.SetupReferences();
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00006CC0 File Offset: 0x00004EC0
		public void FlattenImportedStyleSheetsRecursive()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00006CCD File Offset: 0x00004ECD
		public void FlattenImportedStyleSheetsRecursive(StyleSheet sheet)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00006CDA File Offset: 0x00004EDA
		public void SetupReferences()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0000D4E4 File Offset: 0x0000B6E4
		public static bool CustomStartsWith(string originalString, string pattern)
		{
			int length = originalString.Length;
			int length2 = pattern.Length;
			int num = 0;
			int num2 = 0;
			while (num < length && num2 < length2 && originalString.get_Chars(num) == pattern.get_Chars(num2))
			{
				num++;
				num2++;
			}
			return (num2 == length2 && length >= length2) || (num == length && length2 >= length);
		}
	}
}
