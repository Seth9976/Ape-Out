using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000134 RID: 308
	public class UxmlRootElementFactory : UxmlFactory<VisualElement, UxmlRootElementTraits>
	{
		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00006D4F File Offset: 0x00004F4F
		public override string uxmlName
		{
			get
			{
				return "UXML";
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00006D56 File Offset: 0x00004F56
		public override string uxmlQualifiedName
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00006D63 File Offset: 0x00004F63
		public override string substituteForTypeName
		{
			get
			{
				return String.Empty;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00006D6A File Offset: 0x00004F6A
		public override string substituteForTypeNamespace
		{
			get
			{
				return String.Empty;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00006D71 File Offset: 0x00004F71
		public override string substituteForTypeQualifiedName
		{
			get
			{
				return String.Empty;
			}
		}

		// Token: 0x04000141 RID: 321
		public const string k_ElementName = "UXML";
	}
}
