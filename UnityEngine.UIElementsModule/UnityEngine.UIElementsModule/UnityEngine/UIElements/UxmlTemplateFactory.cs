using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000138 RID: 312
	public class UxmlTemplateFactory : UxmlFactory<VisualElement, UxmlTemplateTraits>
	{
		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00006DE2 File Offset: 0x00004FE2
		public override string uxmlName
		{
			get
			{
				return "Template";
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00006DE9 File Offset: 0x00004FE9
		public override string uxmlQualifiedName
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00006DF6 File Offset: 0x00004FF6
		public override string substituteForTypeName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Name;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00006E07 File Offset: 0x00005007
		public override string substituteForTypeNamespace
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Namespace ?? String.Empty;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00006E21 File Offset: 0x00005021
		public override string substituteForTypeQualifiedName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).FullName;
			}
		}

		// Token: 0x04000143 RID: 323
		public const string k_ElementName = "Template";
	}
}
