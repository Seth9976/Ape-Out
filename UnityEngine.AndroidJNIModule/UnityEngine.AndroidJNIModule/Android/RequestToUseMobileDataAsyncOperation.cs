using System;

namespace UnityEngine.Android
{
	// Token: 0x02000017 RID: 23
	public class RequestToUseMobileDataAsyncOperation : CustomYieldInstruction
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001DE RID: 478 RVA: 0x000028C8 File Offset: 0x00000AC8
		public override bool keepWaiting
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000028D5 File Offset: 0x00000AD5
		public bool isDone
		{
			get
			{
				return !this.keepWaiting;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x000028E0 File Offset: 0x00000AE0
		public AndroidAssetPackUseMobileDataRequestResult result
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000028ED File Offset: 0x00000AED
		public void OnResult(AndroidAssetPackUseMobileDataRequestResult result)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
