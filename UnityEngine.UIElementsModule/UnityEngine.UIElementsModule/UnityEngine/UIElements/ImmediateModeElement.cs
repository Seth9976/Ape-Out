using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000023 RID: 35
	public abstract class ImmediateModeElement : VisualElement
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000272C File Offset: 0x0000092C
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002739 File Offset: 0x00000939
		public bool cullingEnabled
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

		// Token: 0x060000A3 RID: 163 RVA: 0x00002746 File Offset: 0x00000946
		public void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
