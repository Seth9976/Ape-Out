using System;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000175 RID: 373
	public abstract class HierarchyTraversal
	{
		// Token: 0x06000889 RID: 2185 RVA: 0x00007D41 File Offset: 0x00005F41
		public virtual void Traverse(VisualElement element)
		{
			this.TraverseRecursive(element, 0);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00007D4D File Offset: 0x00005F4D
		public void Recurse(VisualElement element, int depth)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
