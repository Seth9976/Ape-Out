using System;

namespace UnityEngine.Assertions
{
	// Token: 0x020002DC RID: 732
	public class AssertionException : Exception
	{
		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x000131B3 File Offset: 0x000113B3
		public override string Message
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
