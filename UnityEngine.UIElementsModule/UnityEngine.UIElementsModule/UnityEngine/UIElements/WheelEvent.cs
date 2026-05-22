using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000DE RID: 222
	public class WheelEvent : MouseEventBase<WheelEvent>
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00005A0E File Offset: 0x00003C0E
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00005A1B File Offset: 0x00003C1B
		public Vector3 delta
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

		// Token: 0x06000538 RID: 1336 RVA: 0x00005A28 File Offset: 0x00003C28
		public static WheelEvent GetPooled(Event systemEvent)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00005A35 File Offset: 0x00003C35
		public static WheelEvent GetPooled(Vector3 delta)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00005A42 File Offset: 0x00003C42
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00005A4F File Offset: 0x00003C4F
		public void LocalInit()
		{
			this.delta = Vector3.zero;
		}
	}
}
