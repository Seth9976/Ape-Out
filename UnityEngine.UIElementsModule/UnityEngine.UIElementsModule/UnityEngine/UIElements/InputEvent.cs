using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D0 RID: 208
	public class InputEvent : EventBase<InputEvent>
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0000588B File Offset: 0x00003A8B
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00005898 File Offset: 0x00003A98
		public string previousData
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

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x000058A5 File Offset: 0x00003AA5
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x000058B2 File Offset: 0x00003AB2
		public string newData
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

		// Token: 0x06000512 RID: 1298 RVA: 0x000058BF File Offset: 0x00003ABF
		public override void Init()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x000058CC File Offset: 0x00003ACC
		public void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation)3;
			this.previousData = null;
			this.newData = null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x000058E7 File Offset: 0x00003AE7
		public static InputEvent GetPooled(string previousData, string newData)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
