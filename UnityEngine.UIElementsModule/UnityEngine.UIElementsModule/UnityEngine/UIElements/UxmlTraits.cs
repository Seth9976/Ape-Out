using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000146 RID: 326
	public abstract class UxmlTraits
	{
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00006FEE File Offset: 0x000051EE
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x00006FFB File Offset: 0x000051FB
		public bool canHaveAnyAttribute
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

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00007008 File Offset: 0x00005208
		public virtual IEnumerable<UxmlAttributeDescription> uxmlAttributesDescription
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00007015 File Offset: 0x00005215
		public virtual IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00007022 File Offset: 0x00005222
		public IEnumerable<UxmlAttributeDescription> GetAllAttributeDescriptionForType(Type t)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000208 RID: 520
		public sealed class <get_uxmlAttributesDescription>d__6
		{
		}

		// Token: 0x02000209 RID: 521
		public sealed class <get_uxmlChildElementsDescription>d__8
		{
		}

		// Token: 0x0200020A RID: 522
		[Serializable]
		public sealed class <>c
		{
		}

		// Token: 0x0200020B RID: 523
		public sealed class <GetAllAttributeDescriptionForType>d__10
		{
		}
	}
}
