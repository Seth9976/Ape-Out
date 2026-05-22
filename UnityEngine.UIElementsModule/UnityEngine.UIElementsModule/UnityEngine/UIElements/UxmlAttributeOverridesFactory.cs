using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200013A RID: 314
	public class UxmlAttributeOverridesFactory : UxmlFactory<VisualElement, UxmlAttributeOverridesTraits>
	{
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00006E3F File Offset: 0x0000503F
		public override string uxmlName
		{
			get
			{
				return "AttributeOverrides";
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00006E46 File Offset: 0x00005046
		public override string uxmlQualifiedName
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00006E53 File Offset: 0x00005053
		public override string substituteForTypeName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Name;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00006E64 File Offset: 0x00005064
		public override string substituteForTypeNamespace
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Namespace ?? String.Empty;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00006E7E File Offset: 0x0000507E
		public override string substituteForTypeQualifiedName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).FullName;
			}
		}

		// Token: 0x04000144 RID: 324
		public const string k_ElementName = "AttributeOverrides";
	}
}
