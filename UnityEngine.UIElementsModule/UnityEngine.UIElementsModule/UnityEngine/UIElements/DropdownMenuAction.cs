using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000013 RID: 19
	public class DropdownMenuAction : DropdownMenuItem
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000022C5 File Offset: 0x000004C5
		public string name
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000022D2 File Offset: 0x000004D2
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000022DF File Offset: 0x000004DF
		public DropdownMenuAction.Status status
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

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000022EC File Offset: 0x000004EC
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000022F9 File Offset: 0x000004F9
		public DropdownMenuEventInfo eventInfo
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

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002306 File Offset: 0x00000506
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002313 File Offset: 0x00000513
		public Object userData
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

		// Token: 0x0600003E RID: 62 RVA: 0x00008674 File Offset: 0x00006874
		public static DropdownMenuAction.Status AlwaysEnabled(DropdownMenuAction a)
		{
			return DropdownMenuAction.Status.Normal;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00008688 File Offset: 0x00006888
		public static DropdownMenuAction.Status AlwaysDisabled(DropdownMenuAction a)
		{
			return DropdownMenuAction.Status.Disabled;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002320 File Offset: 0x00000520
		public void UpdateActionStatus(DropdownMenuEventInfo eventInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000232D File Offset: 0x0000052D
		public void Execute()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0200019E RID: 414
		public enum Status
		{
			// Token: 0x0400022B RID: 555
			None,
			// Token: 0x0400022C RID: 556
			Normal,
			// Token: 0x0400022D RID: 557
			Disabled,
			// Token: 0x0400022E RID: 558
			Checked = 4,
			// Token: 0x0400022F RID: 559
			Hidden = 8
		}
	}
}
