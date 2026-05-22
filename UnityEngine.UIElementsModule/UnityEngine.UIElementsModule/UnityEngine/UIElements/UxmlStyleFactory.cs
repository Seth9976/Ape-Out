using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000136 RID: 310
	public class UxmlStyleFactory : UxmlFactory<VisualElement, UxmlStyleTraits>
	{
		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x00006D85 File Offset: 0x00004F85
		public override string uxmlName
		{
			get
			{
				return "Style";
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00006D8C File Offset: 0x00004F8C
		public override string uxmlQualifiedName
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00006D99 File Offset: 0x00004F99
		public override string substituteForTypeName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Name;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00006DAA File Offset: 0x00004FAA
		public override string substituteForTypeNamespace
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Namespace ?? String.Empty;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00006DC4 File Offset: 0x00004FC4
		public override string substituteForTypeQualifiedName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).FullName;
			}
		}

		// Token: 0x04000142 RID: 322
		public const string k_ElementName = "Style";
	}
}
