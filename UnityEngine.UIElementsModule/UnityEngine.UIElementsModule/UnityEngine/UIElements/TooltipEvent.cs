using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000FE RID: 254
	public class TooltipEvent : EventBase<TooltipEvent>
	{
		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x00005D57 File Offset: 0x00003F57
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x00005D64 File Offset: 0x00003F64
		public string tooltip
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

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00005D71 File Offset: 0x00003F71
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x00005D7E File Offset: 0x00003F7E
		public Rect rect
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

		// Token: 0x06000580 RID: 1408 RVA: 0x00005D8B File Offset: 0x00003F8B
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		public void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation)3;
			this.rect = default(Rect);
			this.tooltip = String.Empty;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00005D98 File Offset: 0x00003F98
		public static TooltipEvent GetPooled(string tooltip, Rect rect)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
