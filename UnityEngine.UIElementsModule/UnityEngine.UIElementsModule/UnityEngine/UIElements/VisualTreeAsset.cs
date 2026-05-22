using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000152 RID: 338
	[Serializable]
	public class VisualTreeAsset : ScriptableObject
	{
		// Token: 0x0600078E RID: 1934 RVA: 0x00007212 File Offset: 0x00005412
		public int GetNextChildSerialNumber()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x0000721F File Offset: 0x0000541F
		public IEnumerable<VisualTreeAsset> templateDependencies
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x0000722C File Offset: 0x0000542C
		public IEnumerable<StyleSheet> stylesheets
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x00007239 File Offset: 0x00005439
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x00007246 File Offset: 0x00005446
		public List<VisualElementAsset> visualElementAssets
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

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00007253 File Offset: 0x00005453
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x00007260 File Offset: 0x00005460
		public List<TemplateAsset> templateAssets
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

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x0000726D File Offset: 0x0000546D
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x0000727A File Offset: 0x0000547A
		public int contentContainerId
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

		// Token: 0x06000797 RID: 1943 RVA: 0x00007287 File Offset: 0x00005487
		public TemplateContainer Instantiate()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0000D95C File Offset: 0x0000BB5C
		public TemplateContainer Instantiate(string bindingPath)
		{
			TemplateContainer templateContainer = this.Instantiate();
			templateContainer.bindingPath = bindingPath;
			return templateContainer;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0000D980 File Offset: 0x0000BB80
		public TemplateContainer CloneTree()
		{
			return this.Instantiate();
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0000D998 File Offset: 0x0000BB98
		public TemplateContainer CloneTree(string bindingPath)
		{
			return this.Instantiate(bindingPath);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0000D9B4 File Offset: 0x0000BBB4
		public void CloneTree(VisualElement target)
		{
			int num;
			int num2;
			this.CloneTree(target, out num, out num2);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00007294 File Offset: 0x00005494
		public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0000D9D0 File Offset: 0x0000BBD0
		public static int CompareForOrder(VisualElementAsset a, VisualElementAsset b)
		{
			return a.orderInDocument.CompareTo(b.orderInDocument);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x000072A1 File Offset: 0x000054A1
		public bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000072AE File Offset: 0x000054AE
		public VisualTreeAsset ResolveTemplate(string templateName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000072BB File Offset: 0x000054BB
		public static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000072C8 File Offset: 0x000054C8
		public static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x000072D5 File Offset: 0x000054D5
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x000072E2 File Offset: 0x000054E2
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

		// Token: 0x0200020C RID: 524
		public class UsingEntryComparer
		{
		}

		// Token: 0x0200020D RID: 525
		public sealed class <get_templateDependencies>d__8
		{
		}

		// Token: 0x0200020E RID: 526
		public sealed class <get_stylesheets>d__12
		{
		}

		// Token: 0x0200020F RID: 527
		public sealed class <>c__DisplayClass36_0
		{
		}
	}
}
