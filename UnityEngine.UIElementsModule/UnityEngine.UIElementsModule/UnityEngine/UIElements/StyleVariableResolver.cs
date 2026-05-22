using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000130 RID: 304
	public class StyleVariableResolver
	{
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x00006D0E File Offset: 0x00004F0E
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00006D1B File Offset: 0x00004F1B
		public StyleVariableContext variableContext
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

		// Token: 0x06000723 RID: 1827 RVA: 0x00006D28 File Offset: 0x00004F28
		public StyleVariableResolver.Result ResolveVarFunction(ref int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00006D35 File Offset: 0x00004F35
		public StyleVariableResolver.Result ResolveVariable(string variableName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00006D42 File Offset: 0x00004F42
		public StyleVariableResolver.Result ResolveFallback(ref int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400013D RID: 317
		public const int kMaxResolves = 100;

		// Token: 0x020001FB RID: 507
		public enum Result
		{
			// Token: 0x04000265 RID: 613
			Valid,
			// Token: 0x04000266 RID: 614
			Invalid,
			// Token: 0x04000267 RID: 615
			NotFound
		}
	}
}
