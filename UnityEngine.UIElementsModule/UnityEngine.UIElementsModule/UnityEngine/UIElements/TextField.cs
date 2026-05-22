using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000093 RID: 147
	public class TextField : TextInputBaseField<string>
	{
		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00004CF8 File Offset: 0x00002EF8
		public TextField.TextInput textInput
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0000B254 File Offset: 0x00009454
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00004D05 File Offset: 0x00002F05
		public bool multiline
		{
			get
			{
				return this.textInput.multiline;
			}
			set
			{
				this.textInput.multiline = value;
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00004D15 File Offset: 0x00002F15
		public void SelectRange(int rangeCursorIndex, int selectionIndex)
		{
			this.textInput.SelectRange(rangeCursorIndex, selectionIndex);
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00004D26 File Offset: 0x00002F26
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00004D33 File Offset: 0x00002F33
		public override string value
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

		// Token: 0x060003FD RID: 1021 RVA: 0x00004D40 File Offset: 0x00002F40
		public override void SetValueWithoutNotify(string newValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00004D4D File Offset: 0x00002F4D
		public override void OnViewDataReady()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x020001E7 RID: 487
		public class UxmlFactory : UxmlFactory<TextField, TextField.UxmlTraits>
		{
		}

		// Token: 0x020001E8 RID: 488
		public class UxmlTraits : TextInputBaseField<string>.UxmlTraits
		{
		}

		// Token: 0x020001E9 RID: 489
		public class TextInput : TextInputBaseField<string>.TextInputBase
		{
		}
	}
}
