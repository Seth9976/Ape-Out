using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200008E RID: 142
	public class Scroller : VisualElement
	{
		// Token: 0x060003CD RID: 973 RVA: 0x00004B44 File Offset: 0x00002D44
		public void add_valueChanged(Action<float> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00004B51 File Offset: 0x00002D51
		public void remove_valueChanged(Action<float> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00004B5E File Offset: 0x00002D5E
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x00004B6B File Offset: 0x00002D6B
		public Slider slider
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

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00004B78 File Offset: 0x00002D78
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x00004B85 File Offset: 0x00002D85
		public RepeatButton lowButton
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

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00004B92 File Offset: 0x00002D92
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00004B9F File Offset: 0x00002D9F
		public RepeatButton highButton
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

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00004BAC File Offset: 0x00002DAC
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x00004BB9 File Offset: 0x00002DB9
		public float value
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

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00004BC6 File Offset: 0x00002DC6
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00004BD3 File Offset: 0x00002DD3
		public float lowValue
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

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00004BE0 File Offset: 0x00002DE0
		// (set) Token: 0x060003DA RID: 986 RVA: 0x00004BED File Offset: 0x00002DED
		public float highValue
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

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003DB RID: 987 RVA: 0x0000B0F8 File Offset: 0x000092F8
		// (set) Token: 0x060003DC RID: 988 RVA: 0x00004BFA File Offset: 0x00002DFA
		public SliderDirection direction
		{
			get
			{
				return (base.resolvedStyle.flexDirection == FlexDirection.Row) ? SliderDirection.Horizontal : SliderDirection.Vertical;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00004C07 File Offset: 0x00002E07
		public void Adjust(float factor)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00004C14 File Offset: 0x00002E14
		public void ScrollPageUp()
		{
			this.ScrollPageUp(1f);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00004C23 File Offset: 0x00002E23
		public void ScrollPageDown()
		{
			this.ScrollPageDown(1f);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00004C32 File Offset: 0x00002E32
		public void ScrollPageUp(float factor)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00004C3F File Offset: 0x00002E3F
		public void ScrollPageDown(float factor)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000AF RID: 175
		public const float kDefaultPageSize = 20f;

		// Token: 0x020001E1 RID: 481
		public new class UxmlFactory : UxmlFactory<Scroller, Scroller.UxmlTraits>
		{
		}

		// Token: 0x020001E2 RID: 482
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x02000223 RID: 547
			public sealed class <get_uxmlChildElementsDescription>d__5
			{
			}
		}
	}
}
